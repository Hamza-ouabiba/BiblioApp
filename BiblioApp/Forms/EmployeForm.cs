using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Utils;
using LinqKit;
using System.Data;
using System.Linq.Expressions;

namespace BiblioApp.Forms
{
    public partial class EmployeForm : UserControl
    {
        private readonly int idEmp;
        private Pagination pagination;
        private int TotalPages;
        public EmployeForm()
        {
            InitializeComponent();
        }
        public EmployeForm(int idCurrentEmp)
        {
            InitializeComponent();
            this.idEmp = idCurrentEmp;
            pagination = new Pagination()
            {
                PageIndex = 1,
                PageSize = 7,
            };
        }
        private int CalculatePages()
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                return (int)Math.Ceiling((double)uow.Livre.GetAll().Count() / pagination.PageSize);
            }
        }
        private void PageLastModifier()
        {
            if (dgvEmployes.Rows.Count == 1 && pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
            }
        }
        public void LoadData()
        {
            //initializing a predicate delegate : 
            var predicate = PredicateBuilder.New<Employe>(true);
            predicate = predicate.And(l => l.IdEmploye != idEmp);

            if (!string.IsNullOrEmpty(txtNameCriteria.Text))
            {
                predicate = predicate.And(e => e.Nom.Contains(txtNameCriteria.Text));
            }

            TotalPages = CalculatePages();
            txtCurrentPage.Text = $"{pagination.PageIndex}/{TotalPages}";

            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                dgvEmployes.DataSource = uow.Employe.Find(predicate, "", pagination).Select(e => new
                {
                    IdEmploye = e.IdEmploye,
                    Nom_Employe = e.Nom,
                    E_mail_employe = e.Email,
                    Etat = e.IsAdmin == true ? "Administrateur" : "Utilisateur normal",
                    Sexe_Employe = e.Genre,
                }).ToList();
                txtNbEmploye.Text = dgvEmployes.RowCount.ToString();
            }
        }

        private void EmployeForm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                LoadData();

                dgvEmployes.Columns["IdEmploye"].Visible = false;
                dgvEmployes.Columns["Nom_Employe"].Width = 300;
                dgvEmployes.Columns["E_mail_employe"].Width = 300;
                dgvEmployes.Columns["Etat"].Width = 300;
                dgvEmployes.Columns["Sexe_Employe"].Width = 300;
                SharedData.AddColumnIcon(dgvEmployes, "print", "print");
                SharedData.AddColumnIcon(dgvEmployes, "delete", "delete");
                SharedData.AddColumnIcon(dgvEmployes, "edit", "edit");
            }
        }

        private void dgvEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dgvEmployes.Columns[e.ColumnIndex].Name;
                int idEmploye = int.Parse(dgvEmployes.Rows[e.RowIndex].Cells["IdEmploye"].Value.ToString());
                if (colName == "delete")
                {
                    bool confirm = SharedData.ConfirmDelete("Voulez vous vraiment supprimer cet auteur  ?");
                    if (confirm)
                    {
                        using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                        {
                            Employe employe = uow.Employe.Get(idEmploye);
                            uow.Employe.Remove(employe);
                            uow.Complete();
                            LoadData();
                            txtNbEmploye.Text = dgvEmployes.RowCount.ToString();
                            MessageBox.Show($"Employe {employe.Nom} supprimée !");
                        }
                    }

                }
                if (colName == "edit")
                {

                }
            }
        }

        private void dgvEmployes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dgvEmployes.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "print")
                {
                    dgvEmployes.Cursor = Cursors.Default;
                }
                else
                {
                    dgvEmployes.Cursor = Cursors.Hand;
                }
            }
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            AjouEmploye ajouEmploye = new AjouEmploye(this);
            ajouEmploye.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
                LoadData();
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            pagination.PageIndex = TotalPages;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pagination.PageIndex = 1;
        }
    }
}
