namespace ManageCinema.Admin
{
    partial class TicketUC
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
            this.btnSeeAllShowTimes = new System.Windows.Forms.Button();
            this.btnSeeShowTimesNotCreatedTicket = new System.Windows.Forms.Button();
            this.btnSeeAllTicketByShowTimes = new System.Windows.Forms.Button();
            this.btnSeeTicketSelledByShowTimes = new System.Windows.Forms.Button();
            this.btnDeleteTicketByShowTimes = new System.Windows.Forms.Button();
            this.btnAutoAddTicketByShowTimes = new System.Windows.Forms.Button();
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSeeAllShowTimes);
            this.panel1.Controls.Add(this.btnSeeShowTimesNotCreatedTicket);
            this.panel1.Controls.Add(this.btnSeeAllTicketByShowTimes);
            this.panel1.Controls.Add(this.btnSeeTicketSelledByShowTimes);
            this.panel1.Controls.Add(this.btnDeleteTicketByShowTimes);
            this.panel1.Controls.Add(this.btnAutoAddTicketByShowTimes);
            this.panel1.Controls.Add(this.lsvAllListShowTimes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 349);
            this.panel1.TabIndex = 0;
            // 
            // btnSeeAllShowTimes
            // 
            this.btnSeeAllShowTimes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeAllShowTimes.Location = new System.Drawing.Point(860, 233);
            this.btnSeeAllShowTimes.Name = "btnSeeAllShowTimes";
            this.btnSeeAllShowTimes.Size = new System.Drawing.Size(125, 73);
            this.btnSeeAllShowTimes.TabIndex = 6;
            this.btnSeeAllShowTimes.Text = "Xem Tất Cả Lịch Chiếu";
            this.btnSeeAllShowTimes.UseVisualStyleBackColor = true;
            this.btnSeeAllShowTimes.Click += new System.EventHandler(this.btnSeeAllShowTimes_Click);
            // 
            // btnSeeShowTimesNotCreatedTicket
            // 
            this.btnSeeShowTimesNotCreatedTicket.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeShowTimesNotCreatedTicket.Location = new System.Drawing.Point(689, 233);
            this.btnSeeShowTimesNotCreatedTicket.Name = "btnSeeShowTimesNotCreatedTicket";
            this.btnSeeShowTimesNotCreatedTicket.Size = new System.Drawing.Size(125, 73);
            this.btnSeeShowTimesNotCreatedTicket.TabIndex = 5;
            this.btnSeeShowTimesNotCreatedTicket.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            this.btnSeeShowTimesNotCreatedTicket.UseVisualStyleBackColor = true;
            this.btnSeeShowTimesNotCreatedTicket.Click += new System.EventHandler(this.btnSeeShowTimesNotCreatedTicket_Click);
            // 
            // btnSeeAllTicketByShowTimes
            // 
            this.btnSeeAllTicketByShowTimes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeAllTicketByShowTimes.Location = new System.Drawing.Point(860, 133);
            this.btnSeeAllTicketByShowTimes.Name = "btnSeeAllTicketByShowTimes";
            this.btnSeeAllTicketByShowTimes.Size = new System.Drawing.Size(125, 69);
            this.btnSeeAllTicketByShowTimes.TabIndex = 4;
            this.btnSeeAllTicketByShowTimes.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            this.btnSeeAllTicketByShowTimes.UseVisualStyleBackColor = true;
            this.btnSeeAllTicketByShowTimes.Click += new System.EventHandler(this.btnSeeAllTicketByShowTimes_Click);
            // 
            // btnSeeTicketSelledByShowTimes
            // 
            this.btnSeeTicketSelledByShowTimes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeTicketSelledByShowTimes.Location = new System.Drawing.Point(689, 133);
            this.btnSeeTicketSelledByShowTimes.Name = "btnSeeTicketSelledByShowTimes";
            this.btnSeeTicketSelledByShowTimes.Size = new System.Drawing.Size(125, 69);
            this.btnSeeTicketSelledByShowTimes.TabIndex = 3;
            this.btnSeeTicketSelledByShowTimes.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            this.btnSeeTicketSelledByShowTimes.UseVisualStyleBackColor = true;
            this.btnSeeTicketSelledByShowTimes.Click += new System.EventHandler(this.btnSeeTicketSelledByShowTimes_Click);
            // 
            // btnDeleteTicketByShowTimes
            // 
            this.btnDeleteTicketByShowTimes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTicketByShowTimes.Location = new System.Drawing.Point(860, 19);
            this.btnDeleteTicketByShowTimes.Name = "btnDeleteTicketByShowTimes";
            this.btnDeleteTicketByShowTimes.Size = new System.Drawing.Size(125, 78);
            this.btnDeleteTicketByShowTimes.TabIndex = 2;
            this.btnDeleteTicketByShowTimes.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnDeleteTicketByShowTimes.UseVisualStyleBackColor = true;
            this.btnDeleteTicketByShowTimes.Click += new System.EventHandler(this.btnDeleteTicketByShowTimes_Click);
            // 
            // btnAutoAddTicketByShowTimes
            // 
            this.btnAutoAddTicketByShowTimes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutoAddTicketByShowTimes.Location = new System.Drawing.Point(689, 19);
            this.btnAutoAddTicketByShowTimes.Name = "btnAutoAddTicketByShowTimes";
            this.btnAutoAddTicketByShowTimes.Size = new System.Drawing.Size(125, 78);
            this.btnAutoAddTicketByShowTimes.TabIndex = 1;
            this.btnAutoAddTicketByShowTimes.Text = "Tự Động Thêm Vé Theo Lịch Chiếu";
            this.btnAutoAddTicketByShowTimes.UseVisualStyleBackColor = true;
            this.btnAutoAddTicketByShowTimes.Click += new System.EventHandler(this.btnAutoAddTicketByShowTimes_Click);
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.HideSelection = true;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(0, 0);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(604, 349);
            this.lsvAllListShowTimes.TabIndex = 0;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            this.lsvAllListShowTimes.Click += new System.EventHandler(this.lsvAllListShowTimes_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Phòng Chiếu";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvTicket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 335);
            this.panel2.TabIndex = 1;
            // 
            // dtgvTicket
            // 
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTicket.Location = new System.Drawing.Point(0, 0);
            this.dtgvTicket.Name = "dtgvTicket";
            this.dtgvTicket.RowHeadersWidth = 51;
            this.dtgvTicket.RowTemplate.Height = 29;
            this.dtgvTicket.Size = new System.Drawing.Size(1050, 335);
            this.dtgvTicket.TabIndex = 0;
            // 
            // TicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TicketUC";
            this.Size = new System.Drawing.Size(1050, 684);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnSeeAllShowTimes;
        private Button btnSeeShowTimesNotCreatedTicket;
        private Button btnSeeAllTicketByShowTimes;
        private Button btnSeeTicketSelledByShowTimes;
        private Button btnDeleteTicketByShowTimes;
        private Button btnAutoAddTicketByShowTimes;
        private ListView lsvAllListShowTimes;
        private Panel panel2;
        private DataGridView dtgvTicket;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
