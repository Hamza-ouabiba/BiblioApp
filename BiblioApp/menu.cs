using BiblioApp.Models;
using System;
using System.Data;
using System.Windows.Forms;
namespace BiblioApp.Forms
{
    public partial class menu : Form
    {
        private readonly Employe emp;
        public menu()
        {
            InitializeComponent();
        }

        public menu(Employe emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnAuteur_Click(sender, e);
            date.Text = DateTime.Now.ToString();
            utilisateurEn.Text = emp.Nom;
            if (emp.IsAdmin == false)
            {
                GestionEmp.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAuteur_Click(object sender, EventArgs e)
        {
            AuthorsForm frmAuth = new AuthorsForm();
            frmAuth.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmAuth);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BooksForms frmBook = new BooksForms();
            frmBook.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmBook);
        }
        private void GestionEmp_Click(object sender, EventArgs e)
        {
            EmployeForm frmEmp = new EmployeForm(emp.IdEmploye);
            frmEmp.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmEmp);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ReservationForm frmRes = new ReservationForm();
            frmRes.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmRes);
        }

        private void btnAdherent_Click(object sender, EventArgs e)
        {
            AdherentForm frmAdherent = new AdherentForm();
            frmAdherent.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmAdherent);
        }
    }
}
