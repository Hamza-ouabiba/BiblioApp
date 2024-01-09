
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
            pictureBox2 = new PictureBox();
            label5 = new Label();
            dgvAuthors = new DataGridView();
            txtNbAuthors = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtNameCriteria = new TextBox();
            btnNewAuteur = new Button();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            txtCurrentPage = new Label();
            btnTrieLivre = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 14);
            pictureBox2.Margin = new Padding(2);
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
            label5.Location = new Point(64, 18);
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
            dgvAuthors.Location = new Point(23, 96);
            dgvAuthors.Margin = new Padding(2);
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
            dgvAuthors.Size = new Size(1401, 320);
            dgvAuthors.TabIndex = 5;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            dgvAuthors.CellMouseEnter += dgvAuthors_CellMouseEnter;
            // 
            // txtNbAuthors
            // 
            txtNbAuthors.AutoSize = true;
            txtNbAuthors.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbAuthors.ForeColor = Color.Maroon;
            txtNbAuthors.Location = new Point(244, 18);
            txtNbAuthors.Margin = new Padding(2, 0, 2, 0);
            txtNbAuthors.Name = "txtNbAuthors";
            txtNbAuthors.Size = new Size(20, 23);
            txtNbAuthors.TabIndex = 6;
            txtNbAuthors.Text = "_";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtNameCriteria);
            groupBox2.Location = new Point(315, 2);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(484, 59);
            groupBox2.TabIndex = 16;
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
            btnSearch.Location = new Point(429, 21);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 28);
            btnSearch.TabIndex = 16;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtNameCriteria
            // 
            txtNameCriteria.BackColor = Color.White;
            txtNameCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameCriteria.Location = new Point(0, 21);
            txtNameCriteria.Margin = new Padding(2);
            txtNameCriteria.Name = "txtNameCriteria";
            txtNameCriteria.PlaceholderText = "Cherchez sur un auteur";
            txtNameCriteria.Size = new Size(389, 28);
            txtNameCriteria.TabIndex = 10;
            // 
            // btnNewAuteur
            // 
            btnNewAuteur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewAuteur.BackColor = Color.DeepSkyBlue;
            btnNewAuteur.Cursor = Cursors.Hand;
            btnNewAuteur.FlatAppearance.BorderSize = 0;
            btnNewAuteur.FlatStyle = FlatStyle.Flat;
            btnNewAuteur.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewAuteur.Image = (Image)resources.GetObject("btnNewAuteur.Image");
            btnNewAuteur.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewAuteur.Location = new Point(1238, 23);
            btnNewAuteur.Margin = new Padding(2);
            btnNewAuteur.Name = "btnNewAuteur";
            btnNewAuteur.Size = new Size(186, 29);
            btnNewAuteur.TabIndex = 17;
            btnNewAuteur.Text = "Nouveau Auteur";
            btnNewAuteur.TextAlign = ContentAlignment.MiddleRight;
            btnNewAuteur.UseVisualStyleBackColor = false;
            btnNewAuteur.Click += btnNewAuteur_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = SystemColors.ButtonFace;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(129, 52);
            btnLast.Margin = new Padding(2);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(38, 28);
            btnLast.TabIndex = 44;
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
            btnNext.Location = new Point(89, 52);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 28);
            btnNext.TabIndex = 43;
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
            btnPrevious.Location = new Point(65, 55);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(26, 22);
            btnPrevious.TabIndex = 42;
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
            btnFirst.Location = new Point(23, 52);
            btnFirst.Margin = new Padding(2);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(38, 28);
            btnFirst.TabIndex = 41;
            btnFirst.TextAlign = ContentAlignment.MiddleRight;
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.ForeColor = Color.Maroon;
            txtCurrentPage.Location = new Point(180, 52);
            txtCurrentPage.Margin = new Padding(2, 0, 2, 0);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(15, 20);
            txtCurrentPage.TabIndex = 40;
            txtCurrentPage.Text = "_";
            // 
            // btnTrieLivre
            // 
            btnTrieLivre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTrieLivre.BackColor = Color.Lime;
            btnTrieLivre.Cursor = Cursors.Hand;
            btnTrieLivre.FlatAppearance.BorderSize = 0;
            btnTrieLivre.FlatStyle = FlatStyle.Flat;
            btnTrieLivre.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrieLivre.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrieLivre.Location = new Point(1026, 23);
            btnTrieLivre.Margin = new Padding(2);
            btnTrieLivre.Name = "btnTrieLivre";
            btnTrieLivre.Size = new Size(186, 29);
            btnTrieLivre.TabIndex = 45;
            btnTrieLivre.Text = "Trie par Nbre Livre";
            btnTrieLivre.TextAlign = ContentAlignment.MiddleRight;
            btnTrieLivre.UseVisualStyleBackColor = false;
            btnTrieLivre.Click += btnTrieLivre_Click;
            // 
            // AuthorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTrieLivre);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(txtCurrentPage);
            Controls.Add(btnNewAuteur);
            Controls.Add(groupBox2);
            Controls.Add(txtNbAuthors);
            Controls.Add(dgvAuthors);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Margin = new Padding(2);
            Name = "AuthorsForm";
            Size = new Size(1452, 511);
            Load += AuthorsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label5;
        private DataGridView dgvAuthors;
        private Label txtNbAuthors;
        private GroupBox groupBox2;
        private Button btnSearch;
        private Button btnNewAuteur;
        private TextBox txtNameCriteria;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Label txtCurrentPage;
        private Button btnTrieLivre;
    }
}
