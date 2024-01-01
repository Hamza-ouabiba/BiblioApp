
namespace BiblioApp.Forms
{
    partial class AuthorsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            pictureBox2 = new PictureBox();
            label5 = new Label();
            dgvAuthors = new DataGridView();
            txtNbAuthors = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 0;
            label1.Text = "Ajouter Auteur";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 10);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            groupBox1.Location = new Point(11, 54);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(323, 334);
            groupBox1.TabIndex = 2;
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
            btnUpdateAuthor.Location = new Point(104, 288);
            btnUpdateAuthor.Margin = new Padding(2, 2, 2, 2);
            btnUpdateAuthor.Name = "btnUpdateAuthor";
            btnUpdateAuthor.Size = new Size(102, 32);
            btnUpdateAuthor.TabIndex = 8;
            btnUpdateAuthor.Text = "Update";
            btnUpdateAuthor.UseVisualStyleBackColor = false;
            btnUpdateAuthor.Click += btnUpdateAuthor_Click;
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
            btnSaveAuthor.Location = new Point(216, 288);
            btnSaveAuthor.Margin = new Padding(2, 2, 2, 2);
            btnSaveAuthor.Name = "btnSaveAuthor";
            btnSaveAuthor.Size = new Size(102, 32);
            btnSaveAuthor.TabIndex = 7;
            btnSaveAuthor.Text = "Save";
            btnSaveAuthor.UseVisualStyleBackColor = false;
            btnSaveAuthor.Click += btnSaveAuthor_Click;
            // 
            // txtGenderF
            // 
            txtGenderF.AutoSize = true;
            txtGenderF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGenderF.Location = new Point(165, 222);
            txtGenderF.Margin = new Padding(2, 2, 2, 2);
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
            txtGenderM.Location = new Point(104, 222);
            txtGenderM.Margin = new Padding(2, 2, 2, 2);
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
            label4.Location = new Point(18, 220);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 4;
            label4.Text = "Gender : ";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightBlue;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(18, 154);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 34);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(18, 117);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "Email : ";
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightBlue;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(18, 67);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 34);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(18, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 0;
            label2.Text = "Name : ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(387, 10);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(428, 14);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(184, 23);
            label5.TabIndex = 3;
            label5.Text = "Liste des Auteurs: ";
            // 
            // dgvAuthors
            // 
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 192);
            dgvAuthors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuthors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAuthors.BackgroundColor = SystemColors.ButtonFace;
            dgvAuthors.BorderStyle = BorderStyle.None;
            dgvAuthors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAuthors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAuthors.ColumnHeadersHeight = 33;
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAuthors.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAuthors.EnableHeadersVisualStyles = false;
            dgvAuthors.Location = new Point(387, 54);
            dgvAuthors.Margin = new Padding(2, 2, 2, 2);
            dgvAuthors.Name = "dgvAuthors";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Maroon;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAuthors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAuthors.RowHeadersWidth = 62;
            dgvAuthors.RowTemplate.Height = 40;
            dgvAuthors.Size = new Size(777, 320);
            dgvAuthors.TabIndex = 5;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            dgvAuthors.CellMouseEnter += dgvAuthors_CellMouseEnter;
            // 
            // txtNbAuthors
            // 
            txtNbAuthors.AutoSize = true;
            txtNbAuthors.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbAuthors.ForeColor = Color.Maroon;
            txtNbAuthors.Location = new Point(608, 14);
            txtNbAuthors.Margin = new Padding(2, 0, 2, 0);
            txtNbAuthors.Name = "txtNbAuthors";
            txtNbAuthors.Size = new Size(20, 23);
            txtNbAuthors.TabIndex = 6;
            txtNbAuthors.Text = "_";
            // 
            // AuthorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtNbAuthors);
            Controls.Add(dgvAuthors);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AuthorsForm";
            Size = new Size(1190, 511);
            Load += AuthorsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton txtGenderF;
        private RadioButton txtGenderM;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Button btnSaveAuthor;
        private PictureBox pictureBox2;
        private Label label5;
        private DataGridView dgvAuthors;
        private Label txtNbAuthors;
        private Button btnUpdateAuthor;
    }
}
