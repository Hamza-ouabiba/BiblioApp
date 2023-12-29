
namespace BiblioApp
{
    partial class BookNewEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookNewEditForm));
            panel1 = new Panel();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            txtTitleForm = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            comboAuteur = new ComboBox();
            txtNbPages = new TextBox();
            txtPrice = new TextBox();
            labeltxtnbPage = new Label();
            txtPricell = new Label();
            txtPublishedDate = new DateTimePicker();
            label4 = new Label();
            txtDescrip = new TextBox();
            label3 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            btnSaveBook = new Button();
            txtImageCover = new PictureBox();
            btnUploadCover = new Button();
            txtImageCoverPath = new Label();
            ErrProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImageCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtTitleForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 53);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(1035, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 41);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtTitleForm
            // 
            txtTitleForm.AutoSize = true;
            txtTitleForm.BackColor = Color.Maroon;
            txtTitleForm.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitleForm.ForeColor = SystemColors.ButtonHighlight;
            txtTitleForm.Location = new Point(64, 9);
            txtTitleForm.Name = "txtTitleForm";
            txtTitleForm.Size = new Size(150, 28);
            txtTitleForm.TabIndex = 2;
            txtTitleForm.Text = "New Book : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboAuteur);
            groupBox1.Controls.Add(txtNbPages);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(labeltxtnbPage);
            groupBox1.Controls.Add(txtPricell);
            groupBox1.Controls.Add(txtPublishedDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDescrip);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 612);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(19, 474);
            label5.Name = "label5";
            label5.Size = new Size(90, 30);
            label5.TabIndex = 14;
            label5.Text = "Author :";
            // 
            // comboAuteur
            // 
            comboAuteur.BackColor = Color.LightBlue;
            comboAuteur.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboAuteur.FormattingEnabled = true;
            comboAuteur.Location = new Point(19, 523);
            comboAuteur.Name = "comboAuteur";
            comboAuteur.Size = new Size(420, 38);
            comboAuteur.TabIndex = 13;
            // 
            // txtNbPages
            // 
            txtNbPages.BackColor = Color.LightBlue;
            txtNbPages.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNbPages.Location = new Point(336, 367);
            txtNbPages.Name = "txtNbPages";
            txtNbPages.Size = new Size(103, 37);
            txtNbPages.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.LightBlue;
            txtPrice.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(218, 366);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(86, 37);
            txtPrice.TabIndex = 11;
            // 
            // labeltxtnbPage
            // 
            labeltxtnbPage.AutoSize = true;
            labeltxtnbPage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labeltxtnbPage.ForeColor = Color.Brown;
            labeltxtnbPage.Location = new Point(336, 333);
            labeltxtnbPage.Name = "labeltxtnbPage";
            labeltxtnbPage.Size = new Size(103, 30);
            labeltxtnbPage.TabIndex = 10;
            labeltxtnbPage.Text = "Nb.Pages";
            labeltxtnbPage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPricell
            // 
            txtPricell.AutoSize = true;
            txtPricell.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPricell.ForeColor = Color.Brown;
            txtPricell.Location = new Point(218, 333);
            txtPricell.Name = "txtPricell";
            txtPricell.Size = new Size(71, 30);
            txtPricell.TabIndex = 4;
            txtPricell.Text = "Price :";
            txtPricell.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPublishedDate
            // 
            txtPublishedDate.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublishedDate.CalendarMonthBackground = Color.LightBlue;
            txtPublishedDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublishedDate.Format = DateTimePickerFormat.Short;
            txtPublishedDate.Location = new Point(22, 368);
            txtPublishedDate.Name = "txtPublishedDate";
            txtPublishedDate.Size = new Size(152, 37);
            txtPublishedDate.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(22, 333);
            label4.Name = "label4";
            label4.Size = new Size(168, 30);
            label4.TabIndex = 4;
            label4.Text = "Published Date :";
            // 
            // txtDescrip
            // 
            txtDescrip.BackColor = Color.LightBlue;
            txtDescrip.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescrip.Location = new Point(22, 170);
            txtDescrip.Multiline = true;
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(420, 131);
            txtDescrip.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(22, 137);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 2;
            label3.Text = "Description :";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.LightBlue;
            txtTitle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(22, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(420, 37);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(22, 38);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 0;
            label2.Text = "Title :";
            // 
            // btnSaveBook
            // 
            btnSaveBook.BackColor = Color.LightGray;
            btnSaveBook.Cursor = Cursors.Hand;
            btnSaveBook.FlatAppearance.BorderSize = 0;
            btnSaveBook.FlatStyle = FlatStyle.Flat;
            btnSaveBook.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveBook.Image = (Image)resources.GetObject("btnSaveBook.Image");
            btnSaveBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveBook.Location = new Point(870, 721);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(181, 40);
            btnSaveBook.TabIndex = 7;
            btnSaveBook.Text = "Create New Book";
            btnSaveBook.TextAlign = ContentAlignment.MiddleRight;
            btnSaveBook.UseVisualStyleBackColor = false;
            // 
            // txtImageCover
            // 
            txtImageCover.BorderStyle = BorderStyle.FixedSingle;
            txtImageCover.Location = new Point(531, 84);
            txtImageCover.Name = "txtImageCover";
            txtImageCover.Size = new Size(520, 602);
            txtImageCover.SizeMode = PictureBoxSizeMode.Zoom;
            txtImageCover.TabIndex = 8;
            txtImageCover.TabStop = false;
            // 
            // btnUploadCover
            // 
            btnUploadCover.BackColor = Color.SeaShell;
            btnUploadCover.Cursor = Cursors.Hand;
            btnUploadCover.FlatAppearance.BorderSize = 0;
            btnUploadCover.FlatStyle = FlatStyle.Flat;
            btnUploadCover.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUploadCover.Image = (Image)resources.GetObject("btnUploadCover.Image");
            btnUploadCover.ImageAlign = ContentAlignment.MiddleLeft;
            btnUploadCover.Location = new Point(923, 637);
            btnUploadCover.Name = "btnUploadCover";
            btnUploadCover.Size = new Size(116, 40);
            btnUploadCover.TabIndex = 9;
            btnUploadCover.Text = "Upload";
            btnUploadCover.TextAlign = ContentAlignment.MiddleRight;
            btnUploadCover.UseVisualStyleBackColor = false;
            // 
            // txtImageCoverPath
            // 
            txtImageCoverPath.AutoSize = true;
            txtImageCoverPath.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtImageCoverPath.ForeColor = Color.Brown;
            txtImageCoverPath.Location = new Point(500, 689);
            txtImageCoverPath.Name = "txtImageCoverPath";
            txtImageCoverPath.Size = new Size(22, 30);
            txtImageCoverPath.TabIndex = 17;
            txtImageCoverPath.Text = "_";
            txtImageCoverPath.Visible = false;
            // 
            // ErrProvider
            // 
            ErrProvider.ContainerControl = this;
            ErrProvider.Icon = (Icon)resources.GetObject("ErrProvider.Icon");
            // 
            // BookNewEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1098, 791);
            Controls.Add(txtImageCoverPath);
            Controls.Add(btnUploadCover);
            Controls.Add(txtImageCover);
            Controls.Add(panel1);
            Controls.Add(btnSaveBook);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookNewEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookNewEditForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtImageCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label txtTitleForm;
        private Button btnExit;
        private GroupBox groupBox1;
        private DateTimePicker txtPublishedDate;
        private Button btnSaveBook;
        private Label label4;
        private TextBox txtDescrip;
        private Label label3;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtNbPages;
        private TextBox txtPrice;
        private Label labeltxtnbPage;
        private Label txtPricell;
        private Label label5;
        private ComboBox comboAuteur;
        private PictureBox txtImageCover;
        private Button btnUploadCover;
        private Label txtImageCoverPath;
        private ErrorProvider ErrProvider;
    }
}