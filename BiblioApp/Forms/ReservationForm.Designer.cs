namespace BiblioApp.Forms
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnPrint = new Button();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            txtCategoryCriteria = new ComboBox();
            btnSearch = new Button();
            txtCurrentPage = new Label();
            groupBox1 = new GroupBox();
            txtAuthorCriteria = new ComboBox();
            txtTitleCriteria = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnNewBook = new Button();
            txtNbBooks = new Label();
            dgvBooks = new DataGridView();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.LightCyan;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(1074, 45);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(111, 29);
            btnPrint.TabIndex = 37;
            btnPrint.Text = "Print PDF";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            btnLast.BackColor = SystemColors.ButtonFace;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(120, 62);
            btnLast.Margin = new Padding(2);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(38, 28);
            btnLast.TabIndex = 35;
            btnLast.TextAlign = ContentAlignment.MiddleRight;
            btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ButtonFace;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(80, 62);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 28);
            btnNext.TabIndex = 34;
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = SystemColors.ButtonFace;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(56, 65);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(26, 22);
            btnPrevious.TabIndex = 33;
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = SystemColors.ButtonFace;
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(14, 62);
            btnFirst.Margin = new Padding(2);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(38, 28);
            btnFirst.TabIndex = 32;
            btnFirst.TextAlign = ContentAlignment.MiddleRight;
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // txtCategoryCriteria
            // 
            txtCategoryCriteria.FormattingEnabled = true;
            txtCategoryCriteria.Location = new Point(162, 26);
            txtCategoryCriteria.Name = "txtCategoryCriteria";
            txtCategoryCriteria.Size = new Size(151, 28);
            txtCategoryCriteria.TabIndex = 17;
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
            btnSearch.Location = new Point(968, 23);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 28);
            btnSearch.TabIndex = 16;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.ForeColor = Color.Maroon;
            txtCurrentPage.Location = new Point(163, 65);
            txtCurrentPage.Margin = new Padding(2, 0, 2, 0);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(15, 20);
            txtCurrentPage.TabIndex = 36;
            txtCurrentPage.Text = "_";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoryCriteria);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtAuthorCriteria);
            groupBox1.Controls.Add(txtTitleCriteria);
            groupBox1.Location = new Point(234, 21);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(616, 59);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // txtAuthorCriteria
            // 
            txtAuthorCriteria.BackColor = Color.PaleTurquoise;
            txtAuthorCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthorCriteria.FormattingEnabled = true;
            txtAuthorCriteria.Location = new Point(337, 23);
            txtAuthorCriteria.Margin = new Padding(2);
            txtAuthorCriteria.Name = "txtAuthorCriteria";
            txtAuthorCriteria.Size = new Size(195, 29);
            txtAuthorCriteria.TabIndex = 14;
            // 
            // txtTitleCriteria
            // 
            txtTitleCriteria.BackColor = Color.PaleTurquoise;
            txtTitleCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitleCriteria.Location = new Point(12, 27);
            txtTitleCriteria.Margin = new Padding(2);
            txtTitleCriteria.Name = "txtTitleCriteria";
            txtTitleCriteria.Size = new Size(128, 28);
            txtTitleCriteria.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(384, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 29;
            label2.Text = "Category : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(529, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 30;
            label3.Text = "Author : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(246, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 28;
            label1.Text = "Title :";
            // 
            // btnNewBook
            // 
            btnNewBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewBook.BackColor = Color.DeepSkyBlue;
            btnNewBook.Cursor = Cursors.Hand;
            btnNewBook.FlatAppearance.BorderSize = 0;
            btnNewBook.FlatStyle = FlatStyle.Flat;
            btnNewBook.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewBook.Image = (Image)resources.GetObject("btnNewBook.Image");
            btnNewBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewBook.Location = new Point(900, 35);
            btnNewBook.Margin = new Padding(2);
            btnNewBook.Name = "btnNewBook";
            btnNewBook.Size = new Size(158, 55);
            btnNewBook.TabIndex = 27;
            btnNewBook.Text = "Nouvelle reservation";
            btnNewBook.TextAlign = ContentAlignment.MiddleRight;
            btnNewBook.UseVisualStyleBackColor = false;
            // 
            // txtNbBooks
            // 
            txtNbBooks.AutoSize = true;
            txtNbBooks.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbBooks.ForeColor = Color.Maroon;
            txtNbBooks.Location = new Point(191, 29);
            txtNbBooks.Margin = new Padding(2, 0, 2, 0);
            txtNbBooks.Name = "txtNbBooks";
            txtNbBooks.Size = new Size(20, 23);
            txtNbBooks.TabIndex = 26;
            txtNbBooks.Text = "_";
            // 
            // dgvBooks
            // 
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 192);
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.BackgroundColor = SystemColors.ButtonFace;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.ColumnHeadersHeight = 33;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.Location = new Point(14, 103);
            dgvBooks.Margin = new Padding(2);
            dgvBooks.Name = "dgvBooks";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Maroon;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.RowTemplate.Height = 40;
            dgvBooks.Size = new Size(1161, 343);
            dgvBooks.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 25);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 29);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 23);
            label5.TabIndex = 23;
            label5.Text = "List Books : ";
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrint);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(txtCurrentPage);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnNewBook);
            Controls.Add(txtNbBooks);
            Controls.Add(dgvBooks);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Name = "ReservationForm";
            Size = new Size(1190, 511);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrint;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private ComboBox txtCategoryCriteria;
        private Button btnSearch;
        private Label txtCurrentPage;
        private GroupBox groupBox1;
        private ComboBox txtAuthorCriteria;
        private TextBox txtTitleCriteria;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button btnNewBook;
        private Label txtNbBooks;
        private DataGridView dgvBooks;
        private PictureBox pictureBox2;
        private Label label5;
    }
}
