using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using BiblioApp.Repository.Interfaces;
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
        private int TotalPages;
        private Pagination pagination;
        public ReservationForm()
        {
            InitializeComponent();
            this.pagination = new Pagination()
            {
                PageIndex = 1,
                PageSize = 7
            };
        }
        private void PageLastModifier()
        {
            if (dgvReservations.Rows.Count == 1 && pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
            }
        }
        private int CalculatePages()
        {
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                return (int)Math.Ceiling((double)uow.Auteur.GetAll().Count() / pagination.PageSize);
            }
        }
        public void LoadData()
        {
            var predicate = PredicateBuilder.New<Reservation>(true);
            if (!string.IsNullOrEmpty(txtAdherentCriteria.Text))
            {
                if (txtAdherentCriteria.SelectedIndex != 0)
                {
                    predicate = predicate.And(e => e.Adherent.NomAdherent == txtAdherentCriteria.Text);
                }
            }

            TotalPages = CalculatePages();
            txtCurrentPage.Text = $"{pagination.PageIndex}/{TotalPages}";
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                dgvReservations.DataSource = uow.Reservation.Find(predicate, "Adherent,Livre").Select(r => new
                {
                    IdLivre = r.IdLivre,
                    TitreLivre = r.Livre.Title,
                    IdAdherent = r.IdAdherent,
                    NomAdherent = r.Adherent.NomAdherent,
                    Date_Debut = r.DateDebut,
                    Date_fin = r.DateFin,
                    Status = r.Status == true ? "Terminée" : "En cours"
                }).ToList();
                txtNbReservs.Text = dgvReservations.RowCount.ToString();
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            LoadData();
            txtAdherentCriteria.Items.Add(new Adherent()
            {
                IdAdherent = -1,
                NomAdherent = "----Tous les Adherents----"
            });
            using (UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                foreach (Adherent adherent in uow.Adherent.GetAll())
                {
                    txtAdherentCriteria.Items.Add(adherent);
                }
                txtAdherentCriteria.ValueMember = "IdAdherent";
                txtAdherentCriteria.DisplayMember = "NomAdherent";
                txtAdherentCriteria.SelectedIndex = 0;
            }


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
            AddNewReservation addNewReservation = new AddNewReservation(this);
            addNewReservation.ShowDialog();
        }

        private void rechercherBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pagination.PageIndex < TotalPages)
            {
                pagination.PageIndex++;
                LoadData();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pagination.PageIndex > 1)
            {
                pagination.PageIndex--;
                LoadData();
            }
        }
    }
}
