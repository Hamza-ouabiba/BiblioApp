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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeForm));
            dgvEmployes = new DataGridView();
            txtNbEmploye = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            btnNewEmp = new Button();
            txtNameCriteria = new TextBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            txtCurrentPage = new Label();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnFiltrageNom = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            dgvEmployes.Location = new Point(38, 108);
            dgvEmployes.Margin = new Padding(2);
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
            dgvEmployes.Size = new Size(1005, 320);
            dgvEmployes.TabIndex = 6;
            dgvEmployes.CellContentClick += dgvEmployes_CellContentClick;
            dgvEmployes.CellMouseEnter += dgvEmployes_CellMouseEnter;
            // 
            // txtNbEmploye
            // 
            txtNbEmploye.AutoSize = true;
            txtNbEmploye.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbEmploye.ForeColor = Color.Maroon;
            txtNbEmploye.Location = new Point(278, 27);
            txtNbEmploye.Margin = new Padding(2, 0, 2, 0);
            txtNbEmploye.Name = "txtNbEmploye";
            txtNbEmploye.Size = new Size(20, 23);
            txtNbEmploye.TabIndex = 9;
            txtNbEmploye.Text = "_";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 22);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(65, 25);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(218, 23);
            label5.TabIndex = 7;
            label5.Text = "Liste des Employées: ";
            // 
            // btnNewEmp
            // 
            btnNewEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewEmp.BackColor = Color.DeepSkyBlue;
            btnNewEmp.Cursor = Cursors.Hand;
            btnNewEmp.FlatAppearance.BorderSize = 0;
            btnNewEmp.FlatStyle = FlatStyle.Flat;
            btnNewEmp.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewEmp.Image = (Image)resources.GetObject("btnNewEmp.Image");
            btnNewEmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewEmp.Location = new Point(1082, 22);
            btnNewEmp.Margin = new Padding(2);
            btnNewEmp.Name = "btnNewEmp";
            btnNewEmp.Size = new Size(201, 29);
            btnNewEmp.TabIndex = 23;
            btnNewEmp.Text = "Nouveau employé";
            btnNewEmp.TextAlign = ContentAlignment.MiddleRight;
            btnNewEmp.UseVisualStyleBackColor = false;
            btnNewEmp.Click += btnNewEmp_Click;
            // 
            // txtNameCriteria
            // 
            txtNameCriteria.BackColor = Color.White;
            txtNameCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameCriteria.Location = new Point(14, 23);
            txtNameCriteria.Margin = new Padding(2);
            txtNameCriteria.Name = "txtNameCriteria";
            txtNameCriteria.PlaceholderText = "Cherchez un employé ...";
            txtNameCriteria.Size = new Size(344, 28);
            txtNameCriteria.TabIndex = 10;
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
            btnSearch.Location = new Point(372, 22);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 28);
            btnSearch.TabIndex = 16;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNameCriteria);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Location = new Point(327, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(425, 59);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.ForeColor = Color.Maroon;
            txtCurrentPage.Location = new Point(178, 58);
            txtCurrentPage.Margin = new Padding(2, 0, 2, 0);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(15, 20);
            txtCurrentPage.TabIndex = 30;
            txtCurrentPage.Text = "_";
            // 
            // btnLast
            // 
            btnLast.BackColor = SystemColors.ButtonFace;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(135, 55);
            btnLast.Margin = new Padding(2);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(38, 28);
            btnLast.TabIndex = 29;
            btnLast.TextAlign = ContentAlignment.MiddleRight;
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ButtonFace;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(95, 55);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 28);
            btnNext.TabIndex = 28;
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = SystemColors.ButtonFace;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(71, 58);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(26, 22);
            btnPrevious.TabIndex = 27;
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = SystemColors.ButtonFace;
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(30, 55);
            btnFirst.Margin = new Padding(2);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(38, 28);
            btnFirst.TabIndex = 26;
            btnFirst.TextAlign = ContentAlignment.MiddleRight;
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnFiltrageNom
            // 
            btnFiltrageNom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrageNom.BackColor = Color.FromArgb(255, 128, 0);
            btnFiltrageNom.Cursor = Cursors.Hand;
            btnFiltrageNom.FlatAppearance.BorderSize = 0;
            btnFiltrageNom.FlatStyle = FlatStyle.Flat;
            btnFiltrageNom.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrageNom.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrageNom.Location = new Point(922, 22);
            btnFiltrageNom.Margin = new Padding(2);
            btnFiltrageNom.Name = "btnFiltrageNom";
            btnFiltrageNom.Size = new Size(130, 29);
            btnFiltrageNom.TabIndex = 31;
            btnFiltrageNom.Text = "trie par nom";
            btnFiltrageNom.TextAlign = ContentAlignment.MiddleRight;
            btnFiltrageNom.UseVisualStyleBackColor = false;
            btnFiltrageNom.Click += btnFiltrageNom_Click;
            // 
            // EmployeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFiltrageNom);
            Controls.Add(txtCurrentPage);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(groupBox1);
            Controls.Add(btnNewEmp);
            Controls.Add(txtNbEmploye);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(dgvEmployes);
            Margin = new Padding(2);
            Name = "EmployeForm";
            Size = new Size(1309, 511);
            Load += EmployeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvEmployes;
        private Label txtNbEmploye;
        private PictureBox pictureBox2;
        private Label label5;
        private Button btnNewEmp;
        private TextBox txtNameCriteria;
        private Button btnSearch;
        private GroupBox groupBox1;
        private Label txtCurrentPage;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnFiltrageNom;
    }
}
