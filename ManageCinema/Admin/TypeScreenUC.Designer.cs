namespace ManageCinema.Admin
{
    partial class TypeScreenUC
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
            this.txtTypeScreenName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.txtTypeScreenID = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.dtgvTypeScreen = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTypeScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.txtTypeScreenName);
            this.panel1.Controls.Add(this.lblGenreName);
            this.panel1.Controls.Add(this.txtTypeScreenID);
            this.panel1.Controls.Add(this.lblGenreID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 292);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(640, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(533, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 35);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(414, 231);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(76, 35);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(305, 231);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(76, 35);
            this.btnSee.TabIndex = 14;
            this.btnSee.Text = "Xem";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // txtTypeScreenName
            // 
            this.txtTypeScreenName.Location = new System.Drawing.Point(438, 116);
            this.txtTypeScreenName.Name = "txtTypeScreenName";
            this.txtTypeScreenName.Size = new System.Drawing.Size(302, 27);
            this.txtTypeScreenName.TabIndex = 11;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreName.Location = new System.Drawing.Point(267, 124);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(126, 21);
            this.lblGenreName.TabIndex = 10;
            this.lblGenreName.Text = "Tên màn hình";
            // 
            // txtTypeScreenID
            // 
            this.txtTypeScreenID.Location = new System.Drawing.Point(438, 72);
            this.txtTypeScreenID.Name = "txtTypeScreenID";
            this.txtTypeScreenID.Size = new System.Drawing.Size(302, 27);
            this.txtTypeScreenID.TabIndex = 9;
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreID.Location = new System.Drawing.Point(267, 76);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(156, 21);
            this.lblGenreID.TabIndex = 8;
            this.lblGenreID.Text = "Mã loại màn hình";
            // 
            // dtgvTypeScreen
            // 
            this.dtgvTypeScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTypeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTypeScreen.Location = new System.Drawing.Point(0, 292);
            this.dtgvTypeScreen.Name = "dtgvTypeScreen";
            this.dtgvTypeScreen.RowHeadersWidth = 51;
            this.dtgvTypeScreen.RowTemplate.Height = 29;
            this.dtgvTypeScreen.Size = new System.Drawing.Size(1050, 392);
            this.dtgvTypeScreen.TabIndex = 3;
            // 
            // TypeScreenUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvTypeScreen);
            this.Controls.Add(this.panel1);
            this.Name = "TypeScreenUC";
            this.Size = new System.Drawing.Size(1050, 684);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTypeScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnSee;
        private TextBox txtTypeScreenName;
        private Label lblGenreName;
        private TextBox txtTypeScreenID;
        private Label lblGenreID;
        private DataGridView dtgvTypeScreen;
    }
}
