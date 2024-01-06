using BiblioApp.Forms;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System.Runtime.InteropServices;

namespace BiblioApp
{
    public partial class AddNewAdherent : Form
    {
        private readonly int idAdherent;
        private readonly AdherentForm adherentForm;
        public AddNewAdherent()
        {
            InitializeComponent();
        }
        public AddNewAdherent(AdherentForm adherentForm, [Optional] int idAdherent)
        {
            InitializeComponent();
            this.adherentForm = adherentForm;
            this.idAdherent = idAdherent;
        }

        private void btnSaveAut_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPrenom.Text != "" && (txtGenderF.Checked || txtGenderM.Checked))
            {
                using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                {
                    if (idAdherent == -1)
                    {
                        Adherent auteur = new Adherent()
                        {
                            NomAdherent = txtName.Text,
                            PrenomAdherent = txtPrenom.Text,
                            Email = txtPrenom.Text,
                            Genre = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text,
                        };
                        uow.Adherent.Add(auteur);
                    }
                    else
                    {
                        Adherent adherent = uow.Adherent.Get(idAdherent);
                        adherent.NomAdherent = txtName.Text;
                        adherent.PrenomAdherent = txtPrenom.Text;
                        adherent.Genre = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text;
                    }
                    int res = uow.Complete();

                    if (res > 0)
                    {
                        string state = idAdherent == -1 ? "created" : "updated";
                        MessageBox.Show($"Adherent {state} successfully  ");
                        adherentForm.LoadData();
                        this.Close();
                    }
                }
            }
            else MessageBox.Show("Remplir les fields");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewAdherent_Load(object sender, EventArgs e)
        {
            if (idAdherent != -1)
            {
                btnSaveAut.Text = "Update";
                using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                {
                    Adherent adherent = uow.Adherent.Get(idAdherent);
                    txtEmail.Text = adherent.Email;
                    txtName.Text = adherent.NomAdherent;
                    txtPrenom.Text = adherent.PrenomAdherent;
                    if (adherent.Genre == "M")
                        txtGenderM.Checked = true;
                    else if (adherent.Genre == "F")
                        txtGenderF.Checked = true;

                    txtTitleForm.Text = "Update Adherent";
                }
            }
        }
    }
}
