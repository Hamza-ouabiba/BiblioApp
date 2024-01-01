using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Utils;
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
                PageSize = 5,
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
        public void LoadData()
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                dgvBooks.DataSource = uow.Livre.Find(null, "Auteur,Categorie,Etat",pagination).Select(l => new
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
        }
        private void BooksForms_Load(object sender, EventArgs e)
        {
            LoadData();
            TotalPages = CalculatePages();
            txtCurrentPage.Text = $"{pagination.PageIndex}/{TotalPages}";
            dgvBooks.Columns["IdLivre"].Visible = false;
            dgvBooks.Columns["Titre"].Width = 300;
            dgvBooks.Columns["Description"].Width = 300;
            dgvBooks.Columns["DatePublication"].Width = 300;
            dgvBooks.Columns["Auteur"].Width = 300;
            dgvBooks.Columns["Categorie"].Width = 300;
            dgvBooks.Columns["Prix"].Width = 100;
            dgvBooks.Columns["nbPage"].Width = 100;
            dgvBooks.RowHeadersVisible = false;
            SharedData.AddColumnIcon(dgvBooks, "print", "print");
            SharedData.AddColumnIcon(dgvBooks, "delete", "delete");
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            LoadData();
                            txtNbBooks.Text = dgvBooks.RowCount.ToString();
                            MessageBox.Show($"Livre {livre.Title} supprimée !");
                        }
                    }

                }
                if (colName == "print")
                {

                }
            }
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    Livre livre = uow.Livre.Get(Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["IdLivre"].Value));
                    BookNewEditForm bookNewEditForm = new BookNewEditForm(this, livre.IdLivre);
                    bookNewEditForm.ShowDialog();
                }
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
    }
}
