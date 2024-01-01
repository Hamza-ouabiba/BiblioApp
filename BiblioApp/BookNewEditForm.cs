﻿using BiblioApp.Forms;
using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
namespace BiblioApp
{
    public partial class BookNewEditForm : Form
    {
        private readonly BooksForms booksForms;
        private readonly int idLivre;
        bool vtitle, vnPage, vdesc, vPrice = false;
        public BookNewEditForm()
        {
            InitializeComponent();
        }
        public BookNewEditForm(BooksForms booksForms, [Optional] int idLivre)
        {
            InitializeComponent();
            this.booksForms = booksForms;
            this.idLivre = idLivre;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookNewEditForm_Load(object sender, EventArgs e)
        {
            txtImageCoverPath.Text = "";
            using (UnitOfWork uow = new UnitOfWork(new BibliothequeDbContext()))
            {
                comboAuteur.DataSource = uow.Auteur.GetAll();
                comboAuteur.ValueMember = "IdAuteur";
                comboAuteur.DisplayMember = "NomAuteur";

                comboCategory.DataSource = uow.Category.GetAll();
                comboCategory.ValueMember = "IdCategorie";
                comboCategory.DisplayMember = "NomCategorie";

                comboEtat.DataSource = uow.Etat.GetCreationEtat();
                comboEtat.ValueMember = "IdEtat";
                comboEtat.DisplayMember = "Nom";

                if (idLivre != -1)
                {
                    btnSaveBook.Text = "Modifier livre";
                    txtTitleForm.Text = "Modifier livre";
                    Livre livre = uow.Livre.Get(idLivre);
                    txtTitle.Text = livre.Title;
                    txtDescrip.Text = livre.Description;
                    comboCategory.SelectedItem = livre.Categorie;
                    comboAuteur.SelectedItem = livre.Auteur;
                    txtPublishedDate.Value = livre.DatePublication;
                    txtNbPages.Text = livre.NbPages.ToString();
                    txtPrice.Text = livre.Prix.ToString();
                    if (livre.Couverture != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(livre.Couverture);
                        txtImageCover.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }

        private void btnUploadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images |*.jpg; *.jpeg; *.png; *.bmp";
            ofd.Title = "Selectionner une image de couverture";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImageCover.Image = new Bitmap(ofd.FileName);
                txtImageCoverPath.Text = ofd.FileName;
            }
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            txtTitle_Validating(sender, e as CancelEventArgs);
            txtDescrip_Validating(sender, e as CancelEventArgs);
            txtNbPages_Validating(sender, e as CancelEventArgs);
            txtPrice_Validating(sender, e as CancelEventArgs);
            if (vtitle && vPrice && vdesc && vnPage)
            {
                btnSaveBook.Enabled = true;
                using (UnitOfWork uow = new(new BibliothequeDbContext()))
                {
                    if (idLivre == -1)
                    {
                        Livre livre = new Livre()
                        {
                            Title = txtTitle.Text,
                            IdAuteur = Convert.ToInt32(comboAuteur.SelectedValue),
                            IdCategorie = Convert.ToInt32(comboCategory.SelectedValue),
                            Description = txtDescrip.Text,
                            DatePublication = txtPublishedDate.Value.Date,
                            Prix = (float)Convert.ToDouble(txtPrice.Text),
                            IdEtat = Convert.ToInt32(comboEtat.SelectedValue),
                            NbPages = Convert.ToInt32(txtNbPages.Text), 
                            Couverture = (String.IsNullOrEmpty(txtImageCoverPath.Text) ? null : SharedData.ConvertToBinaryFromFile(txtImageCoverPath.Text)),
                        };
                        uow.Livre.Add(livre);
                    }
                    else
                    {
                        Livre livre = uow.Livre.Get(idLivre);
                        livre.Title = txtTitle.Text;
                        livre.IdAuteur = Convert.ToInt32(comboAuteur.SelectedValue);
                        livre.IdCategorie = Convert.ToInt32(comboCategory.SelectedValue);
                        livre.IdEtat = Convert.ToInt32(comboEtat.SelectedValue);
                        livre.Description = txtDescrip.Text;
                        livre.DatePublication = txtPublishedDate.Value.Date;
                        livre.Prix = (float)Convert.ToDouble(txtPrice.Text);
                        livre.NbPages = Convert.ToInt32(txtNbPages.Text);
                        livre.Couverture = (String.IsNullOrEmpty(txtImageCoverPath.Text) ? livre.Couverture : SharedData.ConvertToBinaryFromFile(txtImageCoverPath.Text));
                    }

                    if (uow.Complete() > 0)
                    {
                        this.booksForms.LoadData();
                        this.Close();
                    }
                    
                }
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            vtitle = SharedData.ValidateData(ErrProvider, txtTitle, "Valeur non correcte", btnSaveBook, false);
        }

        private void txtDescrip_Validating(object sender, CancelEventArgs e)
        {
            vdesc = SharedData.ValidateData(ErrProvider, txtDescrip, "Valeur non correcte", btnSaveBook, false);
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            vPrice = SharedData.ValidateData(ErrProvider, txtPrice, "Valeur non correcte ", btnSaveBook, true);
        }

        private void txtNbPages_Validating(object sender, CancelEventArgs e)
        {
            vnPage = SharedData.ValidateData(ErrProvider, txtNbPages, "Valeur non correcte", btnSaveBook, true);
        }
    }
}
