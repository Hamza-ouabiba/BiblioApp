using BiblioApp.Forms;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System.Runtime.InteropServices;

namespace BiblioApp
{
    public partial class AddNewReservation : Form
    {
        private readonly ReservationForm reservationForm;
        private readonly int idReservation;
        public AddNewReservation()
        {
            InitializeComponent();
        }

        public AddNewReservation(ReservationForm reservationForm, [Optional] int IdReservation)
        {
            InitializeComponent();
            this.reservationForm = reservationForm;
            this.idReservation = IdReservation;
        }

        private void AddNewReservation_Load(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    comboAdherent.DataSource = uow.Adherent.GetAll();
                    comboAdherent.ValueMember = "IdAdherent";
                    comboAdherent.DisplayMember = "NomAdherent";

                    comboLivre.DataSource = uow.Livre.GetAll();
                    comboLivre.ValueMember = "IdLivre";
                    comboLivre.DisplayMember = "Title";
                    if (idReservation != -1)
                    {
                        btnTerminer.Visible = true;
                        txtTitleForm.Text = "Update Reservation";
                        btnSaveReserv.Text = "Update Reservation";
                        Reservation reservation = uow.Reservation.Get(idReservation);
                        comboLivre.SelectedItem = reservation.Livre;
                        comboAdherent.SelectedItem = reservation.Adherent;
                        txtDateDebut.Value = (DateTime)reservation.DateDebut;
                        txtDateFin.Value = (DateTime)reservation.DateFin;
                    }
                }
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveReserv_Click(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    DateTime debut = txtDateDebut.Value.Date;
                    DateTime fin = txtDateFin.Value.Date;
                    DateTime maintenant = DateTime.Now.Date;
                    string affichage = "Ajouté";
                    if ((debut.CompareTo(maintenant) == -1 || debut.CompareTo(maintenant) == 0) && fin.CompareTo(maintenant) == 1)
                    {
                        if (idReservation == -1)
                        {
                            if (uow.Livre.IsBookEmprunte(Convert.ToInt32(comboLivre.SelectedValue)))
                            {
                                Reservation reservation = new Reservation()
                                {
                                    IdAdherent = Convert.ToInt32(comboAdherent.SelectedValue),
                                    IdLivre = Convert.ToInt32(comboLivre.SelectedValue),
                                    DateDebut = txtDateDebut.Value.Date,
                                    DateFin = txtDateFin.Value.Date,
                                    Status = false
                                };

                                uow.Reservation.Add(reservation);
                                Livre livre = uow.Livre.Get(Convert.ToInt32(comboLivre.SelectedValue));
                                Etat etat = uow.Etat.GetEtatByName("Emprunté");
                                livre.Etat = etat;

                            }
                            else SharedData.MessageUser($"Livre {uow.Livre.Get(Convert.ToInt32(comboLivre.SelectedValue)).Title} est déja reservé");
                        }
                        else
                        {
                            Reservation reservation = uow.Reservation.Get(idReservation);
                            reservation.IdAdherent = Convert.ToInt32(comboAdherent.SelectedValue);
                            reservation.IdLivre = Convert.ToInt32(comboLivre.SelectedValue);
                            reservation.DateDebut = txtDateDebut.Value.Date;
                            reservation.DateFin = txtDateFin.Value.Date;
                            affichage = "Modifiée";
                        }

                        if (uow.Complete() > 0)
                        {
                            MessageBox.Show($"Reservation {affichage}");
                            reservationForm.LoadData();
                            this.Close();
                        }
                    }
                }
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnTerminer_Click(object sender, EventArgs e)
        {
          try
            {
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    Reservation reservation = uow.Reservation.Get(idReservation);
                    Livre livre = uow.Livre.Get(reservation.IdLivre);
                    livre.IdEtat = uow.Etat.GetEtatByName("Disponible").IdEtat;
                    reservation.Status = true;
                    if (uow.Complete() > 0)
                    {
                        SharedData.MessageUser("Reservation est terminée");
                        reservationForm.LoadData();
                    }
                }
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
