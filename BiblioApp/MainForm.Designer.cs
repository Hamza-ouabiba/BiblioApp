
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
            panelContent = new Panel();
            pictureBox2 = new PictureBox();
            btnAuthors = new Button();
            btnEmploye = new Button();
            btnAdherent = new Button();
            panelLeft = new Panel();
            btnExit = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PanelTop = new Panel();
            btnBooks = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = SystemColors.Control;
            panelContent.Location = new Point(176, 56);
            panelContent.Margin = new Padding(2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(690, 520);
            panelContent.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
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
            btnAuthors.Location = new Point(0, 159);
            btnAuthors.Margin = new Padding(2);
            btnAuthors.Name = "btnAuthors";
            btnAuthors.Size = new Size(169, 51);
            btnAuthors.TabIndex = 1;
            btnAuthors.Text = "Auteurs";
            btnAuthors.UseVisualStyleBackColor = false;
            btnAuthors.Click += btnAuthors_Click;
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
            btnEmploye.Location = new Point(5, 304);
            btnEmploye.Margin = new Padding(2);
            btnEmploye.Name = "btnEmploye";
            btnEmploye.Size = new Size(169, 51);
            btnEmploye.TabIndex = 4;
            btnEmploye.Text = "Employées";
            btnEmploye.UseVisualStyleBackColor = false;
            btnEmploye.Click += btnEmploye_Click;
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
            btnAdherent.Location = new Point(4, 386);
            btnAdherent.Margin = new Padding(2);
            btnAdherent.Name = "btnAdherent";
            btnAdherent.Size = new Size(169, 51);
            btnAdherent.TabIndex = 5;
            btnAdherent.Text = "Adhérents";
            btnAdherent.UseVisualStyleBackColor = false;
            btnAdherent.Click += btnAdherent_Click;
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
            panelLeft.Size = new Size(177, 576);
            panelLeft.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(633, 10);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 37);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(76, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 42);
            label1.TabIndex = 1;
            label1.Text = "Bibliotheque ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 5);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // PanelTop
            // 
            PanelTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelTop.BackColor = SystemColors.ActiveCaption;
            PanelTop.Controls.Add(pictureBox1);
            PanelTop.Controls.Add(label1);
            PanelTop.Controls.Add(btnExit);
            PanelTop.Location = new Point(169, 0);
            PanelTop.Margin = new Padding(2);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(697, 74);
            PanelTop.TabIndex = 0;
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
            btnBooks.Location = new Point(2, 230);
            btnBooks.Margin = new Padding(2);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(166, 51);
            btnBooks.TabIndex = 2;
            btnBooks.Text = "Livres";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 576);
            Controls.Add(panelContent);
            Controls.Add(panelLeft);
            Controls.Add(PanelTop);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private PictureBox pictureBox2;
        private Button btnAuthors;
        private Button btnEmploye;
        private Button btnAdherent;
        private Panel panelLeft;
        private Button btnBooks;
        private Button btnExit;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel PanelTop;
    }
}