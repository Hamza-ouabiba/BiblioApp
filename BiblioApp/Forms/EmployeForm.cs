using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System.Data;
using System.Linq.Expressions;

namespace BiblioApp.Forms
{
    public partial class EmployeForm : UserControl
    {
        private readonly int idEmp;
        public EmployeForm()
        {
            InitializeComponent();
        }
        public EmployeForm(int idCurrentEmp)
        {
            InitializeComponent();
            this.idEmp = idCurrentEmp;
        }
        public void LoadData(UnitOfWork uow)
        {
            Expression<Func<Employe, bool>> search = e => e.IdEmploye != idEmp;
            dgvEmployes.DataSource = uow.Employe.Find(search, "").Select(e => new
            {
                IdEmploye = e.IdEmploye,
                Nom_Employe = e.Nom,
                E_mail_employe = e.Email,
                Etat = e.IsAdmin == true ? "Administrateur" : "Utilisateur normal",
                Sexe_Employe = e.Genre,
            }).ToList();
            txtNbEmploye.Text = dgvEmployes.RowCount.ToString();
        }

        private void EmployeForm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                LoadData(uow);

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
                            LoadData(uow);
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
    }
}
