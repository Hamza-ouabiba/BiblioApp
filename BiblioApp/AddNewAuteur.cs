using BiblioApp.Forms;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace BiblioApp
{
    public partial class AddNewAuteur : Form
    {
        private readonly AuthorsForm authorForm;
        private readonly int idAuteur;
        private bool vNom, vEmail = false;
        public AddNewAuteur()
        {
            InitializeComponent();
        }
        public AddNewAuteur(AuthorsForm authorsForm, [Optional] int idAuteur)
        {
            InitializeComponent();
            this.authorForm = authorsForm;
            this.idAuteur = idAuteur;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewAuteur_Load(object sender, EventArgs e)
        {
            if (idAuteur != -1)
            {
                btnSaveAut.Text = "Update";
                using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                {
                    Auteur auteur = uow.Auteur.Get(idAuteur);
                    txtEmail.Text = auteur.Email;
                    txtName.Text = auteur.NomAuteur;
                    if (auteur.Genre == "M")
                        txtGenderM.Checked = true;
                    else if (auteur.Genre == "F")
                        txtGenderF.Checked = true;

                    txtTitleForm.Text = "Update auteur";
                }
            }
        }

        private void btnSaveAut_Click(object sender, EventArgs e)
        {
            txtName_Validating(sender, e as CancelEventArgs);
            txtEmail_Validating(sender, e as CancelEventArgs);
            if (vNom && vEmail && (txtGenderF.Checked || txtGenderM.Checked))
            {
                using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                {
                    if (idAuteur == -1)
                    {
                        Auteur auteur = new Auteur()
                        {
                            NomAuteur = txtName.Text,
                            Email = txtEmail.Text,
                            Genre = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text,
                        };
                        uow.Auteur.Add(auteur);

                    }
                    else
                    {
                        Auteur auteur = uow.Auteur.Get(idAuteur);
                        auteur.NomAuteur = txtName.Text;
                        auteur.Email = txtEmail.Text;
                        auteur.Genre = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text;
                    }

                    int res = uow.Complete();

                    if (res > 0)
                    {
                        string state = idAuteur == -1 ? "created" : "updated";
                        MessageBox.Show($"Auteur {state} successfully  ");
                        authorForm.LoadData();
                        this.Close();
                    }
                }
            }
            else MessageBox.Show("Remplir les fields");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            vEmail = SharedData.ValidateData(ErrProvider, txtEmail, "Email error", btnSaveAut, false);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            vNom = SharedData.ValidateData(ErrProvider, txtName, "Nom error", btnSaveAut, false);
        }
    }
}
