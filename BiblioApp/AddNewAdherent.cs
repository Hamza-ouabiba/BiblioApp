using BiblioApp.Forms;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace BiblioApp
{
    public partial class AddNewAdherent : Form
    {
        private readonly int idAdherent;
        private readonly AdherentForm adherentForm;
        private bool vNom, vPrenom, vEmail = false;
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
            try
            {

                txtName_Validating(sender, e as CancelEventArgs);
                txtEmail_Validating(sender, e as CancelEventArgs);
                txtPrenom_Validating(sender, e as CancelEventArgs);

                if (vNom && vPrenom && vEmail && (txtGenderF.Checked || txtGenderM.Checked))
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
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewAdherent_Load(object sender, EventArgs e)
        {
            try
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
            } catch(Exception excpetion)
            {
                MessageBox.Show(excpetion.Message);
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            vNom = SharedData.ValidateData(ErrProvider, txtName, "Name error", btnSaveAut, false);
        }

        private void txtPrenom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            vPrenom = SharedData.ValidateData(ErrProvider, txtPrenom, "Prenom error", btnSaveAut, false);
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            vEmail = SharedData.ValidateData(ErrProvider, txtEmail, "Email error", btnSaveAut, false);
        }
    }
}
