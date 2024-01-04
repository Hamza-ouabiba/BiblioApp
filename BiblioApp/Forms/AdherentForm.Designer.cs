
namespace BiblioApp.Forms
{
    partial class AdherentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdherentForm));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            dgvBooks = new DataGridView();
            txtNbBooks = new Label();
            label1 = new Label();
            txtTitleCriteria = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAuthorCriteria = new ComboBox();
            groupBox1 = new GroupBox();
            txtCategoryCriteria = new ComboBox();
            btnSearch = new Button();
            txtCurrentPage = new Label();
            btnPrint = new Button();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnNewReser = new Button();
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
            label5.Size = new Size(155, 23);
            label5.TabIndex = 3;
            label5.Text = "Liste adhérents";
            // 
            // dgvBooks
            // 
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(0, 0, 192);
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.BackgroundColor = SystemColors.ButtonFace;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.Maroon;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvBooks.ColumnHeadersHeight = 33;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle11;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.Location = new Point(16, 84);
            dgvBooks.Margin = new Padding(2);
            dgvBooks.Name = "dgvBooks";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.Maroon;
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.RowTemplate.Height = 40;
            dgvBooks.Size = new Size(1320, 343);
            dgvBooks.TabIndex = 5;
            // 
            // txtNbBooks
            // 
            txtNbBooks.AutoSize = true;
            txtNbBooks.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbBooks.ForeColor = Color.Maroon;
            txtNbBooks.Location = new Point(217, 10);
            txtNbBooks.Margin = new Padding(2, 0, 2, 0);
            txtNbBooks.Name = "txtNbBooks";
            txtNbBooks.Size = new Size(20, 23);
            txtNbBooks.TabIndex = 6;
            txtNbBooks.Text = "_";
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
            txtTitleCriteria.Location = new Point(4, 23);
            txtTitleCriteria.Margin = new Padding(2);
            txtTitleCriteria.Name = "txtTitleCriteria";
            txtTitleCriteria.Size = new Size(156, 28);
            txtTitleCriteria.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(161, 3);
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
            label3.Location = new Point(419, 4);
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
            txtAuthorCriteria.Location = new Point(428, 23);
            txtAuthorCriteria.Margin = new Padding(2);
            txtAuthorCriteria.Name = "txtAuthorCriteria";
            txtAuthorCriteria.Size = new Size(253, 29);
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
            groupBox1.Location = new Point(248, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(763, 69);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // txtCategoryCriteria
            // 
            txtCategoryCriteria.FormattingEnabled = true;
            txtCategoryCriteria.Location = new Point(173, 23);
            txtCategoryCriteria.Name = "txtCategoryCriteria";
            txtCategoryCriteria.Size = new Size(250, 28);
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
            btnSearch.Location = new Point(698, 24);
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
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(1230, 26);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(117, 29);
            btnPrint.TabIndex = 22;
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
            btnLast.Location = new Point(114, 46);
            btnLast.Margin = new Padding(2);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(38, 28);
            btnLast.TabIndex = 39;
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
            btnNext.Location = new Point(74, 46);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 28);
            btnNext.TabIndex = 38;
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
            btnPrevious.Location = new Point(50, 49);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(26, 22);
            btnPrevious.TabIndex = 37;
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
            btnFirst.Location = new Point(8, 46);
            btnFirst.Margin = new Padding(2);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(38, 28);
            btnFirst.TabIndex = 36;
            btnFirst.TextAlign = ContentAlignment.MiddleRight;
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnNewReser
            // 
            btnNewReser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewReser.BackColor = Color.DeepSkyBlue;
            btnNewReser.Cursor = Cursors.Hand;
            btnNewReser.FlatAppearance.BorderSize = 0;
            btnNewReser.FlatStyle = FlatStyle.Flat;
            btnNewReser.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewReser.Image = (Image)resources.GetObject("btnNewReser.Image");
            btnNewReser.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewReser.Location = new Point(1044, 25);
            btnNewReser.Margin = new Padding(2);
            btnNewReser.Name = "btnNewReser";
            btnNewReser.Size = new Size(207, 35);
            btnNewReser.TabIndex = 40;
            btnNewReser.Text = "Nouveau adhérent";
            btnNewReser.TextAlign = ContentAlignment.MiddleRight;
            btnNewReser.UseVisualStyleBackColor = false;
            // 
            // AdherentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNewReser);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnPrint);
            Controls.Add(txtCurrentPage);
            Controls.Add(label1);
            Controls.Add(txtNbBooks);
            Controls.Add(dgvBooks);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "AdherentForm";
            Size = new Size(1349, 511);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitleCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtAuthorCriteria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label txtCurrentPage;
        private System.Windows.Forms.Button btnPrint;
        private ComboBox txtCategoryCriteria;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnNewReser;
    }
}
