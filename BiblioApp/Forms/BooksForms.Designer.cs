
namespace BiblioApp.Forms
{
    partial class BooksForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForms));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            dgvBooks = new DataGridView();
            txtNbBooks = new Label();
            btnNewBook = new Button();
            label1 = new Label();
            txtTitleCriteria = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAuthorCriteria = new ComboBox();
            groupBox1 = new GroupBox();
            txtCategoryCriteria = new ComboBox();
            btnSearch = new Button();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            txtCurrentPage = new Label();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 6);
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
            label5.Location = new Point(58, 10);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 23);
            label5.TabIndex = 3;
            label5.Text = "List Books : ";
            // 
            // dgvBooks
            // 
            dataGridViewCellStyle13.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(0, 0, 192);
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.BackgroundColor = SystemColors.ButtonFace;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.Maroon;
            dataGridViewCellStyle14.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvBooks.ColumnHeadersHeight = 33;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle15;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.Location = new Point(16, 84);
            dgvBooks.Margin = new Padding(2);
            dgvBooks.Name = "dgvBooks";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.Maroon;
            dataGridViewCellStyle16.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.RowTemplate.Height = 40;
            dgvBooks.Size = new Size(1287, 343);
            dgvBooks.TabIndex = 5;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            dgvBooks.CellMouseEnter += dgvBooks_CellMouseEnter;
            // 
            // txtNbBooks
            // 
            txtNbBooks.AutoSize = true;
            txtNbBooks.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbBooks.ForeColor = Color.Maroon;
            txtNbBooks.Location = new Point(193, 10);
            txtNbBooks.Margin = new Padding(2, 0, 2, 0);
            txtNbBooks.Name = "txtNbBooks";
            txtNbBooks.Size = new Size(20, 23);
            txtNbBooks.TabIndex = 6;
            txtNbBooks.Text = "_";
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
            btnNewBook.Location = new Point(1025, 25);
            btnNewBook.Margin = new Padding(2);
            btnNewBook.Name = "btnNewBook";
            btnNewBook.Size = new Size(166, 29);
            btnNewBook.TabIndex = 8;
            btnNewBook.Text = "Nouveau livre";
            btnNewBook.TextAlign = ContentAlignment.MiddleRight;
            btnNewBook.UseVisualStyleBackColor = false;
            btnNewBook.Click += btnNewBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(248, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 9;
            label1.Text = "Title :";
            // 
            // txtTitleCriteria
            // 
            txtTitleCriteria.BackColor = Color.White;
            txtTitleCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitleCriteria.Location = new Point(12, 28);
            txtTitleCriteria.Margin = new Padding(2);
            txtTitleCriteria.Name = "txtTitleCriteria";
            txtTitleCriteria.PlaceholderText = "Chercher un titre";
            txtTitleCriteria.Size = new Size(210, 28);
            txtTitleCriteria.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(227, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 11;
            label2.Text = "Category : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(452, 6);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 13;
            label3.Text = "Author : ";
            // 
            // txtAuthorCriteria
            // 
            txtAuthorCriteria.BackColor = Color.White;
            txtAuthorCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthorCriteria.FormattingEnabled = true;
            txtAuthorCriteria.Location = new Point(452, 28);
            txtAuthorCriteria.Margin = new Padding(2);
            txtAuthorCriteria.Name = "txtAuthorCriteria";
            txtAuthorCriteria.Size = new Size(244, 29);
            txtAuthorCriteria.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoryCriteria);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtAuthorCriteria);
            groupBox1.Controls.Add(txtTitleCriteria);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(236, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(766, 69);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // txtCategoryCriteria
            // 
            txtCategoryCriteria.FormattingEnabled = true;
            txtCategoryCriteria.Location = new Point(227, 29);
            txtCategoryCriteria.Name = "txtCategoryCriteria";
            txtCategoryCriteria.Size = new Size(211, 28);
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
            btnSearch.Location = new Point(700, 27);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 28);
            btnSearch.TabIndex = 16;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = SystemColors.ButtonFace;
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.Location = new Point(16, 43);
            btnFirst.Margin = new Padding(2);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(38, 28);
            btnFirst.TabIndex = 17;
            btnFirst.TextAlign = ContentAlignment.MiddleRight;
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = SystemColors.ButtonFace;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(58, 46);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(26, 22);
            btnPrevious.TabIndex = 18;
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ButtonFace;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(82, 43);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 28);
            btnNext.TabIndex = 19;
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = SystemColors.ButtonFace;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(122, 43);
            btnLast.Margin = new Padding(2);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(38, 28);
            btnLast.TabIndex = 20;
            btnLast.TextAlign = ContentAlignment.MiddleRight;
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.ForeColor = Color.Maroon;
            txtCurrentPage.Location = new Point(165, 46);
            txtCurrentPage.Margin = new Padding(2, 0, 2, 0);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(15, 20);
            txtCurrentPage.TabIndex = 21;
            txtCurrentPage.Text = "_";
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
            btnPrint.Location = new Point(1196, 26);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(117, 29);
            btnPrint.TabIndex = 22;
            btnPrint.Text = "Print PDF";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // BooksForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrint);
            Controls.Add(txtCurrentPage);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(label1);
            Controls.Add(btnNewBook);
            Controls.Add(txtNbBooks);
            Controls.Add(dgvBooks);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "BooksForms";
            Size = new Size(1316, 511);
            Load += BooksForms_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label txtNbBooks;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitleCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtAuthorCriteria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label txtCurrentPage;
        private System.Windows.Forms.Button btnPrint;
        private ComboBox txtCategoryCriteria;
    }
}
