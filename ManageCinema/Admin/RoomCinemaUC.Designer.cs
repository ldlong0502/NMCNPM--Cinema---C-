namespace ManageCinema.Admin
{
    partial class RoomCinemaUC
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtSeatPerRow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtNumRows = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxScreen = new System.Windows.Forms.ComboBox();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvRoom = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 384);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(665, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 35);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(558, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 35);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Location = new System.Drawing.Point(439, 330);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(76, 35);
            this.btnInsert.TabIndex = 47;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSee
            // 
            this.btnSee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSee.Location = new System.Drawing.Point(330, 330);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(76, 35);
            this.btnSee.TabIndex = 46;
            this.btnSee.Text = "Xem";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDirector);
            this.groupBox2.Controls.Add(this.txtSeat);
            this.groupBox2.Controls.Add(this.txtSeatPerRow);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Controls.Add(this.txtNumRows);
            this.groupBox2.Location = new System.Drawing.Point(585, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 280);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chỗ ngồi";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDirector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirector.Location = new System.Drawing.Point(69, 51);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(94, 19);
            this.lblDirector.TabIndex = 32;
            this.lblDirector.Text = "Số chỗ ngồi";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(215, 47);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(158, 27);
            this.txtSeat.TabIndex = 33;
            // 
            // txtSeatPerRow
            // 
            this.txtSeatPerRow.Location = new System.Drawing.Point(215, 135);
            this.txtSeatPerRow.Name = "txtSeatPerRow";
            this.txtSeatPerRow.Size = new System.Drawing.Size(158, 27);
            this.txtSeatPerRow.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(69, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Số hàng ghế";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYear.Location = new System.Drawing.Point(69, 139);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(112, 19);
            this.lblYear.TabIndex = 38;
            this.lblYear.Text = "Ghế mỗi hàng";
            // 
            // txtNumRows
            // 
            this.txtNumRows.Location = new System.Drawing.Point(215, 93);
            this.txtNumRows.Name = "txtNumRows";
            this.txtNumRows.Size = new System.Drawing.Size(158, 27);
            this.txtNumRows.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxScreen);
            this.groupBox1.Controls.Add(this.lblMovieLength);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNation);
            this.groupBox1.Controls.Add(this.txtRoomName);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 280);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Phòng";
            // 
            // cbxScreen
            // 
            this.cbxScreen.FormattingEnabled = true;
            this.cbxScreen.Location = new System.Drawing.Point(207, 139);
            this.cbxScreen.Name = "cbxScreen";
            this.cbxScreen.Size = new System.Drawing.Size(158, 28);
            this.cbxScreen.TabIndex = 44;
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMovieLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovieLength.Location = new System.Drawing.Point(81, 55);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(82, 19);
            this.lblMovieLength.TabIndex = 26;
            this.lblMovieLength.Text = "Mã phòng";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(207, 51);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(158, 27);
            this.txtRoomID.TabIndex = 27;
            this.txtRoomID.TextChanged += new System.EventHandler(this.txtRoomID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(81, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Màn hình";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNation.Location = new System.Drawing.Point(81, 191);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(87, 19);
            this.lblNation.TabIndex = 30;
            this.lblNation.Text = "Tình trạng";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(207, 97);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(158, 27);
            this.txtRoomName.TabIndex = 41;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(207, 187);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(158, 27);
            this.txtStatus.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(81, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên phòng";
            // 
            // dtgvRoom
            // 
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvRoom.Location = new System.Drawing.Point(0, 384);
            this.dtgvRoom.Name = "dtgvRoom";
            this.dtgvRoom.RowHeadersWidth = 51;
            this.dtgvRoom.RowTemplate.Height = 29;
            this.dtgvRoom.Size = new System.Drawing.Size(1050, 300);
            this.dtgvRoom.TabIndex = 1;
            // 
            // RoomCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvRoom);
            this.Controls.Add(this.panel1);
            this.Name = "RoomCinema";
            this.Size = new System.Drawing.Size(1050, 684);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private Label lblDirector;
        private TextBox txtSeat;
        private TextBox txtSeatPerRow;
        private Label label9;
        private Label lblYear;
        private TextBox txtNumRows;
        private GroupBox groupBox1;
        private ComboBox cbxScreen;
        private Label lblMovieLength;
        private TextBox txtRoomID;
        private Label label1;
        private Label lblNation;
        private TextBox txtRoomName;
        private TextBox txtStatus;
        private Label label2;
        private DataGridView dtgvRoom;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnSee;
    }
}
