
namespace BiblioApp
{
    partial class AddNewReservation
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewReservation));
            panel1 = new Panel();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            txtTitleForm = new Label();
            groupBox1 = new GroupBox();
            btnTerminer = new Button();
            txtDateFin = new DateTimePicker();
            label1 = new Label();
            comboAdherent = new ComboBox();
            btnSaveReserv = new Button();
            label3 = new Label();
            comboLivre = new ComboBox();
            txtDateDebut = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            ErrProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtTitleForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 52);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(461, 6);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 41);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtTitleForm
            // 
            txtTitleForm.AutoSize = true;
            txtTitleForm.BackColor = Color.Maroon;
            txtTitleForm.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitleForm.ForeColor = SystemColors.ButtonHighlight;
            txtTitleForm.Location = new Point(64, 9);
            txtTitleForm.Margin = new Padding(2, 0, 2, 0);
            txtTitleForm.Name = "txtTitleForm";
            txtTitleForm.Size = new Size(213, 28);
            txtTitleForm.TabIndex = 2;
            txtTitleForm.Text = "Ajout Reservation";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTerminer);
            groupBox1.Controls.Add(txtDateFin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboAdherent);
            groupBox1.Controls.Add(btnSaveReserv);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboLivre);
            groupBox1.Controls.Add(txtDateDebut);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(498, 536);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnTerminer
            // 
            btnTerminer.BackColor = Color.LightGray;
            btnTerminer.Cursor = Cursors.Hand;
            btnTerminer.FlatAppearance.BorderSize = 0;
            btnTerminer.FlatStyle = FlatStyle.Flat;
            btnTerminer.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTerminer.Image = (Image)resources.GetObject("btnTerminer.Image");
            btnTerminer.ImageAlign = ContentAlignment.MiddleLeft;
            btnTerminer.Location = new Point(42, 479);
            btnTerminer.Margin = new Padding(2);
            btnTerminer.Name = "btnTerminer";
            btnTerminer.Size = new Size(132, 39);
            btnTerminer.TabIndex = 23;
            btnTerminer.Text = "Terminer";
            btnTerminer.TextAlign = ContentAlignment.MiddleRight;
            btnTerminer.UseVisualStyleBackColor = false;
            btnTerminer.Visible = false;
            btnTerminer.Click += btnTerminer_Click;
            // 
            // txtDateFin
            // 
            txtDateFin.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateFin.CalendarMonthBackground = Color.LightBlue;
            txtDateFin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateFin.Format = DateTimePickerFormat.Short;
            txtDateFin.Location = new Point(291, 326);
            txtDateFin.Margin = new Padding(2);
            txtDateFin.Name = "txtDateFin";
            txtDateFin.Size = new Size(152, 37);
            txtDateFin.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(281, 280);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 21;
            label1.Text = "Date Fin :";
            // 
            // comboAdherent
            // 
            comboAdherent.BackColor = Color.White;
            comboAdherent.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboAdherent.FormattingEnabled = true;
            comboAdherent.Location = new Point(22, 202);
            comboAdherent.Margin = new Padding(2);
            comboAdherent.Name = "comboAdherent";
            comboAdherent.Size = new Size(420, 38);
            comboAdherent.TabIndex = 20;
            // 
            // btnSaveReserv
            // 
            btnSaveReserv.BackColor = Color.LightGray;
            btnSaveReserv.Cursor = Cursors.Hand;
            btnSaveReserv.FlatAppearance.BorderSize = 0;
            btnSaveReserv.FlatStyle = FlatStyle.Flat;
            btnSaveReserv.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveReserv.Image = (Image)resources.GetObject("btnSaveReserv.Image");
            btnSaveReserv.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveReserv.Location = new Point(245, 479);
            btnSaveReserv.Margin = new Padding(2);
            btnSaveReserv.Name = "btnSaveReserv";
            btnSaveReserv.Size = new Size(240, 39);
            btnSaveReserv.TabIndex = 7;
            btnSaveReserv.Text = "Create New Reservation";
            btnSaveReserv.TextAlign = ContentAlignment.MiddleRight;
            btnSaveReserv.UseVisualStyleBackColor = false;
            btnSaveReserv.Click += btnSaveReserv_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(22, 150);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 19;
            label3.Text = "Adherent ";
            // 
            // comboLivre
            // 
            comboLivre.BackColor = Color.White;
            comboLivre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboLivre.FormattingEnabled = true;
            comboLivre.Location = new Point(22, 85);
            comboLivre.Margin = new Padding(2);
            comboLivre.Name = "comboLivre";
            comboLivre.Size = new Size(420, 38);
            comboLivre.TabIndex = 13;
            // 
            // txtDateDebut
            // 
            txtDateDebut.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDebut.CalendarMonthBackground = Color.LightBlue;
            txtDateDebut.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDebut.Format = DateTimePickerFormat.Short;
            txtDateDebut.Location = new Point(32, 326);
            txtDateDebut.Margin = new Padding(2);
            txtDateDebut.Name = "txtDateDebut";
            txtDateDebut.Size = new Size(152, 37);
            txtDateDebut.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(22, 280);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 30);
            label4.TabIndex = 4;
            label4.Text = "Date début :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(22, 38);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 30);
            label2.TabIndex = 0;
            label2.Text = "Livre a reserver";
            // 
            // ErrProvider
            // 
            ErrProvider.ContainerControl = this;
            ErrProvider.Icon = (Icon)resources.GetObject("ErrProvider.Icon");
            // 
            // AddNewReservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(524, 624);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AddNewReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookNewEditForm";
            Load += AddNewReservation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label txtTitleForm;
        private Button btnExit;
        private GroupBox groupBox1;
        private DateTimePicker txtDateDebut;
        private Button btnSaveReserv;
        private Label label4;
        private Label label2;
        private ComboBox comboLivre;
        private ErrorProvider ErrProvider;
        private ComboBox comboAdherent;
        private Label label3;
        private DateTimePicker txtDateFin;
        private Label label1;
        private Button btnTerminer;
    }
}