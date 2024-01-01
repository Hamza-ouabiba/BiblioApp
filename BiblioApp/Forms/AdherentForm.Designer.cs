namespace BiblioApp.Forms
{
    partial class AdherentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdherentForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtPrenom = new TextBox();
            label4 = new Label();
            btnUpdateAdherent = new Button();
            btnSaveAdherent = new Button();
            txtEmail = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNbAdherents = new Label();
            dgvAdherent = new DataGridView();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            txtAuthorCriteria = new ComboBox();
            label6 = new Label();
            txtCategoryCriteria = new TextBox();
            label7 = new Label();
            txtTitleCriteria = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdherent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrenom);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnUpdateAdherent);
            groupBox1.Controls.Add(btnSaveAdherent);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 83);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(323, 334);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.LightBlue;
            txtPrenom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrenom.Location = new Point(18, 234);
            txtPrenom.Margin = new Padding(2, 2, 2, 2);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(286, 34);
            txtPrenom.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(18, 198);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 9;
            label4.Text = "Prenom";
            // 
            // btnUpdateAdherent
            // 
            btnUpdateAdherent.BackColor = Color.LightCyan;
            btnUpdateAdherent.Cursor = Cursors.Hand;
            btnUpdateAdherent.FlatAppearance.BorderSize = 0;
            btnUpdateAdherent.FlatStyle = FlatStyle.Flat;
            btnUpdateAdherent.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAdherent.Image = (Image)resources.GetObject("btnUpdateAdherent.Image");
            btnUpdateAdherent.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateAdherent.Location = new Point(104, 288);
            btnUpdateAdherent.Margin = new Padding(2, 2, 2, 2);
            btnUpdateAdherent.Name = "btnUpdateAdherent";
            btnUpdateAdherent.Size = new Size(102, 32);
            btnUpdateAdherent.TabIndex = 8;
            btnUpdateAdherent.Text = "Update";
            btnUpdateAdherent.UseVisualStyleBackColor = false;
            btnUpdateAdherent.Click += btnUpdateAdherent_Click;
            // 
            // btnSaveAdherent
            // 
            btnSaveAdherent.BackColor = Color.LightGray;
            btnSaveAdherent.Cursor = Cursors.Hand;
            btnSaveAdherent.FlatAppearance.BorderSize = 0;
            btnSaveAdherent.FlatStyle = FlatStyle.Flat;
            btnSaveAdherent.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveAdherent.Image = (Image)resources.GetObject("btnSaveAdherent.Image");
            btnSaveAdherent.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveAdherent.Location = new Point(216, 288);
            btnSaveAdherent.Margin = new Padding(2, 2, 2, 2);
            btnSaveAdherent.Name = "btnSaveAdherent";
            btnSaveAdherent.Size = new Size(102, 32);
            btnSaveAdherent.TabIndex = 7;
            btnSaveAdherent.Text = "Save";
            btnSaveAdherent.UseVisualStyleBackColor = false;
            btnSaveAdherent.Click += btnSaveAdherent_Click;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 39);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 7;
            label1.Text = "Ajouter Adherent";
            // 
            // txtNbAdherents
            // 
            txtNbAdherents.AutoSize = true;
            txtNbAdherents.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbAdherents.ForeColor = Color.Maroon;
            txtNbAdherents.Location = new Point(673, 83);
            txtNbAdherents.Margin = new Padding(2, 0, 2, 0);
            txtNbAdherents.Name = "txtNbAdherents";
            txtNbAdherents.Size = new Size(20, 23);
            txtNbAdherents.TabIndex = 13;
            txtNbAdherents.Text = "_";
            // 
            // dgvAdherent
            // 
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 192);
            dgvAdherent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdherent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdherent.BackgroundColor = SystemColors.ButtonFace;
            dgvAdherent.BorderStyle = BorderStyle.None;
            dgvAdherent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAdherent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAdherent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAdherent.ColumnHeadersHeight = 33;
            dgvAdherent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAdherent.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAdherent.EnableHeadersVisualStyles = false;
            dgvAdherent.Location = new Point(397, 132);
            dgvAdherent.Margin = new Padding(2, 2, 2, 2);
            dgvAdherent.Name = "dgvAdherent";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Maroon;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAdherent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAdherent.RowHeadersWidth = 62;
            dgvAdherent.RowTemplate.Height = 40;
            dgvAdherent.Size = new Size(791, 348);
            dgvAdherent.TabIndex = 12;
            dgvAdherent.CellDoubleClick += dgvAdherent_CellDoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(413, 83);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(453, 83);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 23);
            label5.TabIndex = 10;
            label5.Text = "Liste des Adherents:";
            // 
            // txtAuthorCriteria
            // 
            txtAuthorCriteria.BackColor = Color.PaleTurquoise;
            txtAuthorCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthorCriteria.FormattingEnabled = true;
            txtAuthorCriteria.Location = new Point(703, 39);
            txtAuthorCriteria.Margin = new Padding(2);
            txtAuthorCriteria.Name = "txtAuthorCriteria";
            txtAuthorCriteria.Size = new Size(195, 29);
            txtAuthorCriteria.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(703, 15);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 20;
            label6.Text = "Author : ";
            // 
            // txtCategoryCriteria
            // 
            txtCategoryCriteria.BackColor = Color.PaleTurquoise;
            txtCategoryCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryCriteria.Location = new Point(562, 40);
            txtCategoryCriteria.Margin = new Padding(2);
            txtCategoryCriteria.Name = "txtCategoryCriteria";
            txtCategoryCriteria.Size = new Size(128, 28);
            txtCategoryCriteria.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(558, 15);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 18;
            label7.Text = "Category : ";
            // 
            // txtTitleCriteria
            // 
            txtTitleCriteria.BackColor = Color.PaleTurquoise;
            txtTitleCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitleCriteria.Location = new Point(424, 40);
            txtTitleCriteria.Margin = new Padding(2);
            txtTitleCriteria.Name = "txtTitleCriteria";
            txtTitleCriteria.Size = new Size(128, 28);
            txtTitleCriteria.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(420, 15);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 16;
            label8.Text = "Title :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Location = new Point(408, 12);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(559, 59);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = SystemColors.ButtonFace;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(854, 23);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 28);
            btnSearch.TabIndex = 16;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // AdherentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtAuthorCriteria);
            Controls.Add(label6);
            Controls.Add(txtCategoryCriteria);
            Controls.Add(label7);
            Controls.Add(txtTitleCriteria);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtNbAdherents);
            Controls.Add(dgvAdherent);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdherentForm";
            Size = new Size(1204, 539);
            Load += AdherentForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdherent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdateAdherent;
        private Button btnSaveAdherent;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label txtNbAdherents;
        private DataGridView dgvAdherent;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox txtPrenom;
        private Label label4;
        private ComboBox txtAuthorCriteria;
        private Label label6;
        private TextBox txtCategoryCriteria;
        private Label label7;
        private TextBox txtTitleCriteria;
        private Label label8;
        private GroupBox groupBox2;
        private Button btnSearch;
    }
}
