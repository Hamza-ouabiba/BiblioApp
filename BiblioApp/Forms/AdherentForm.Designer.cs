
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            btnNewReser = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdherent).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 26);
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
            label5.Location = new Point(59, 30);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 23);
            label5.TabIndex = 3;
            label5.Text = "Liste adhérents";
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
            dgvAdherent.Location = new Point(18, 124);
            dgvAdherent.Margin = new Padding(2);
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
            dgvAdherent.Size = new Size(1387, 343);
            dgvAdherent.TabIndex = 5;
            // 
            // txtNbAdh
            // 
            txtNbAdh.AutoSize = true;
            txtNbAdh.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNbAdh.ForeColor = Color.Maroon;
            txtNbAdh.Location = new Point(218, 30);
            txtNbAdh.Margin = new Padding(2, 0, 2, 0);
            txtNbAdh.Name = "txtNbAdh";
            txtNbAdh.Size = new Size(20, 23);
            txtNbAdh.TabIndex = 6;
            txtNbAdh.Text = "_";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(49, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 9;
            label1.Text = "Adherent";
            // 
            // txtAdherentCriteria
            // 
            txtAdherentCriteria.BackColor = Color.White;
            txtAdherentCriteria.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdherentCriteria.Location = new Point(49, 25);
            txtAdherentCriteria.Margin = new Padding(2);
            txtAdherentCriteria.Name = "txtAdherentCriteria";
            txtAdherentCriteria.PlaceholderText = "Chercher sur un adherent";
            txtAdherentCriteria.Size = new Size(413, 28);
            txtAdherentCriteria.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtAdherentCriteria);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(248, 25);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(552, 69);
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
            btnSearch.Location = new Point(487, 24);
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
            txtCurrentPage.Location = new Point(166, 66);
            txtCurrentPage.Margin = new Padding(2, 0, 2, 0);
            txtCurrentPage.Name = "txtCurrentPage";
            txtCurrentPage.Size = new Size(15, 20);
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
            btnCharger.Location = new Point(1288, 43);
            btnCharger.Margin = new Padding(2);
            btnCharger.Name = "btnCharger";
            btnCharger.Size = new Size(93, 29);
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
            btnLast.Location = new Point(115, 66);
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
            btnNext.Location = new Point(75, 66);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(42, 28);
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
            btnPrevious.Location = new Point(51, 69);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(26, 22);
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
            btnFirst.Location = new Point(9, 66);
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
            btnNewReser.Location = new Point(1054, 40);
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
            Controls.Add(btnCharger);
            Controls.Add(txtCurrentPage);
            Controls.Add(txtNbAdh);
            Controls.Add(dgvAdherent);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "AdherentForm";
            Size = new Size(1416, 511);
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
        private Button btnNewReser;
    }
}
