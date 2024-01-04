using BiblioApp.Forms;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using Microsoft.Data.SqlClient;
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
    public partial class AjouEmploye : Form
    {
        private readonly EmployeForm emp;
        public AjouEmploye()
        {
            InitializeComponent();
        }
        public AjouEmploye(EmployeForm employeForm)
        {
            InitializeComponent();
            this.emp = employeForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool GetValueCombo(string key)
        {
            Dictionary<string, bool> userTypeMap = new Dictionary<string, bool>
            {
                { "Administrateur", true },
                { "utilisateur simple", false }
            };
            return userTypeMap[key];
        }
        private void btnSaveEmploye_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && (txtGenderF.Checked || txtGenderM.Checked) && comboTypeCom.SelectedIndex != -1)
            {
                using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                {
                    try
                    {
                        Employe employe = new Employe()
                        {
                            Nom = txtName.Text,
                            Email = txtEmail.Text,
                            Genre = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text,
                            Password = txtPassword.Text,
                            IsAdmin = GetValueCombo(key: comboTypeCom.SelectedItem.ToString())
                        };
                        uow.Employe.Add(employe);
                        int res = uow.Complete();
                        if (res > 0)
                        {
                            MessageBox.Show("Employee created successfully ID : " + employe.IdEmploye, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            emp.LoadData();
                            txtName.Text = "";
                            txtEmail.Text = "";
                            txtName.Focus();
                            txtGenderM.Select();
                        }
                    } catch(Exception inner)
                    {
                        MessageBox.Show($"inner Error: {inner.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Remplir les fields");
        }

        private void AjouEmploye_Load(object sender, EventArgs e)
        {
            comboTypeCom.Items.Add("Administrateur");
            comboTypeCom.Items.Add("utilisateur simple");
            comboTypeCom.SelectedIndex = 0;
        }
        
    }
}
