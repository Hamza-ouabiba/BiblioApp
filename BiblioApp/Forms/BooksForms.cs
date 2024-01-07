using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Utils;
using LinqKit;
using System.Data;
namespace BiblioApp.Forms
{
    public partial class BooksForms : UserControl
    {
        private int TotalPages;
        private Pagination pagination;
        public BooksForms()
        {
            InitializeComponent();
            pagination = new Pagination()
            {
                PageSize = 7,
                PageIndex = 1
            };
        }
        private int CalculatePages()
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                return (int)Math.Ceiling((double)uow.Livre.GetAll().Count() / pagination.PageSize);
            }
        }
        private void btnNewBook_Click(object sender, EventArgs e)
        {
            BookNewEditForm bookNewEditForm = new BookNewEditForm(this, -1);
            bookNewEditForm.ShowDialog();
        }
        private void PageLastModifier()
        {
            if (dgvBooks.Rows.Count == 1 && pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
            }
        }
        public void LoadData()
        {
            try
            {
                //initializing a delegate : 
                var predicate = PredicateBuilder.New<Livre>(true);

                Auteur auteur = (Auteur)txtAuthorCriteria.SelectedItem;
                Categorie categorie = (Categorie)txtCategoryCriteria.SelectedItem;

                if (!string.IsNullOrEmpty(txtTitleCriteria.Text))
                    predicate = predicate.And(l => l.Title.ToLower().Contains(txtTitleCriteria.Text.ToLower()));

                if (!string.IsNullOrEmpty(txtCategoryCriteria.Text))
                {
                    if (txtCategoryCriteria.SelectedIndex != 0)
                    {
                        predicate = predicate.And(l => l.Categorie.NomCategorie.ToLower().Contains(txtCategoryCriteria.Text.ToLower()));
                    }
                }

                if (!string.IsNullOrEmpty(txtAuthorCriteria.Text))
                {
                    if (txtAuthorCriteria.SelectedIndex != 0)
                    {
                        predicate = predicate.And(l => l.IdAuteur == auteur.IdAuteur);
                    }
                }

                TotalPages = CalculatePages();
                txtCurrentPage.Text = $"{pagination.PageIndex}/{TotalPages}";

                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    dgvBooks.DataSource = uow.Livre.Find(predicate, "Auteur,Categorie,Etat", pagination).Select(l => new
                    {
                        IdLivre = l.IdLivre,
                        Titre = l.Title,
                        Description = l.Description,
                        Prix = l.Prix,
                        DatePublication = l.DatePublication,
                        Categorie = l.Categorie.NomCategorie,
                        Etat = l.Etat.Nom,
                        Auteur = l.Auteur.NomAuteur,
                        nbPage = l.NbPages,
                    }).ToList();
                    txtNbBooks.Text = dgvBooks.RowCount.ToString();
                }
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void BooksForms_Load(object sender, EventArgs e)
        {
           try
            {
                LoadData();
                txtCategoryCriteria.Items.Add(new Categorie()
                {
                    IdCategorie = -1,
                    NomCategorie = "----Tous les categories----"
                });
                txtAuthorCriteria.Items.Add(new Auteur()
                {
                    IdAuteur = -1,
                    NomAuteur = "----Tous les auteurs----"
                });
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    foreach (Auteur auteur in uow.Auteur.GetAll())
                    {
                        txtAuthorCriteria.Items.Add(auteur);
                    }
                    foreach (Categorie categorie in uow.Category.GetAll())
                    {
                        txtCategoryCriteria.Items.Add(categorie);
                    }
                    txtAuthorCriteria.ValueMember = "IdAuteur";
                    txtAuthorCriteria.DisplayMember = "NomAuteur";
                    txtAuthorCriteria.SelectedIndex = 0;

                    txtCategoryCriteria.ValueMember = "IdCategorie";
                    txtCategoryCriteria.DisplayMember = "NomCategorie";
                    txtCategoryCriteria.SelectedIndex = 0;
                }
                dgvBooks.Columns["IdLivre"].Visible = false;
                dgvBooks.Columns["Titre"].Width = 300;
                dgvBooks.Columns["Description"].Width = 300;
                dgvBooks.Columns["DatePublication"].Width = 300;
                dgvBooks.Columns["Auteur"].Width = 300;
                dgvBooks.Columns["Categorie"].Width = 300;
                dgvBooks.Columns["Prix"].Width = 100;
                dgvBooks.Columns["nbPage"].Width = 100;
                SharedData.AddColumnIcon(dgvBooks, "delete", "delete");
                SharedData.AddColumnIcon(dgvBooks, "edit", "edit");
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (e.ColumnIndex != -1)
                {
                    string colName = dgvBooks.Columns[e.ColumnIndex].Name;
                    int idLivre = int.Parse(dgvBooks.Rows[e.RowIndex].Cells["IdLivre"].Value.ToString());
                    if (colName == "delete")
                    {
                        bool confirm = SharedData.ConfirmDelete("Voulez vous vraiment supprimer ce livre  ?");
                        if (confirm)
                        {
                            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                            {
                                Livre livre = uow.Livre.Get(idLivre);

                                uow.Livre.Remove(livre);
                                uow.Complete();
                                //btnFirst_Click(sender, e); // worst case scenario : 
                                PageLastModifier();
                                LoadData();
                                MessageBox.Show($"Livre {livre.Title} supprimée !");
                            }
                        }
                    }
                    if (colName == "edit")
                    {
                        using (UnitOfWork uow = new(new BibliothequeDbContext()))
                        {
                            Livre livre = uow.Livre.Get(Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["IdLivre"].Value));
                            BookNewEditForm bookNewEditForm = new BookNewEditForm(this, livre.IdLivre);
                            bookNewEditForm.ShowDialog();
                        }
                    }
                }
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            pagination.PageIndex = TotalPages;
            LoadData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pagination.PageIndex = 1;
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dgvBooks.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "print" && colName != "edit")
                {
                    dgvBooks.Cursor = Cursors.Default;
                }
                else
                {
                    dgvBooks.Cursor = Cursors.Hand;
                }
            }
        }
    }
}
