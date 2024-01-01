using BiblioApp.Forms;

namespace BiblioApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnAuthors_Click(sender, e);
        }
        private void btnAuthors_Click(object sender, EventArgs e)
        {
            AuthorsForm frmAuth = new AuthorsForm();
            frmAuth.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmAuth);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksForms frmBook = new BooksForms();
            frmBook.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmBook);
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
        }
        private void btnEmploye_Click(object sender, EventArgs e)
        {
            EmployeForm frmEmp = new EmployeForm();
            frmEmp.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmEmp);
        }
        private void btnAdherent_Click(object sender, EventArgs e)
        {
            AdherentForm adherentForm = new AdherentForm();
            adherentForm.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(adherentForm);
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(reservationForm);
        }
    }
}
