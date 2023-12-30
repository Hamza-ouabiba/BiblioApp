
namespace BiblioApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PanelTop = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnExit = new Button();
            panelLeft = new Panel();
            btnAdherent = new Button();
            btnEmploye = new Button();
            btnBooks = new Button();
            btnAuthors = new Button();
            pictureBox2 = new PictureBox();
            panelContent = new Panel();
            PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelTop.BackColor = SystemColors.ActiveCaption;
            PanelTop.Controls.Add(pictureBox1);
            PanelTop.Controls.Add(label1);
            PanelTop.Controls.Add(btnExit);
            PanelTop.Location = new Point(211, 0);
            PanelTop.Margin = new Padding(2);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(871, 92);
            PanelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 6);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(95, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 52);
            label1.TabIndex = 1;
            label1.Text = "Bibliotheque ";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(791, 12);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 46);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Gainsboro;
            panelLeft.Controls.Add(btnAdherent);
            panelLeft.Controls.Add(btnEmploye);
            panelLeft.Controls.Add(btnBooks);
            panelLeft.Controls.Add(btnAuthors);
            panelLeft.Controls.Add(pictureBox2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(221, 720);
            panelLeft.TabIndex = 1;
            // 
            // btnAdherent
            // 
            btnAdherent.BackColor = Color.LightGray;
            btnAdherent.Cursor = Cursors.Hand;
            btnAdherent.FlatAppearance.BorderSize = 0;
            btnAdherent.FlatStyle = FlatStyle.Flat;
            btnAdherent.Font = new Font("Agency FB", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdherent.Image = (Image)resources.GetObject("btnAdherent.Image");
            btnAdherent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdherent.Location = new Point(5, 483);
            btnAdherent.Margin = new Padding(2);
            btnAdherent.Name = "btnAdherent";
            btnAdherent.Size = new Size(211, 64);
            btnAdherent.TabIndex = 5;
            btnAdherent.Text = "Adhérents";
            btnAdherent.UseVisualStyleBackColor = false;
            btnAdherent.Click += btnAdherent_Click;
            // 
            // btnEmploye
            // 
            btnEmploye.BackColor = Color.LightGray;
            btnEmploye.Cursor = Cursors.Hand;
            btnEmploye.FlatAppearance.BorderSize = 0;
            btnEmploye.FlatStyle = FlatStyle.Flat;
            btnEmploye.Font = new Font("Agency FB", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmploye.Image = (Image)resources.GetObject("btnEmploye.Image");
            btnEmploye.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmploye.Location = new Point(6, 380);
            btnEmploye.Margin = new Padding(2);
            btnEmploye.Name = "btnEmploye";
            btnEmploye.Size = new Size(211, 64);
            btnEmploye.TabIndex = 4;
            btnEmploye.Text = "Employées";
            btnEmploye.UseVisualStyleBackColor = false;
            btnEmploye.Click += btnEmploye_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.LightGray;
            btnBooks.Cursor = Cursors.Hand;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Agency FB", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBooks.Image = (Image)resources.GetObject("btnBooks.Image");
            btnBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooks.Location = new Point(2, 288);
            btnBooks.Margin = new Padding(2);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(208, 64);
            btnBooks.TabIndex = 2;
            btnBooks.Text = "Livres";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnAuthors
            // 
            btnAuthors.BackColor = Color.LightGray;
            btnAuthors.Cursor = Cursors.Hand;
            btnAuthors.FlatAppearance.BorderSize = 0;
            btnAuthors.FlatStyle = FlatStyle.Flat;
            btnAuthors.Font = new Font("Agency FB", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuthors.Image = (Image)resources.GetObject("btnAuthors.Image");
            btnAuthors.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuthors.Location = new Point(0, 199);
            btnAuthors.Margin = new Padding(2);
            btnAuthors.Name = "btnAuthors";
            btnAuthors.Size = new Size(211, 64);
            btnAuthors.TabIndex = 1;
            btnAuthors.Text = "Auteurs";
            btnAuthors.UseVisualStyleBackColor = false;
            btnAuthors.Click += btnAuthors_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = SystemColors.Control;
            panelContent.Location = new Point(220, 70);
            panelContent.Margin = new Padding(2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(862, 650);
            panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 720);
            Controls.Add(panelContent);
            Controls.Add(panelLeft);
            Controls.Add(PanelTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTop;
        private Button btnExit;
        private Panel panelLeft;
        private Panel panelContent;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnBooks;
        private Button btnAuthors;
        private Button btnEmploye;
        private Button btnAdherent;
    }
}