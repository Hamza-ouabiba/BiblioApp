namespace BiblioApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            checkBox1 = new CheckBox();
            Panel3 = new Panel();
            Panel2 = new Panel();
            cnxBtn = new Button();
            pass = new TextBox();
            userName = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 117, 240);
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(328, 50);
            label2.TabIndex = 29;
            label2.Text = "Bibliotheque plus";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.ForeColor = Color.Silver;
            checkBox1.Location = new Point(67, 362);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(188, 24);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Afficher le mot de passe";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(0, 117, 214);
            Panel3.Location = new Point(53, 295);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(261, 1);
            Panel3.TabIndex = 27;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(0, 117, 214);
            Panel2.ImeMode = ImeMode.On;
            Panel2.Location = new Point(53, 203);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(261, 1);
            Panel2.TabIndex = 26;
            // 
            // cnxBtn
            // 
            cnxBtn.BackColor = Color.CornflowerBlue;
            cnxBtn.FlatStyle = FlatStyle.Flat;
            cnxBtn.ForeColor = Color.Black;
            cnxBtn.Location = new Point(49, 450);
            cnxBtn.Name = "cnxBtn";
            cnxBtn.Size = new Size(265, 47);
            cnxBtn.TabIndex = 25;
            cnxBtn.Text = "Connexion";
            cnxBtn.UseVisualStyleBackColor = false;
            cnxBtn.Click += cnxBtn_Click;
            // 
            // pass
            // 
            pass.BackColor = Color.FromArgb(32, 29, 30);
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            pass.ForeColor = SystemColors.Control;
            pass.Location = new Point(79, 267);
            pass.Name = "pass";
            pass.PlaceholderText = "Mot de Passe";
            pass.Size = new Size(207, 20);
            pass.TabIndex = 23;
            pass.UseSystemPasswordChar = true;
            // 
            // userName
            // 
            userName.BackColor = Color.FromArgb(32, 29, 30);
            userName.BorderStyle = BorderStyle.None;
            userName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            userName.ForeColor = SystemColors.Control;
            userName.Location = new Point(79, 172);
            userName.Name = "userName";
            userName.PlaceholderText = "Nom Utilisateur";
            userName.Size = new Size(207, 20);
            userName.TabIndex = 22;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(32, 29, 30);
            iconPictureBox1.ForeColor = Color.FromArgb(0, 117, 240);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = Color.FromArgb(0, 117, 240);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 23;
            iconPictureBox1.Location = new Point(49, 172);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(23, 25);
            iconPictureBox1.TabIndex = 30;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(32, 29, 30);
            iconPictureBox2.ForeColor = Color.FromArgb(0, 117, 240);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.FromArgb(0, 117, 240);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 21;
            iconPictureBox2.Location = new Point(49, 267);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(23, 21);
            iconPictureBox2.TabIndex = 31;
            iconPictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 29, 30);
            ClientSize = new Size(373, 564);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(Panel3);
            Controls.Add(Panel2);
            Controls.Add(cnxBtn);
            Controls.Add(pass);
            Controls.Add(userName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private CheckBox checkBox1;
        internal Panel Panel3;
        internal Panel Panel2;
        private Button cnxBtn;
        private TextBox pass;
        private TextBox userName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}