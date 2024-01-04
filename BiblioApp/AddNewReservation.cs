﻿using BiblioApp.Forms;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;

namespace BiblioApp
{
    public partial class AddNewReservation : Form
    {
        ReservationForm reservationForm;
        public AddNewReservation()
        {
            InitializeComponent();
        }

        public AddNewReservation(ReservationForm reservationForm)
        {
            InitializeComponent();
            this.reservationForm = reservationForm;
        }

        private void AddNewReservation_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                comboAdherent.DataSource = uow.Adherent.GetAll();
                comboAdherent.ValueMember = "IdAdherent";
                comboAdherent.DisplayMember = "NomAdherent";

                comboLivre.DataSource = uow.Livre.GetAll();
                comboLivre.ValueMember = "IdLivre";
                comboLivre.DisplayMember = "Title";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveReserv_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                try
                {
                    DateTime debut = txtDateDebut.Value.Date;
                    DateTime fin = txtDateFin.Value.Date;
                    DateTime maintenant = DateTime.Now.Date;
                    MessageBox.Show(fin.CompareTo(maintenant).ToString());
                    if ((debut.CompareTo(maintenant) == -1 || debut.CompareTo(maintenant) == 0) && fin.CompareTo(maintenant) == 1)
                    {
                        Reservation reservation = new Reservation()
                        {
                            IdAdherent = Convert.ToInt32(comboAdherent.SelectedValue),
                            IdLivre = Convert.ToInt32(comboLivre.SelectedValue),
                            DateDebut = txtDateDebut.Value.Date,
                            DateFin = txtDateFin.Value.Date
                        };

                        uow.Reservation.Add(reservation);
                        Livre livre = uow.Livre.Get(Convert.ToInt32(comboLivre.SelectedValue));
                        Etat etat = uow.Etat.Get(2);
                        livre.Etat = etat;

                        if (uow.Complete() > 0)
                        {
                            MessageBox.Show("Reservation ajoutée");
                            reservationForm.LoadData();
                        }
                    }
                } catch (Exception inner)
                {
                    MessageBox.Show($"inner Error: {inner.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}