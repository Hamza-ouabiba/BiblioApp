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
            btnSearch = new Button();
            txtCurrentPage = new Label();
            groupBox1 = new GroupBox();
            rechercherBtn = new Button();
            txtAdherentCriteria = new ComboBox();
            label2 = new Label();
            btnNewReser = new Button();
            txtNbReservs = new Label();
            dgvReservations = new DataGridView();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
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
            btnPrint.Location = new Point(1330, 50);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(139, 56);
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
            btnLast.Location = new Point(150, 78);
            btnLast.Margin = new Padding(2);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(48, 35);
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
            btnNext.Location = new Point(100, 78);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(52, 35);
            btnNext.TabIndex = 34;
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
            btnPrevious.Location = new Point(70, 81);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(32, 28);
            btnPrevious.TabIndex = 33;
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
            btnFirst.Location = new Point(18, 78);
            btnFirst.Margin = new Padding(2);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(48, 35);
            btnFirst.TabIndex = 32;
            btnFirst.TextAlign = ContentAlignment.MiddleRight;
            btnFirst.UseVisualStyleBackColor = false;
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
            btnSearch.Location = new Point(928, 29);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 35);
            btnSearch.TabIndex = 16;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtCurrentPage
            // 
            txtCurrentPage.AutoSize = true;
            txtCurrentPage.ForeColor = Color.Maroon;
            txtCurrentPage.Location = new Point(204, 81);
            txtCurrentPage.Margin = new Padding(2, 0, 2, 0);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(19, 25);
            txtCurrentPage.TabIndex = 36;
            txtCurrentPage.Text = "_";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rechercherBtn);
            groupBox1.Controls.Add(txtAdherentCriteria);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(450, 32);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(488, 91);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // rechercherBtn
            // 
            rechercherBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rechercherBtn.BackColor = SystemColors.ButtonFace;
            rechercherBtn.Cursor = Cursors.Hand;
            rechercherBtn.FlatAppearance.BorderSize = 0;
            rechercherBtn.FlatStyle = FlatStyle.Flat;
            rechercherBtn.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rechercherBtn.Image = (Image)resources.GetObject("rechercherBtn.Image");
            rechercherBtn.Location = new Point(411, 39);
            rechercherBtn.Margin = new Padding(2);
            rechercherBtn.Name = "rechercherBtn";
            rechercherBtn.Size = new Size(48, 35);
            rechercherBtn.TabIndex = 30;
            rechercherBtn.TextAlign = ContentAlignment.MiddleRight;
            rechercherBtn.UseVisualStyleBackColor = false;
            rechercherBtn.Click += rechercherBtn_Click;
            // 
            // txtAdherentCriteria
            // 
            txtAdherentCriteria.FormattingEnabled = true;
            txtAdherentCriteria.Location = new Point(16, 39);
            txtAdherentCriteria.Margin = new Padding(4);
            txtAdherentCriteria.Name = "txtAdherentCriteria";
            txtAdherentCriteria.Size = new Size(353, 33);
            txtAdherentCriteria.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(16, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 29;
            label2.Text = "Nom Adherent : ";
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
            btnNewReser.Location = new Point(1051, 52);
            btnNewReser.Margin = new Padding(2);
            btnNewReser.Name = "btnNewReser";
            btnNewReser.Size = new Size(274, 52);
            btnNewReser.TabIndex = 27;
            btnNewReser.Text = "Nouvelle reservation";
            btnNewReser.TextAlign = ContentAlignment.MiddleRight;
            btnNewReser.UseVisualStyleBackColor = false;
            btnNewReser.Click += btnNewReser_Click;
            // 
            // txtNbReservs
            // 
            txtNbReservs.AutoSize = true;
            txtNbReservs.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbReservs.ForeColor = Color.Maroon;
            txtNbReservs.Location = new Point(292, 36);
            txtNbReservs.Margin = new Padding(2, 0, 2, 0);
            txtNbReservs.Name = "txtNbReservs";
            txtNbReservs.Size = new Size(24, 28);
            txtNbReservs.TabIndex = 26;
            txtNbReservs.Text = "_";
            // 
            // dgvReservations
            // 
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 192);
            dgvReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservations.BackgroundColor = SystemColors.ButtonFace;
            dgvReservations.BorderStyle = BorderStyle.None;
            dgvReservations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservations.ColumnHeadersHeight = 33;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReservations.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.Location = new Point(18, 129);
            dgvReservations.Margin = new Padding(2);
            dgvReservations.Name = "dgvReservations";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Maroon;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvReservations.RowHeadersWidth = 62;
            dgvReservations.RowTemplate.Height = 40;
            dgvReservations.Size = new Size(1451, 429);
            dgvReservations.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 31);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(70, 36);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(220, 28);
            label5.TabIndex = 23;
            label5.Text = "List Reservations : ";
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrint);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(txtCurrentPage);
            Controls.Add(groupBox1);
            Controls.Add(btnNewReser);
            Controls.Add(txtNbReservs);
            Controls.Add(dgvReservations);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Margin = new Padding(4);
            Name = "ReservationForm";
            Size = new Size(1488, 639);
            Load += ReservationForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
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
        private Button btnSearch;
        private Label txtCurrentPage;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnNewReser;
        private Label txtNbReservs;
        private DataGridView dgvReservations;
        private PictureBox pictureBox2;
        private Label label5;
        private ComboBox txtAdherentCriteria;
        private Button rechercherBtn;
    }
}
