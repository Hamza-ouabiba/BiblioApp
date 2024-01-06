
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            dgvAdherent = new DataGridView();
            txtNbAdh = new Label();
            label1 = new Label();
            txtAdherentCriteria = new TextBox();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtCurrentPage = new Label();
            btnCharger = new Button();
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnNewAdh = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdherent).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 32);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(74, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 3;
            label5.Text = "Liste adhérents";
            // 
            // dgvAdherent
            // 
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 0, 192);
            dgvAdherent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvAdherent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdherent.BackgroundColor = SystemColors.ButtonFace;
            dgvAdherent.BorderStyle = BorderStyle.None;
            dgvAdherent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAdherent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Maroon;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvAdherent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvAdherent.ColumnHeadersHeight = 33;
            dgvAdherent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvAdherent.DefaultCellStyle = dataGridViewCellStyle7;
            dgvAdherent.EnableHeadersVisualStyles = false;
            dgvAdherent.Location = new Point(22, 155);
            dgvAdherent.Margin = new Padding(2);
            dgvAdherent.Name = "dgvAdherent";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Maroon;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvAdherent.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvAdherent.RowHeadersWidth = 62;
            dgvAdherent.RowTemplate.Height = 40;
            dgvAdherent.Size = new Size(1734, 429);
            dgvAdherent.TabIndex = 5;
            dgvAdherent.CellContentClick += dgvAdherent_CellContentClick;
            // 
            // txtNbAdh
            // 
            txtNbAdh.AutoSize = true;
            txtNbAdh.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbAdh.ForeColor = Color.Maroon;
            txtNbAdh.Location = new Point(272, 38);
            txtNbAdh.Margin = new Padding(2, 0, 2, 0);
            txtNbAdh.Name = "txtNbAdh";
            txtNbAdh.Size = new Size(24, 28);
            txtNbAdh.TabIndex = 6;
            txtNbAdh.Text = "_";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(61, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 9;
            label1.Text = "Adherent";
            // 
            // txtAdherentCriteria
            // 
            txtAdherentCriteria.BackColor = Color.White;
            txtAdherentCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdherentCriteria.Location = new Point(61, 31);
            txtAdherentCriteria.Margin = new Padding(2);
            txtAdherentCriteria.Name = "txtAdherentCriteria";
            txtAdherentCriteria.PlaceholderText = "Chercher sur un adherent";
            txtAdherentCriteria.Size = new Size(515, 32);
            txtAdherentCriteria.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtAdherentCriteria);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(310, 31);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(690, 86);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
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
            btnSearch.Location = new Point(609, 30);
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
            txtCurrentPage.Location = new Point(208, 82);
            txtCurrentPage.Margin = new Padding(2, 0, 2, 0);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(19, 25);
            txtCurrentPage.TabIndex = 21;
            txtCurrentPage.Text = "_";
            // 
            // btnCharger
            // 
            btnCharger.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCharger.BackColor = Color.LightCyan;
            btnCharger.Cursor = Cursors.Hand;
            btnCharger.FlatAppearance.BorderSize = 0;
            btnCharger.FlatStyle = FlatStyle.Flat;
            btnCharger.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCharger.ImageAlign = ContentAlignment.MiddleLeft;
            btnCharger.Location = new Point(1456, 59);
            btnCharger.Margin = new Padding(2);
            btnCharger.Name = "btnCharger";
            btnCharger.Size = new Size(116, 36);
            btnCharger.TabIndex = 22;
            btnCharger.Text = "Charger";
            btnCharger.TextAlign = ContentAlignment.MiddleRight;
            btnCharger.UseVisualStyleBackColor = false;
            btnCharger.Click += btnCharger_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = SystemColors.ButtonFace;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.Location = new Point(144, 82);
            btnLast.Margin = new Padding(2);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(48, 35);
            btnLast.TabIndex = 39;
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
            btnNext.Location = new Point(94, 82);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(52, 35);
            btnNext.TabIndex = 38;
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
            btnPrevious.Location = new Point(64, 86);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(32, 28);
            btnPrevious.TabIndex = 37;
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
            btnFirst.Location = new Point(11, 82);
            btnFirst.Margin = new Padding(2);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(48, 35);
            btnFirst.TabIndex = 36;
            btnFirst.TextAlign = ContentAlignment.MiddleRight;
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnNewAdh
            // 
            btnNewAdh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewAdh.BackColor = Color.DeepSkyBlue;
            btnNewAdh.Cursor = Cursors.Hand;
            btnNewAdh.FlatAppearance.BorderSize = 0;
            btnNewAdh.FlatStyle = FlatStyle.Flat;
            btnNewAdh.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewAdh.Image = (Image)resources.GetObject("btnNewAdh.Image");
            btnNewAdh.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewAdh.Location = new Point(1171, 54);
            btnNewAdh.Margin = new Padding(2);
            btnNewAdh.Name = "btnNewAdh";
            btnNewAdh.Size = new Size(259, 44);
            btnNewAdh.TabIndex = 40;
            btnNewAdh.Text = "Nouveau adhérent";
            btnNewAdh.TextAlign = ContentAlignment.MiddleRight;
            btnNewAdh.UseVisualStyleBackColor = false;
            btnNewAdh.Click += btnNewAdh_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.LightCyan;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(1601, 61);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(116, 36);
            btnExport.TabIndex = 41;
            btnExport.Text = "Exporter";
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // AdherentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExport);
            Controls.Add(btnNewAdh);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnCharger);
            Controls.Add(txtCurrentPage);
            Controls.Add(txtNbAdh);
            Controls.Add(dgvAdherent);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "AdherentForm";
            Size = new Size(1770, 639);
            Load += AdherentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdherent).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAdherent;
        private System.Windows.Forms.Label txtNbAdh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdherentCriteria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label txtCurrentPage;
        private System.Windows.Forms.Button btnCharger;
        private Button btnLast;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnNewAdh;
        private Button btnExport;
    }
}
