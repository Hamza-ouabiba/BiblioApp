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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioApp
{
    public partial class AjouEmploye : Form
    {
        private readonly EmployeForm emp;
        private readonly int idEmploye;
        public AjouEmploye()
        {
            InitializeComponent();
        }
        public AjouEmploye(EmployeForm employeForm , [Optional] int idEmploye)
        {
            InitializeComponent();
            this.emp = employeForm;
            this.idEmploye = idEmploye;
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
                        if(idEmploye == -1)
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
                            
                        } else
                        {
                            Employe employe = uow.Employe.Get(idEmploye);
                            employe.Email = txtEmail.Text;  
                            employe.Password = txtPassword.Text;
                            employe.Genre = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text;
                            employe.IsAdmin = GetValueCombo(key: comboTypeCom.SelectedItem.ToString());

                        }

                        if (uow.Complete() > 0)
                        {
                            string state = idEmploye == -1 ? "created" : "updated";
                            MessageBox.Show($"Adherent {state} successfully  ");
                            emp.LoadData();
                            this.Close();
                        }
                    } catch(Exception inner)
                    {
                        MessageBox.Show(inner.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Remplir les fields");
        }

        private void AjouEmploye_Load(object sender, EventArgs e)
        {
            comboTypeCom.Items.Add("Administrateur");
            comboTypeCom.Items.Add("utilisateur simple");

            if (idEmploye != -1)
            {
                txtTitleForm.Text = "Update Employe";
                btnSaveEmploye.Text = "Modifier";
                try
                {
                    if (idEmploye != -1)
                    {
                        using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
                        {
                            Employe employe = uow.Employe.Get(idEmploye);
                            txtEmail.Text = employe.Email;
                            txtName.Text = employe.Nom;
                            txtPassword.Text = employe.Password;
                            if (employe.Genre == "M")
                                txtGenderM.Checked = true;
                            else if (employe.Genre == "F")
                                txtGenderF.Checked = true;

                            comboTypeCom.SelectedIndex = employe.IsAdmin == true ? 0 : 1 ;
                            txtTitleForm.Text = "Update Adherent";
                        }
                    } else
                    {
                        comboTypeCom.SelectedIndex = 0;
                    }
                }
                catch (Exception excpetion)
                {
                    MessageBox.Show(excpetion.Message);
                }
            }
            
        }
        
    }
}
