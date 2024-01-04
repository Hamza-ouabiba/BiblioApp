
namespace BiblioApp
{
    partial class AjouEmploye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouEmploye));
            panel1 = new Panel();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            txtTitleForm = new Label();
            ErrProvider = new ErrorProvider(components);
            txtPassword = new TextBox();
            label7 = new Label();
            txtGenderF = new RadioButton();
            txtGenderM = new RadioButton();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboTypeCom = new ComboBox();
            btnSaveEmploye = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrProvider).BeginInit();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(378, 42);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(328, 5);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(37, 33);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 6);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 26);
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
            txtTitleForm.Location = new Point(51, 7);
            txtTitleForm.Margin = new Padding(2, 0, 2, 0);
            txtTitleForm.Name = "txtTitleForm";
            txtTitleForm.Size = new Size(152, 23);
            txtTitleForm.TabIndex = 2;
            txtTitleForm.Text = "Ajout Employé";
            // 
            // ErrProvider
            // 
            ErrProvider.ContainerControl = this;
            ErrProvider.Icon = (Icon)resources.GetObject("ErrProvider.Icon");
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(22, 219);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 34);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(17, 177);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 12;
            label7.Text = "Password :";
            // 
            // txtGenderF
            // 
            txtGenderF.AutoSize = true;
            txtGenderF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGenderF.Location = new Point(170, 353);
            txtGenderF.Margin = new Padding(2);
            txtGenderF.Name = "txtGenderF";
            txtGenderF.Size = new Size(38, 24);
            txtGenderF.TabIndex = 6;
            txtGenderF.TabStop = true;
            txtGenderF.Text = "F";
            txtGenderF.UseVisualStyleBackColor = true;
            // 
            // txtGenderM
            // 
            txtGenderM.AutoSize = true;
            txtGenderM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGenderM.Location = new Point(110, 353);
            txtGenderM.Margin = new Padding(2);
            txtGenderM.Name = "txtGenderM";
            txtGenderM.Size = new Size(44, 24);
            txtGenderM.TabIndex = 5;
            txtGenderM.TabStop = true;
            txtGenderM.Text = "M";
            txtGenderM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(18, 351);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 4;
            label4.Text = "Gender : ";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(18, 139);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 34);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(17, 107);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "Email : ";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(18, 67);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 34);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(17, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 0;
            label2.Text = "Name : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboTypeCom);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnSaveEmploye);
            groupBox1.Controls.Add(txtGenderF);
            groupBox1.Controls.Add(txtGenderM);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 59);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(350, 482);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(22, 265);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 15;
            label1.Text = "Type de compte";
            // 
            // comboTypeCom
            // 
            comboTypeCom.FormattingEnabled = true;
            comboTypeCom.Location = new Point(26, 306);
            comboTypeCom.Name = "comboTypeCom";
            comboTypeCom.Size = new Size(282, 28);
            comboTypeCom.TabIndex = 14;
            // 
            // btnSaveEmploye
            // 
            btnSaveEmploye.BackColor = Color.LightGray;
            btnSaveEmploye.Cursor = Cursors.Hand;
            btnSaveEmploye.FlatAppearance.BorderSize = 0;
            btnSaveEmploye.FlatStyle = FlatStyle.Flat;
            btnSaveEmploye.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveEmploye.Image = (Image)resources.GetObject("btnSaveEmploye.Image");
            btnSaveEmploye.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveEmploye.Location = new Point(170, 430);
            btnSaveEmploye.Margin = new Padding(2);
            btnSaveEmploye.Name = "btnSaveEmploye";
            btnSaveEmploye.Size = new Size(161, 32);
            btnSaveEmploye.TabIndex = 7;
            btnSaveEmploye.Text = "Enregistrer";
            btnSaveEmploye.UseVisualStyleBackColor = false;
            btnSaveEmploye.Click += btnSaveEmploye_Click;
            // 
            // AjouEmploye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(378, 552);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AjouEmploye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookNewEditForm";
            Load += AjouEmploye_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrProvider).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label txtTitleForm;
        private Button btnExit;
        private ErrorProvider ErrProvider;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private Label label7;
        private Button btnSaveEmploye;
        private RadioButton txtGenderF;
        private RadioButton txtGenderM;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private ComboBox comboTypeCom;
    }
}