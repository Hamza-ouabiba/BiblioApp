using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Utils;
using LinqKit;
using System.Data;
namespace BiblioApp.Forms
{
    public partial class AuthorsForm : UserControl
    {
        private int TotalPages;
        private Pagination pagination;
        private bool trie = false;
        private bool trieAscendant = true;
        public AuthorsForm()
        {
            InitializeComponent();
            pagination = new Pagination()
            {
                PageSize = 7,
                PageIndex = 1
            };
        }
        private void PageLastModifier()
        {
            if (dgvAuthors.Rows.Count == 1 && pagination.PageIndex > 1)
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
                //initializing a predicate delegate : 
                var predicate = PredicateBuilder.New<Auteur>(true);

                if (!string.IsNullOrEmpty(txtNameCriteria.Text))
                {
                    predicate = predicate.And(e => e.NomAuteur.Contains(txtNameCriteria.Text));
                }

                TotalPages = CalculatePages();
                txtCurrentPage.Text = $"{pagination.PageIndex}/{TotalPages}";

                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    var query = uow.Auteur.Find(predicate, "Livres", pagination).Select(p => new
                    {
                        p.IdAuteur,
                        p.NomAuteur,
                        p.Email,
                        p.Genre,
                        nbBooks = p.Livres.Count()
                    });

                    query = trie ? (trieAscendant ? query.OrderBy(p => p.nbBooks) :
                        query.OrderByDescending(p => p.nbBooks)) : query;

                    dgvAuthors.DataSource = query.ToList();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                {
                    LoadData();

                    dgvAuthors.Columns["IdAuteur"].Visible = false;
                    dgvAuthors.Columns["NomAuteur"].Width = 300;
                    dgvAuthors.Columns["Email"].Width = 300;
                    dgvAuthors.Columns["Genre"].Width = 100;
                    dgvAuthors.Columns["nbBooks"].Width = 100;
                    dgvAuthors.RowHeadersVisible = false;
                    SharedData.AddColumnIcon(dgvAuthors, "delete", "delete");
                    SharedData.AddColumnIcon(dgvAuthors, "edit", "edit");
                    txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvAuthors_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dgvAuthors.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "edit")
                {
                    dgvAuthors.Cursor = Cursors.Default;
                }
                else
                {
                    dgvAuthors.Cursor = Cursors.Hand;
                }
            }
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1)
                {
                    string colName = dgvAuthors.Columns[e.ColumnIndex].Name;
                    int idAuteur = int.Parse(dgvAuthors.Rows[e.RowIndex].Cells["IdAuteur"].Value.ToString());
                    if (colName == "delete")
                    {
                        bool confirm = SharedData.ConfirmDelete("Voulez vous vraiment supprimer cet auteur  ?");
                        if (confirm)
                        {
                            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                            {
                                Auteur auteur = uow.Auteur.Get(idAuteur);
                                uow.Auteur.Remove(auteur);
                                uow.Complete();
                                LoadData();
                                PageLastModifier();
                                txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                                MessageBox.Show($"Auteur {auteur.NomAuteur} supprimée !");
                            }
                        }

                    }
                    if (colName == "edit")
                    {
                        AddNewAuteur addAu = new AddNewAuteur(this, idAuteur);
                        addAu.ShowDialog();
                    }
                }
            }
            catch (Exception exception)
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

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pagination.PageIndex = 1;
            LoadData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pagination.PageIndex = TotalPages;
            LoadData();
        }

        private void btnNewAuteur_Click(object sender, EventArgs e)
        {
            AddNewAuteur addAu = new AddNewAuteur(this, -1);
            addAu.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTrieLivre_Click(object sender, EventArgs e)
        {
            this.trie = true;
            trieAscendant = !trieAscendant;
            LoadData() ;
        }
    }
}
