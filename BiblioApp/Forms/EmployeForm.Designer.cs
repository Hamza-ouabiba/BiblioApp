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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnUpdateAuthor = new Button();
            btnSaveAuthor = new Button();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdateAuthor);
            groupBox1.Controls.Add(btnSaveAuthor);
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
            // btnUpdateAuthor
            // 
            btnUpdateAuthor.BackColor = Color.LightCyan;
            btnUpdateAuthor.Cursor = Cursors.Hand;
            btnUpdateAuthor.FlatAppearance.BorderSize = 0;
            btnUpdateAuthor.FlatStyle = FlatStyle.Flat;
            btnUpdateAuthor.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAuthor.Image = (Image)resources.GetObject("btnUpdateAuthor.Image");
            btnUpdateAuthor.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateAuthor.Location = new Point(130, 360);
            btnUpdateAuthor.Name = "btnUpdateAuthor";
            btnUpdateAuthor.Size = new Size(128, 40);
            btnUpdateAuthor.TabIndex = 8;
            btnUpdateAuthor.Text = "Update";
            btnUpdateAuthor.UseVisualStyleBackColor = false;
            // 
            // btnSaveAuthor
            // 
            btnSaveAuthor.BackColor = Color.LightGray;
            btnSaveAuthor.Cursor = Cursors.Hand;
            btnSaveAuthor.FlatAppearance.BorderSize = 0;
            btnSaveAuthor.FlatStyle = FlatStyle.Flat;
            btnSaveAuthor.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveAuthor.Image = (Image)resources.GetObject("btnSaveAuthor.Image");
            btnSaveAuthor.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveAuthor.Location = new Point(270, 360);
            btnSaveAuthor.Name = "btnSaveAuthor";
            btnSaveAuthor.Size = new Size(128, 40);
            btnSaveAuthor.TabIndex = 7;
            btnSaveAuthor.Text = "Save";
            btnSaveAuthor.UseVisualStyleBackColor = false;
            // 
            // txtGenderF
            // 
            txtGenderF.AutoSize = true;
            txtGenderF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGenderF.Location = new Point(206, 278);
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
            txtGenderM.Location = new Point(130, 277);
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
            label4.Location = new Point(22, 275);
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
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 0, 192);
            dgvEmployes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvEmployes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployes.BackgroundColor = SystemColors.ButtonFace;
            dgvEmployes.BorderStyle = BorderStyle.None;
            dgvEmployes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Maroon;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvEmployes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvEmployes.ColumnHeadersHeight = 33;
            dgvEmployes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvEmployes.DefaultCellStyle = dataGridViewCellStyle7;
            dgvEmployes.EnableHeadersVisualStyles = false;
            dgvEmployes.Location = new Point(600, 86);
            dgvEmployes.Name = "dgvEmployes";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Maroon;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvEmployes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvEmployes.RowHeadersWidth = 62;
            dgvEmployes.RowTemplate.Height = 40;
            dgvEmployes.Size = new Size(838, 400);
            dgvEmployes.TabIndex = 6;
            // 
            // EmployeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvEmployes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "EmployeForm";
            Size = new Size(1487, 639);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdateAuthor;
        private Button btnSaveAuthor;
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
    }
}
