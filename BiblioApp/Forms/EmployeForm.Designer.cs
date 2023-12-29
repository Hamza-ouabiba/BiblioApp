namespace BiblioApp.Forms
{
    partial class EmployeForm
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnUpdateEmploye = new Button();
            btnSaveEmploye = new Button();
            txtGenderF = new RadioButton();
            txtGenderM = new RadioButton();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvEmployes = new DataGridView();
            txtNbEmploye = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdateEmploye);
            groupBox1.Controls.Add(btnSaveEmploye);
            groupBox1.Controls.Add(txtGenderF);
            groupBox1.Controls.Add(txtGenderM);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(75, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 418);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnUpdateEmploye
            // 
            btnUpdateEmploye.BackColor = Color.LightCyan;
            btnUpdateEmploye.Cursor = Cursors.Hand;
            btnUpdateEmploye.FlatAppearance.BorderSize = 0;
            btnUpdateEmploye.FlatStyle = FlatStyle.Flat;
            btnUpdateEmploye.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEmploye.Image = (Image)resources.GetObject("btnUpdateEmploye.Image");
            btnUpdateEmploye.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateEmploye.Location = new Point(130, 360);
            btnUpdateEmploye.Name = "btnUpdateEmploye";
            btnUpdateEmploye.Size = new Size(128, 40);
            btnUpdateEmploye.TabIndex = 8;
            btnUpdateEmploye.Text = "Update";
            btnUpdateEmploye.UseVisualStyleBackColor = false;
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
            btnSaveEmploye.Location = new Point(270, 360);
            btnSaveEmploye.Name = "btnSaveEmploye";
            btnSaveEmploye.Size = new Size(128, 40);
            btnSaveEmploye.TabIndex = 7;
            btnSaveEmploye.Text = "Save";
            btnSaveEmploye.UseVisualStyleBackColor = false;
            btnSaveEmploye.Click += btnSaveEmploye_Click;
            // 
            // txtGenderF
            // 
            txtGenderF.AutoSize = true;
            txtGenderF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGenderF.Location = new Point(212, 278);
            txtGenderF.Name = "txtGenderF";
            txtGenderF.Size = new Size(46, 29);
            txtGenderF.TabIndex = 6;
            txtGenderF.TabStop = true;
            txtGenderF.Text = "F";
            txtGenderF.UseVisualStyleBackColor = true;
            // 
            // txtGenderM
            // 
            txtGenderM.AutoSize = true;
            txtGenderM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGenderM.Location = new Point(136, 277);
            txtGenderM.Name = "txtGenderM";
            txtGenderM.Size = new Size(54, 29);
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
            label4.Location = new Point(28, 275);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 4;
            label4.Text = "Gender : ";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightBlue;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(22, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 39);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(22, 146);
            label3.Name = "label3";
            label3.Size = new Size(81, 30);
            label3.TabIndex = 2;
            label3.Text = "Email : ";
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightBlue;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(22, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(357, 39);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(22, 38);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 0;
            label2.Text = "Name : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 29);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 4;
            label1.Text = "Ajouter Employe";
            // 
            // dgvEmployes
            // 
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 192);
            dgvEmployes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployes.BackgroundColor = SystemColors.ButtonFace;
            dgvEmployes.BorderStyle = BorderStyle.None;
            dgvEmployes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmployes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployes.ColumnHeadersHeight = 33;
            dgvEmployes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployes.EnableHeadersVisualStyles = false;
            dgvEmployes.Location = new Point(600, 86);
            dgvEmployes.Name = "dgvEmployes";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Maroon;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEmployes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployes.RowHeadersWidth = 62;
            dgvEmployes.RowTemplate.Height = 40;
            dgvEmployes.Size = new Size(838, 400);
            dgvEmployes.TabIndex = 6;
            dgvEmployes.CellContentClick += dgvEmployes_CellContentClick;
            dgvEmployes.CellMouseEnter += dgvEmployes_CellMouseEnter;
            // 
            // txtNbEmploye
            // 
            txtNbEmploye.AutoSize = true;
            txtNbEmploye.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbEmploye.ForeColor = Color.Maroon;
            txtNbEmploye.Location = new Point(893, 29);
            txtNbEmploye.Name = "txtNbEmploye";
            txtNbEmploye.Size = new Size(24, 28);
            txtNbEmploye.TabIndex = 9;
            txtNbEmploye.Text = "_";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(592, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(643, 29);
            label5.Name = "label5";
            label5.Size = new Size(259, 28);
            label5.TabIndex = 7;
            label5.Text = "Liste des Employées: ";
            // 
            // EmployeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtNbEmploye);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(dgvEmployes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "EmployeForm";
            Size = new Size(1487, 639);
            Load += EmployeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdateEmploye;
        private Button btnSaveEmploye;
        private RadioButton txtGenderF;
        private RadioButton txtGenderM;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvEmployes;
        private Label txtNbEmploye;
        private PictureBox pictureBox2;
        private Label label5;
    }
}
