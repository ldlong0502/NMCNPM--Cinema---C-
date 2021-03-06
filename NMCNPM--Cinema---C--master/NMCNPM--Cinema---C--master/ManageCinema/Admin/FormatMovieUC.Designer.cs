namespace ManageCinema.Admin
{
    partial class FormatMovieUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.lblDescripe = new System.Windows.Forms.Label();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.txtFormatID = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvFormatMovie = new System.Windows.Forms.DataGridView();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScreenName = new System.Windows.Forms.TextBox();
            this.cbxMovieID = new System.Windows.Forms.ComboBox();
            this.cbxScreenID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormatMovie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.txtFormatID);
            this.panel1.Controls.Add(this.lblGenreID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 292);
            this.panel1.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(640, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(533, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 35);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(414, 231);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(76, 35);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(305, 231);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(76, 35);
            this.btnSee.TabIndex = 14;
            this.btnSee.Text = "Xem";
            this.btnSee.UseVisualStyleBackColor = true;
            // 
            // lblDescripe
            // 
            this.lblDescripe.AutoSize = true;
            this.lblDescripe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescripe.Location = new System.Drawing.Point(6, 80);
            this.lblDescripe.Name = "lblDescripe";
            this.lblDescripe.Size = new System.Drawing.Size(78, 19);
            this.lblDescripe.TabIndex = 12;
            this.lblDescripe.Text = "Tên phim";
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreName.Location = new System.Drawing.Point(6, 36);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(75, 19);
            this.lblGenreName.TabIndex = 10;
            this.lblGenreName.Text = "Mã phim";
            // 
            // txtFormatID
            // 
            this.txtFormatID.Location = new System.Drawing.Point(414, 36);
            this.txtFormatID.Name = "txtFormatID";
            this.txtFormatID.Size = new System.Drawing.Size(302, 27);
            this.txtFormatID.TabIndex = 9;
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreID.Location = new System.Drawing.Point(281, 40);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(109, 19);
            this.lblGenreID.TabIndex = 8;
            this.lblGenreID.Text = "Mã định dạng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvFormatMovie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 684);
            this.panel2.TabIndex = 3;
            // 
            // dtgvFormatMovie
            // 
            this.dtgvFormatMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFormatMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFormatMovie.Location = new System.Drawing.Point(0, 0);
            this.dtgvFormatMovie.Name = "dtgvFormatMovie";
            this.dtgvFormatMovie.ReadOnly = true;
            this.dtgvFormatMovie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgvFormatMovie.RowHeadersWidth = 51;
            this.dtgvFormatMovie.RowTemplate.Height = 29;
            this.dtgvFormatMovie.Size = new System.Drawing.Size(1050, 684);
            this.dtgvFormatMovie.TabIndex = 0;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(115, 72);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(302, 27);
            this.txtMovieName.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMovieID);
            this.groupBox1.Controls.Add(this.lblGenreName);
            this.groupBox1.Controls.Add(this.lblDescripe);
            this.groupBox1.Controls.Add(this.txtMovieName);
            this.groupBox1.Location = new System.Drawing.Point(17, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 125);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxScreenID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtScreenName);
            this.groupBox2.Location = new System.Drawing.Point(557, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 125);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màn hình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã mà hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên màn hình";
            // 
            // txtScreenName
            // 
            this.txtScreenName.Location = new System.Drawing.Point(128, 72);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.ReadOnly = true;
            this.txtScreenName.Size = new System.Drawing.Size(300, 27);
            this.txtScreenName.TabIndex = 18;
            // 
            // cbxMovieID
            // 
            this.cbxMovieID.FormattingEnabled = true;
            this.cbxMovieID.Location = new System.Drawing.Point(115, 32);
            this.cbxMovieID.Name = "cbxMovieID";
            this.cbxMovieID.Size = new System.Drawing.Size(299, 28);
            this.cbxMovieID.TabIndex = 19;
            // 
            // cbxScreenID
            // 
            this.cbxScreenID.FormattingEnabled = true;
            this.cbxScreenID.Location = new System.Drawing.Point(128, 32);
            this.cbxScreenID.Name = "cbxScreenID";
            this.cbxScreenID.Size = new System.Drawing.Size(299, 28);
            this.cbxScreenID.TabIndex = 20;
            // 
            // FormatMovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormatMovieUC";
            this.Size = new System.Drawing.Size(1050, 684);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormatMovie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private ComboBox cbxScreenID;
        private Label label1;
        private Label label2;
        private TextBox txtScreenName;
        private GroupBox groupBox1;
        private ComboBox cbxMovieID;
        private Label lblGenreName;
        private Label lblDescripe;
        private TextBox txtMovieName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnSee;
        private TextBox txtFormatID;
        private Label lblGenreID;
        private Panel panel2;
        private DataGridView dtgvFormatMovie;
    }
}
