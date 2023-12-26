using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BiblioApp.Forms
{
    public partial class AuthorsForm : UserControl
    {
        private int idAuthorUp;
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void LoadData(UnitOfWork uow)
        {
            dgvAuthors.DataSource = uow.Auteur.Find(null, "Livres").Select(p => new
            {
                p.IdAuteur,
                p.NomAuteur,
                p.Email,
                p.Genre,
                nbBooks = p.Livres.Count()
            }).ToList();
        }
        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                Auteur auteur = new Auteur()
                {
                    NomAuteur = txtName.Text,
                    Email = txtEmail.Text,
                    Genre = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text
                };
                uow.Auteur.Add(auteur);
                int res = uow.Complete();
                if (res > 0)
                {
                    MessageBox.Show("Author created successfully ID : " + auteur.IdAuteur, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(uow);
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtName.Focus();
                    txtGenderM.Select();
                    txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                }
            }
        }
        private void AuthorsForm_Load(object sender, EventArgs e)
        {
           txtName.Focus();
            txtGenderM.Select();
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                LoadData(uow);

                dgvAuthors.Columns["IdAuteur"].Visible = false;
                dgvAuthors.Columns["NomAuteur"].Width = 300;
                dgvAuthors.Columns["Email"].Width = 300;
                dgvAuthors.Columns["Genre"].Width = 100;
                dgvAuthors.Columns["nbBooks"].Width = 100;
                dgvAuthors.RowHeadersVisible = false;
                txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                btnUpdateAuthor.Visible = false;
            }
        }

        private void dgvAuthors_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dgvAuthors.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "print")
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
            /*if (e.ColumnIndex != -1)
            {
                string colName = dgvAuthors.Columns[e.ColumnIndex].Name;
                Guid idAuthor = Guid.Parse(dgvAuthors.Rows[e.RowIndex].Cells["IdAuthor"].Value.ToString());
                if (colName == "delete")
                {
                    bool confirm = ConfirmDelete("Voulez vous vraiment supprimer cet auteur  ?");
                    if (confirm)
                    {
                        using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                        {
                            Author author = uow.Authors.Get(idAuthor);
                            uow.Authors.Remove(author);
                            uow.Complete();
                            LoadData(uow);
                            txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                        }
                    }

                }
                if (colName == "print")
                {
                    using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                    {
                        Author author = uow.Authors.Find(a=>a.IdAuthor==idAuthor, "Books").FirstOrDefault();
                        AuthorViewModel av = new AuthorViewModel()
                        {
                            IdAuthor = author.IdAuthor,
                            Name = author.Name,
                            Email = author.Email,
                            Gender = author.Gender,
                            nbBooks = author.Books.Count
                        };
                        DataTable dt = new DataTable();
                        var props = typeof(AuthorViewModel).GetProperties();
                        dt.Columns.AddRange(
                           props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray()
                            );
                        dt.Rows.Add(props.Select(p => p.GetValue(av, null)).ToArray());

                        string RptPath = @"Reports\ListAuthors.rdlc";
                        string NameSrcRpt = "ds_listAuthors";
                        
                        string fileName = "ListAuthors";
                        PrintToPDF(RptPath, NameSrcRpt, dt, fileName,true);



                    }
                }
            }*/
        }

        private void dgvAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex >= 0)
            {
                idAuthorUp = Guid.Parse(dgvAuthors.Rows[e.RowIndex].Cells["IdAuthor"].Value.ToString());
                using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                {
                    Author auth = uow.Authors.Get(idAuthorUp);
                    txtName.Text = auth.Name;
                    txtEmail.Text = auth.Email;
                    txtGenderM.Checked = (auth.Gender == "M") ? true : false;
                    txtGenderF.Checked = (auth.Gender == "F") ? true : false;
                    btnUpdateAuthor.Visible = true;
                }
            }*/
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
/*            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                Auteur auth = uow.Auteur.Get(idAuthorUp);
                auth.Name=txtName.Text ;
                auth.Email = txtEmail.Text;
                auth.Gender = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text;
                uow.Complete();
                LoadData(uow);
                btnUpdateAuthor.Visible = false;
            }*/
        }
    }
}
