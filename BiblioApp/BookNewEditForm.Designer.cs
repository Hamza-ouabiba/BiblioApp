
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
            label1 = new Label();
            comboCategory = new ComboBox();
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
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtTitleForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 42);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(828, 5);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(37, 33);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 6);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 26);
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
            txtTitleForm.Location = new Point(51, 7);
            txtTitleForm.Margin = new Padding(2, 0, 2, 0);
            txtTitleForm.Name = "txtTitleForm";
            txtTitleForm.Size = new Size(107, 23);
            txtTitleForm.TabIndex = 2;
            txtTitleForm.Text = "Ajout livre";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboCategory);
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
            groupBox1.Location = new Point(10, 59);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(398, 490);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(18, 412);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 16;
            label1.Text = "Categorie";
            // 
            // comboCategory
            // 
            comboCategory.BackColor = Color.White;
            comboCategory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(18, 446);
            comboCategory.Margin = new Padding(2);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(337, 31);
            comboCategory.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(18, 340);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 14;
            label5.Text = "Author :";
            // 
            // comboAuteur
            // 
            comboAuteur.BackColor = Color.White;
            comboAuteur.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboAuteur.FormattingEnabled = true;
            comboAuteur.Location = new Point(18, 371);
            comboAuteur.Margin = new Padding(2);
            comboAuteur.Name = "comboAuteur";
            comboAuteur.Size = new Size(337, 31);
            comboAuteur.TabIndex = 13;
            // 
            // txtNbPages
            // 
            txtNbPages.BackColor = Color.White;
            txtNbPages.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNbPages.Location = new Point(269, 294);
            txtNbPages.Margin = new Padding(2);
            txtNbPages.Name = "txtNbPages";
            txtNbPages.Size = new Size(83, 32);
            txtNbPages.TabIndex = 12;
            txtNbPages.Validating += txtNbPages_Validating;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(174, 293);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(70, 32);
            txtPrice.TabIndex = 11;
            txtPrice.Validating += txtPrice_Validating;
            // 
            // labeltxtnbPage
            // 
            labeltxtnbPage.AutoSize = true;
            labeltxtnbPage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labeltxtnbPage.ForeColor = Color.Brown;
            labeltxtnbPage.Location = new Point(269, 266);
            labeltxtnbPage.Margin = new Padding(2, 0, 2, 0);
            labeltxtnbPage.Name = "labeltxtnbPage";
            labeltxtnbPage.Size = new Size(90, 25);
            labeltxtnbPage.TabIndex = 10;
            labeltxtnbPage.Text = "Nb.Pages";
            labeltxtnbPage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPricell
            // 
            txtPricell.AutoSize = true;
            txtPricell.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPricell.ForeColor = Color.Brown;
            txtPricell.Location = new Point(174, 266);
            txtPricell.Margin = new Padding(2, 0, 2, 0);
            txtPricell.Name = "txtPricell";
            txtPricell.Size = new Size(63, 25);
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
            txtPublishedDate.Location = new Point(18, 294);
            txtPublishedDate.Margin = new Padding(2);
            txtPublishedDate.Name = "txtPublishedDate";
            txtPublishedDate.Size = new Size(122, 32);
            txtPublishedDate.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(18, 266);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 4;
            label4.Text = "Published Date :";
            // 
            // txtDescrip
            // 
            txtDescrip.BackColor = Color.White;
            txtDescrip.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescrip.Location = new Point(18, 136);
            txtDescrip.Margin = new Padding(2);
            txtDescrip.Multiline = true;
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(337, 106);
            txtDescrip.TabIndex = 3;
            txtDescrip.Validating += txtDescrip_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(18, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Description :";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(18, 67);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(337, 32);
            txtTitle.TabIndex = 1;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(18, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
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
            btnSaveBook.Location = new Point(696, 577);
            btnSaveBook.Margin = new Padding(2);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(145, 32);
            btnSaveBook.TabIndex = 7;
            btnSaveBook.Text = "Create New Book";
            btnSaveBook.TextAlign = ContentAlignment.MiddleRight;
            btnSaveBook.UseVisualStyleBackColor = false;
            btnSaveBook.Click += btnSaveBook_Click;
            // 
            // txtImageCover
            // 
            txtImageCover.BorderStyle = BorderStyle.FixedSingle;
            txtImageCover.Location = new Point(425, 67);
            txtImageCover.Margin = new Padding(2);
            txtImageCover.Name = "txtImageCover";
            txtImageCover.Size = new Size(416, 482);
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
            btnUploadCover.Location = new Point(738, 510);
            btnUploadCover.Margin = new Padding(2);
            btnUploadCover.Name = "btnUploadCover";
            btnUploadCover.Size = new Size(93, 32);
            btnUploadCover.TabIndex = 9;
            btnUploadCover.Text = "Upload";
            btnUploadCover.TextAlign = ContentAlignment.MiddleRight;
            btnUploadCover.UseVisualStyleBackColor = false;
            btnUploadCover.Click += btnUploadCover_Click;
            // 
            // txtImageCoverPath
            // 
            txtImageCoverPath.AutoSize = true;
            txtImageCoverPath.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtImageCoverPath.ForeColor = Color.Brown;
            txtImageCoverPath.Location = new Point(400, 551);
            txtImageCoverPath.Margin = new Padding(2, 0, 2, 0);
            txtImageCoverPath.Name = "txtImageCoverPath";
            txtImageCoverPath.Size = new Size(20, 25);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 633);
            Controls.Add(txtImageCoverPath);
            Controls.Add(btnUploadCover);
            Controls.Add(txtImageCover);
            Controls.Add(panel1);
            Controls.Add(btnSaveBook);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "BookNewEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookNewEditForm";
            Load += BookNewEditForm_Load;
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
        private Label label1;
        private ComboBox comboCategory;
    }
}