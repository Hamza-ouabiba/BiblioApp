using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Utils;
using LinqKit;
using System.Data;

namespace BiblioApp.Forms
{
    public partial class ReservationForm : UserControl
    {
        private int TotalPages;
        private Pagination pagination;
        public ReservationForm()
        {
            InitializeComponent();
            this.pagination = new Pagination()
            {
                PageIndex = 1,
                PageSize = 7
            };
        }
        private void PageLastModifier()
        {
            if (dgvReservations.Rows.Count == 1 && pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
            }
        }
        private int CalculatePages()
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                return (int)Math.Ceiling((double)uow.Auteur.GetAll().Count() / pagination.PageSize);
            }
        }


        public void LoadData()
        {
            try
            {
                var predicate = PredicateBuilder.New<Reservation>(true);
                if (!string.IsNullOrEmpty(txtAdherentCriteria.Text))
                {
                    if (txtAdherentCriteria.SelectedIndex != 0)
                    {
                        predicate = predicate.And(e => e.Adherent.NomAdherent == txtAdherentCriteria.Text);
                    }
                }

                TotalPages = CalculatePages();
                txtCurrentPage.Text = $"{pagination.PageIndex}/{TotalPages}";
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    dgvReservations.DataSource = uow.Reservation.Find(predicate, "Adherent,Livre").Select(r => new
                    {
                        IdReservation = r.IdReservation,
                        IdLivre = r.IdLivre,
                        TitreLivre = r.Livre.Title,
                        IdAdherent = r.IdAdherent,
                        NomAdherent = r.Adherent.NomAdherent,
                        Date_Debut = r.DateDebut,
                        Date_fin = r.DateFin,
                        Status = r.Status == true ? "Terminée" : "En cours"
                    }).ToList();
                    txtNbReservs.Text = dgvReservations.RowCount.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                txtAdherentCriteria.Items.Add(new Adherent()
                {
                    IdAdherent = -1,
                    NomAdherent = "----Tous les Adherents----"
                });
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    foreach (Adherent adherent in uow.Adherent.GetAll())
                    {
                        txtAdherentCriteria.Items.Add(adherent);
                    }
                    txtAdherentCriteria.ValueMember = "IdAdherent";
                    txtAdherentCriteria.DisplayMember = "NomAdherent";
                    txtAdherentCriteria.SelectedIndex = 0;
                }

                dgvReservations.Columns["IdReservation"].Visible = false;
                dgvReservations.Columns["IdLivre"].Visible = false;
                dgvReservations.Columns["IdAdherent"].Visible = false;
                dgvReservations.Columns["NomAdherent"].Width = 300;
                dgvReservations.Columns["TitreLivre"].Width = 300;
                dgvReservations.Columns["Date_Debut"].Width = 300;
                dgvReservations.Columns["Date_fin"].Width = 300;
                SharedData.AddColumnIcon(dgvReservations, "delete", "delete");
                SharedData.AddColumnIcon(dgvReservations, "edit", "edit");
                dgvReservations.RowHeadersVisible = false;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnNewReser_Click(object sender, EventArgs e)
        {
            AddNewReservation addNewReservation = new AddNewReservation(this, -1);
            addNewReservation.ShowDialog();
        }

        private void rechercherBtn_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pagination.PageIndex < TotalPages)
            {
                pagination.PageIndex++;
                LoadData();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
                LoadData();
            }
        }

        private void dgvReservations_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1)
                {
                    string colName = dgvReservations.Columns[e.ColumnIndex].Name;
                    if (colName != "delete" && colName != "edit")
                    {
                        dgvReservations.Cursor = Cursors.Default;
                    }
                    else
                    {
                        dgvReservations.Cursor = Cursors.Hand;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1)
                {
                    string colName = dgvReservations.Columns[e.ColumnIndex].Name;
                    int idReservation = int.Parse(dgvReservations.Rows[e.RowIndex].Cells["IdReservation"].Value.ToString());
                    if (colName == "delete")
                    {
                        bool confirm = SharedData.ConfirmDelete("Voulez vous vraiment supprimer cett reservation  ?");
                        if (confirm)
                        {
                            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                            {
                                Reservation reservation = uow.Reservation.Get(idReservation);
                                uow.Reservation.Remove(reservation);
                                uow.Complete();
                                LoadData();
                                PageLastModifier();
                                txtNbReservs.Text = dgvReservations.RowCount.ToString();
                                MessageBox.Show($"reservation {reservation.IdReservation} supprimée !");
                            }
                        }

                    }
                    if (colName == "edit")
                    {
                        using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                        {
                            Reservation reservation = uow.Reservation.Get(idReservation);
                            if (reservation.Status == true)
                            {
                                SharedData.MessageUser("Reservation non modifiable");
                            }
                            else
                            {
                                AddNewReservation addNewReservation = new AddNewReservation(this, reservation.IdReservation);
                                addNewReservation.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvReservations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvReservations.Rows.Count; i++)
            {
                if (dgvReservations.Rows[i].Cells["Status"].Value.ToString() == "Terminée")
                {
                    dgvReservations.Rows[i].Cells["Status"].Style.BackColor = Color.Lime;
                }
                else if (dgvReservations.Rows[i].Cells["Status"].Value.ToString() == "En cours")
                {
                    dgvReservations.Rows[i].Cells["Status"].Style.BackColor = Color.Red;
                }
            }
        }
    }
}
