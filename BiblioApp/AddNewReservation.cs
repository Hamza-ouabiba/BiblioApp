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

namespace BiblioApp
{
    public partial class AddNewReservation : Form
    {
        public AddNewReservation()
        {
            InitializeComponent();
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
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                if(txtDateDebut.Value.Date <= DateTime.Now && (txtDateFin.Value.Date >= DateTime.Now) ) 
                {
                    if(txtDateDebut.Value.Date  <= txtDateFin.Value.Date) 
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
                        MessageBox.Show(livre.IdEtat.ToString());
                        MessageBox.Show(livre.Title);
                        if (uow.Complete() > 0)
                        {
                            //updating the state of the book : 
                            
                            MessageBox.Show("Reservation ajoutée");
                        }
                    }
                }
            }
        }
    }
}
