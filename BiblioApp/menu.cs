using System;
using System.Data;
using System.Windows.Forms;
namespace BiblioApp.Forms
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            EmployeForm frmEmp = new EmployeForm();
            frmEmp.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmEmp);
        }
    }
}
