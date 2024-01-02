using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Utils;
using LinqKit;
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
    public partial class ReservationForm : UserControl
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                dgvReservations.DataSource = uow.Reservation.Find(null, "Adherent,Livre").Select(r => new
                {
                    IdLivre = r.IdLivre,
                    TitreLivre = r.Livre.Title,
                    IdAdherent = r.IdAdherent,
                    NomAdherent = r.Adherent.NomAdherent,
                    Date_Debut = r.DateDebut,
                    Date_fin = r.DateFin,
                }).ToList();
                txtNbReservs.Text = dgvReservations.RowCount.ToString();
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            LoadData();

            dgvReservations.Columns["IdLivre"].Visible = false;
            dgvReservations.Columns["IdAdherent"].Visible = false;
            dgvReservations.Columns["NomAdherent"].Width = 300;
            dgvReservations.Columns["TitreLivre"].Width = 300;
            dgvReservations.Columns["Date_Debut"].Width = 300;
            dgvReservations.Columns["Date_fin"].Width = 300;
            SharedData.AddColumnIcon(dgvReservations, "print", "print");
            SharedData.AddColumnIcon(dgvReservations, "delete", "delete");
            SharedData.AddColumnIcon(dgvReservations, "edit", "edit");
            dgvReservations.RowHeadersVisible = false;
        }

        private void btnNewReser_Click(object sender, EventArgs e)
        {
            AddNewReservation addNewReservation = new AddNewReservation();
            addNewReservation.ShowDialog();
        }
    }
}
