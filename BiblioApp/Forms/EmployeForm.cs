using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System.Data;

namespace BiblioApp.Forms
{
    public partial class EmployeForm : UserControl
    {
        public EmployeForm()
        {
            InitializeComponent();
        }
        private void LoadData(UnitOfWork uow)
        {
            dgvEmployes.DataSource = uow.Employe.Find(null, "").Select(e => new
            {
                e.IdEmploye,
                e.Nom,
                e.Email,
                e.IsAdmin,
                e.Genre
            }).ToList();
        }
        private void btnSaveEmploye_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && (txtGenderF.Checked || txtGenderM.Checked))
            {
                using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                {
                    Employe employe = new Employe()
                    {
                        Nom = txtName.Text,
                        Email = txtEmail.Text,
                        Genre = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text
                    };
                    MessageBox.Show(employe.Email);
                    uow.Employe.Add(employe);
                    int res = uow.Complete();
                    if (res > 0)
                    {
                        MessageBox.Show("Employee created successfully ID : " + employe.IdEmploye, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(uow);
                        txtName.Text = "";
                        txtEmail.Text = "";
                        txtName.Focus();
                        txtGenderM.Select();
                    }
                }
            }
            else MessageBox.Show("Remplir les fields");
        }

        private void EmployeForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            txtGenderM.Select();
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                LoadData(uow);

                dgvEmployes.Columns["IdEmploye"].Visible = false;
                dgvEmployes.Columns["Nom"].Width = 300;
                dgvEmployes.Columns["Email"].Width = 300;
                dgvEmployes.Columns["genre"].Width = 100;
                dgvEmployes.RowHeadersVisible = false;
                SharedData.AddColumnIcon(dgvEmployes, "print", "print");
                SharedData.AddColumnIcon(dgvEmployes, "delete", "delete");
                SharedData.AddColumnIcon(dgvEmployes, "edit", "edit");
                txtNbEmploye.Text = dgvEmployes.RowCount.ToString();
                btnUpdateEmploye.Visible = false;
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
    }
}
