using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioApp.Forms
{
    public partial class AdherentForm : UserControl
    {
        int idAdherentUp;
        public AdherentForm()
        {
            InitializeComponent();
        }

        private void AdherentForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                LoadData(uow);

                dgvAdherent.Columns["IdAdherent"].Visible = false;
                dgvAdherent.Columns["Nom"].Width = 300;
                dgvAdherent.Columns["Prenom"].Width = 300;
                dgvAdherent.Columns["Email"].Width = 300;
                dgvAdherent.RowHeadersVisible = false;
                SharedData.AddColumnIcon(dgvAdherent, "print", "print");
                SharedData.AddColumnIcon(dgvAdherent, "delete", "delete");
                txtNbAdherents.Text = dgvAdherent.RowCount.ToString();
                btnUpdateAdherent.Visible = false;
            }
        }
        private void LoadData(UnitOfWork uow)
        {
            dgvAdherent.DataSource = uow.Adherent.Find(null, "").Select(a => new
            {
                IdAdherent = a.IdAdherent,
                Prenom = a.PrenomAdherent,
                Nom = a.NomAdherent,
                Email = a.Email,
            }).ToList();
        }
        private void btnSaveAdherent_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "")
            {
                using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                {
                    Adherent adherent = new Adherent()
                    {
                        NomAdherent = txtName.Text,
                        DateInscription = DateTime.Now,
                        Email = txtEmail.Text,
                        PrenomAdherent = txtPrenom.Text
                    };
                    uow.Adherent.Add(adherent);
                    int res = uow.Complete();
                    if (res > 0)
                    {
                        MessageBox.Show("Adherent created successfully ID : " + adherent.IdAdherent, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(uow);
                        txtName.Text = "";
                        txtEmail.Text = "";
                        txtName.Focus();
                        txtNbAdherents.Text = dgvAdherent.RowCount.ToString();
                    }
                }
            }
            else MessageBox.Show("Remplir les fields");
        }

       
        public void ViderFields()
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtPrenom.Text = "";
        }
        private void btnUpdateAdherent_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                Adherent adherent = uow.Adherent.Get(idAdherentUp);
                adherent.NomAdherent = txtName.Text;
                adherent.PrenomAdherent = txtPrenom.Text;
                adherent.Email = txtEmail.Text;
                if(uow.Complete() > 0 )
                {
                    LoadData(uow);
                    btnUpdateAdherent.Visible = false;
                    ViderFields();
                }
            }
        }

        private void dgvAdherent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idAdherentUp = int.Parse(dgvAdherent.Rows[e.RowIndex].Cells["IdAdherent"].Value.ToString());
            MessageBox.Show(idAdherentUp.ToString());
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                Adherent adh = uow.Adherent.Get(idAdherentUp);
                txtName.Text = adh.NomAdherent;
                txtPrenom.Text = adh.PrenomAdherent;
                txtEmail.Text = adh.Email;
                btnUpdateAdherent.Visible = true;
            }
        }
    }
}
