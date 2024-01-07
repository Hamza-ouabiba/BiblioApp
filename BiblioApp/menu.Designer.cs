namespace BiblioApp.Forms
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLeft = new Panel();
            btnAdherent = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            utilisateurEn = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            btnBook = new FontAwesome.Sharp.IconButton();
            GestionEmp = new FontAwesome.Sharp.IconButton();
            btnReservation = new FontAwesome.Sharp.IconButton();
            btnAuteur = new FontAwesome.Sharp.IconButton();
            date = new Label();
            panelTop = new Panel();
            btnExit = new Button();
            DeconBtn = new FontAwesome.Sharp.IconButton();
            panelContent = new Panel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(32, 29, 30);
            panelLeft.Controls.Add(btnAdherent);
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(utilisateurEn);
            panelLeft.Controls.Add(iconPictureBox1);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(btnBook);
            panelLeft.Controls.Add(GestionEmp);
            panelLeft.Controls.Add(btnReservation);
            panelLeft.Controls.Add(btnAuteur);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panelLeft.ForeColor = Color.Gray;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(221, 882);
            panelLeft.TabIndex = 1;
            // 
            // btnAdherent
            // 
            btnAdherent.Cursor = Cursors.Hand;
            btnAdherent.FlatStyle = FlatStyle.Flat;
            btnAdherent.ForeColor = Color.Silver;
            btnAdherent.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnAdherent.IconColor = Color.Silver;
            btnAdherent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdherent.IconSize = 30;
            btnAdherent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdherent.Location = new Point(-4, 561);
            btnAdherent.Margin = new Padding(6, 3, 3, 3);
            btnAdherent.Name = "btnAdherent";
            btnAdherent.Padding = new Padding(9, 5, 5, 5);
            btnAdherent.Size = new Size(230, 95);
            btnAdherent.TabIndex = 12;
            btnAdherent.Text = "Adhérents";
            btnAdherent.UseVisualStyleBackColor = true;
            btnAdherent.Click += btnAdherent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 407);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 11;
            label1.UseWaitCursor = true;
            // 
            // utilisateurEn
            // 
            utilisateurEn.AutoSize = true;
            utilisateurEn.Location = new Point(73, 916);
            utilisateurEn.Name = "utilisateurEn";
            utilisateurEn.Size = new Size(0, 23);
            utilisateurEn.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(32, 29, 30);
            iconPictureBox1.ForeColor = Color.Lime;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.Lime;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(38, 916);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(29, 25);
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 69);
            label2.Name = "label2";
            label2.Size = new Size(155, 38);
            label2.TabIndex = 0;
            label2.Text = "Biblio Plus";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBook
            // 
            btnBook.Cursor = Cursors.Hand;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.ForeColor = Color.Silver;
            btnBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnBook.IconColor = Color.Silver;
            btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBook.IconSize = 30;
            btnBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnBook.Location = new Point(-4, 471);
            btnBook.Margin = new Padding(6, 3, 3, 3);
            btnBook.Name = "btnBook";
            btnBook.Padding = new Padding(9, 5, 5, 5);
            btnBook.Size = new Size(230, 95);
            btnBook.TabIndex = 6;
            btnBook.Text = "Livres";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // GestionEmp
            // 
            GestionEmp.Cursor = Cursors.Hand;
            GestionEmp.FlatStyle = FlatStyle.Flat;
            GestionEmp.ForeColor = Color.Silver;
            GestionEmp.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            GestionEmp.IconColor = Color.Silver;
            GestionEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            GestionEmp.IconSize = 30;
            GestionEmp.ImageAlign = ContentAlignment.MiddleLeft;
            GestionEmp.Location = new Point(-3, 381);
            GestionEmp.Margin = new Padding(6, 3, 3, 3);
            GestionEmp.Name = "GestionEmp";
            GestionEmp.Padding = new Padding(6, 0, 0, 0);
            GestionEmp.Size = new Size(235, 95);
            GestionEmp.TabIndex = 5;
            GestionEmp.Text = "Employe";
            GestionEmp.UseVisualStyleBackColor = true;
            GestionEmp.Click += GestionEmp_Click;
            // 
            // btnReservation
            // 
            btnReservation.Cursor = Cursors.Hand;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.ForeColor = Color.Silver;
            btnReservation.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnReservation.IconColor = Color.Silver;
            btnReservation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReservation.IconSize = 30;
            btnReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservation.Location = new Point(-5, 290);
            btnReservation.Name = "btnReservation";
            btnReservation.Padding = new Padding(7, 0, 0, 0);
            btnReservation.Size = new Size(229, 95);
            btnReservation.TabIndex = 4;
            btnReservation.Text = "Reservations";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnAuteur
            // 
            btnAuteur.Cursor = Cursors.Hand;
            btnAuteur.FlatStyle = FlatStyle.Flat;
            btnAuteur.ForeColor = Color.Silver;
            btnAuteur.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            btnAuteur.IconColor = Color.Silver;
            btnAuteur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAuteur.IconSize = 30;
            btnAuteur.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuteur.Location = new Point(-5, 196);
            btnAuteur.Name = "btnAuteur";
            btnAuteur.Padding = new Padding(7, 0, 0, 0);
            btnAuteur.Size = new Size(230, 95);
            btnAuteur.TabIndex = 3;
            btnAuteur.Text = "Auteurs";
            btnAuteur.UseVisualStyleBackColor = true;
            btnAuteur.Click += btnAuteur_Click;
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.FromArgb(32, 29, 30);
            date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.ForeColor = Color.Silver;
            date.Location = new Point(18, 11);
            date.Name = "date";
            date.Size = new Size(65, 28);
            date.TabIndex = 13;
            date.Text = "label3";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(32, 29, 30);
            panelTop.Controls.Add(btnExit);
            panelTop.Controls.Add(date);
            panelTop.Controls.Add(DeconBtn);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(221, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1252, 53);
            panelTop.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(1193, 7);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 37);
            btnExit.TabIndex = 14;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // DeconBtn
            // 
            DeconBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeconBtn.BackColor = Color.FromArgb(32, 29, 30);
            DeconBtn.FlatStyle = FlatStyle.Flat;
            DeconBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeconBtn.ForeColor = Color.Silver;
            DeconBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            DeconBtn.IconColor = SystemColors.Control;
            DeconBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            DeconBtn.IconSize = 25;
            DeconBtn.ImageAlign = ContentAlignment.MiddleRight;
            DeconBtn.Location = new Point(1003, 7);
            DeconBtn.Name = "DeconBtn";
            DeconBtn.Padding = new Padding(3, 0, 0, 0);
            DeconBtn.Size = new Size(165, 36);
            DeconBtn.TabIndex = 4;
            DeconBtn.Text = "Se Deconnecter";
            DeconBtn.TextAlign = ContentAlignment.MiddleLeft;
            DeconBtn.UseVisualStyleBackColor = false;
            DeconBtn.Click += DeconBtn_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.ForeColor = Color.Black;
            panelContent.Location = new Point(221, 53);
            panelContent.Margin = new Padding(7, 0, 0, 0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(7, 0, 0, 0);
            panelContent.Size = new Size(1252, 829);
            panelContent.TabIndex = 3;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 882);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu";
            Load += menu_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label utilisateurEn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBook;
        private FontAwesome.Sharp.IconButton GestionEmp;
        private FontAwesome.Sharp.IconButton btnReservation;
        private FontAwesome.Sharp.IconButton btnAuteur;
        private Panel panelTop;
        private FontAwesome.Sharp.IconButton DeconBtn;
        private Label label1;
        private Panel panelContent;
        private Label date;
        private Button btnExit;
        private FontAwesome.Sharp.IconButton btnAdherent;
    }
}