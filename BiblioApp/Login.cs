using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace BiblioApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Quitter l'application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else pass.UseSystemPasswordChar = true;
        }

        private void cnxBtn_Click(object sender, EventArgs e)
        {
            using(UnitOfWork uow = new(new BibliothequeDbContext()))
            {
                if(userName.Text != "" && pass.Text != "")
                {
                    Expression<Func<Employe, bool>> search = a => a.Nom == userName.Text && a.Password == pass.Text;
                    Employe employe = (Employe)uow.Employe.Find(search, null, null);
                    MessageBox.Show(employe.Nom);
                }
            }
        }
    }
}