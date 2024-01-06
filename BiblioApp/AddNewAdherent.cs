using BiblioApp.Forms;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
 }
