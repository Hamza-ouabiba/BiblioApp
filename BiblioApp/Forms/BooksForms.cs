using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
namespace BiblioApp.Forms
{
    public partial class BooksForms : UserControl
    {

        public BooksForms()
        {
            InitializeComponent();
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            BookNewEditForm bookNewEditForm = new BookNewEditForm(this,-1);
            bookNewEditForm.ShowDialog();
        }
        public void LoadData()
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                dgvBooks.DataSource = uow.Livre.Find(null, "Auteur,Categorie").Select(l => new
                {
                    IdLivre = l.IdLivre,
                    Titre = l.Title,
                    Description = l.Description,
                    Prix = l.Prix,
                    DatePublication = l.DatePublication,
                    Categorie = l.Categorie.NomCategorie,
                    Auteur = l.Auteur.NomAuteur,
                    nbPage = l.NbPages
                }).ToList();
                txtNbBooks.Text = dgvBooks.RowCount.ToString();
            }
        }
        private void BooksForms_Load(object sender, EventArgs e)
        {
            LoadData();
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
            if(e.ColumnIndex != -1)
            {
                using(UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    Livre livre = uow.Livre.Get(Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["IdLivre"].Value));
                    BookNewEditForm bookNewEditForm = new BookNewEditForm(this,livre.IdLivre);
                    bookNewEditForm.ShowDialog();
                }
            }
        }
    }
}
