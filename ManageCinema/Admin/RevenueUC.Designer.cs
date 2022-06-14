namespace ManageCinema.Admin
{
    partial class RevenueUC
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
            this.cbxSelectMovie = new System.Windows.Forms.ComboBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAllRenevue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSelectMovie
            // 
            this.cbxSelectMovie.FormattingEnabled = true;
            this.cbxSelectMovie.Location = new System.Drawing.Point(246, 11);
            this.cbxSelectMovie.Name = "cbxSelectMovie";
            this.cbxSelectMovie.Size = new System.Drawing.Size(299, 28);
            this.cbxSelectMovie.TabIndex = 21;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGenreName.Location = new System.Drawing.Point(85, 14);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(137, 28);
            this.lblGenreName.TabIndex = 20;
            this.lblGenreName.Text = "Chọn Phim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(85, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(747, 157);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(511, 68);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(192, 32);
            this.dtpToDate.TabIndex = 24;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(142, 68);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(192, 32);
            this.dtpFromDate.TabIndex = 23;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(392, 73);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(113, 24);
            this.lblTo.TabIndex = 22;
            this.lblTo.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày:";
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRevenue.Location = new System.Drawing.Point(85, 259);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.RowHeadersWidth = 51;
            this.dtgvRevenue.RowTemplate.Height = 29;
            this.dtgvRevenue.Size = new System.Drawing.Size(747, 399);
            this.dtgvRevenue.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Controls.Add(this.btnStatistic);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(900, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(290, 320);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnReport
            // 
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Location = new System.Drawing.Point(86, 190);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(128, 49);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            this.btnStatistic.ForeColor = System.Drawing.Color.Black;
            this.btnStatistic.Location = new System.Drawing.Point(86, 60);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(128, 49);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(900, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tổng Doanh Thu";
            // 
            // txtAllRenevue
            // 
            this.txtAllRenevue.Location = new System.Drawing.Point(900, 629);
            this.txtAllRenevue.Name = "txtAllRenevue";
            this.txtAllRenevue.Size = new System.Drawing.Size(217, 27);
            this.txtAllRenevue.TabIndex = 27;
            // 
            // RevenueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.txtAllRenevue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgvRevenue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxSelectMovie);
            this.Controls.Add(this.lblGenreName);
            this.Name = "RevenueUC";
            this.Size = new System.Drawing.Size(1251, 684);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxSelectMovie;
        private Label lblGenreName;
        private GroupBox groupBox1;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Label lblTo;
        private Label label2;
        private DataGridView dtgvRevenue;
        private GroupBox groupBox2;
        private Button btnReport;
        private Button btnStatistic;
        private Label label3;
        private TextBox txtAllRenevue;
    }
}
