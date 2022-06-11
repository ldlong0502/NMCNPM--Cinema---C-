namespace ManageCinema.Admin
{
    partial class DataUC
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTicket = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowTimes = new Guna.UI2.WinForms.Guna2Button();
            this.btnFormatMovie = new Guna.UI2.WinForms.Guna2Button();
            this.btnMovie = new Guna.UI2.WinForms.Guna2Button();
            this.btnType = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom_Cinema = new Guna.UI2.WinForms.Guna2Button();
            this.btnTypeScreen = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 684);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.btnTicket);
            this.panel3.Controls.Add(this.btnShowTimes);
            this.panel3.Controls.Add(this.btnFormatMovie);
            this.panel3.Controls.Add(this.btnMovie);
            this.panel3.Controls.Add(this.btnType);
            this.panel3.Controls.Add(this.btnRoom_Cinema);
            this.panel3.Controls.Add(this.btnTypeScreen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 559);
            this.panel3.TabIndex = 3;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnTicket.BorderColor = System.Drawing.Color.White;
            this.btnTicket.BorderRadius = 2;
            this.btnTicket.BorderThickness = 1;
            this.btnTicket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTicket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTicket.FillColor = System.Drawing.Color.Transparent;
            this.btnTicket.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTicket.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTicket.Image = global::ManageCinema.Properties.Resources.ticket;
            this.btnTicket.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTicket.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTicket.Location = new System.Drawing.Point(0, 336);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(201, 56);
            this.btnTicket.TabIndex = 6;
            this.btnTicket.Text = "Vé";
            this.btnTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnShowTimes
            // 
            this.btnShowTimes.BackColor = System.Drawing.Color.Transparent;
            this.btnShowTimes.BorderColor = System.Drawing.Color.White;
            this.btnShowTimes.BorderRadius = 2;
            this.btnShowTimes.BorderThickness = 1;
            this.btnShowTimes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowTimes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowTimes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowTimes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowTimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowTimes.FillColor = System.Drawing.Color.Transparent;
            this.btnShowTimes.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowTimes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowTimes.Image = global::ManageCinema.Properties.Resources.showtime;
            this.btnShowTimes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnShowTimes.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowTimes.Location = new System.Drawing.Point(0, 280);
            this.btnShowTimes.Name = "btnShowTimes";
            this.btnShowTimes.Size = new System.Drawing.Size(201, 56);
            this.btnShowTimes.TabIndex = 5;
            this.btnShowTimes.Text = "Lịch Chiếu";
            this.btnShowTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowTimes.Click += new System.EventHandler(this.btnShowTimes_Click);
            // 
            // btnFormatMovie
            // 
            this.btnFormatMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnFormatMovie.BorderColor = System.Drawing.Color.White;
            this.btnFormatMovie.BorderRadius = 2;
            this.btnFormatMovie.BorderThickness = 1;
            this.btnFormatMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFormatMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFormatMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFormatMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFormatMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormatMovie.FillColor = System.Drawing.Color.Transparent;
            this.btnFormatMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFormatMovie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFormatMovie.Image = global::ManageCinema.Properties.Resources.format;
            this.btnFormatMovie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnFormatMovie.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFormatMovie.Location = new System.Drawing.Point(0, 224);
            this.btnFormatMovie.Name = "btnFormatMovie";
            this.btnFormatMovie.Size = new System.Drawing.Size(201, 56);
            this.btnFormatMovie.TabIndex = 4;
            this.btnFormatMovie.Text = "Định Dạng";
            this.btnFormatMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFormatMovie.Click += new System.EventHandler(this.btnFormatMovie_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnMovie.BorderColor = System.Drawing.Color.White;
            this.btnMovie.BorderRadius = 2;
            this.btnMovie.BorderThickness = 1;
            this.btnMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovie.FillColor = System.Drawing.Color.Transparent;
            this.btnMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMovie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMovie.Image = global::ManageCinema.Properties.Resources.movie;
            this.btnMovie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMovie.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMovie.Location = new System.Drawing.Point(0, 168);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(201, 56);
            this.btnMovie.TabIndex = 3;
            this.btnMovie.Text = "Phim";
            this.btnMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.Transparent;
            this.btnType.BorderColor = System.Drawing.Color.White;
            this.btnType.BorderRadius = 2;
            this.btnType.BorderThickness = 1;
            this.btnType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnType.FillColor = System.Drawing.Color.Transparent;
            this.btnType.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnType.Image = global::ManageCinema.Properties.Resources.type;
            this.btnType.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnType.ImageSize = new System.Drawing.Size(30, 30);
            this.btnType.Location = new System.Drawing.Point(0, 112);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(201, 56);
            this.btnType.TabIndex = 2;
            this.btnType.Text = "Thể Loại";
            this.btnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnRoom_Cinema
            // 
            this.btnRoom_Cinema.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom_Cinema.BorderColor = System.Drawing.Color.White;
            this.btnRoom_Cinema.BorderRadius = 2;
            this.btnRoom_Cinema.BorderThickness = 1;
            this.btnRoom_Cinema.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom_Cinema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom_Cinema.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoom_Cinema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoom_Cinema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoom_Cinema.FillColor = System.Drawing.Color.Transparent;
            this.btnRoom_Cinema.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoom_Cinema.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoom_Cinema.Image = global::ManageCinema.Properties.Resources.room;
            this.btnRoom_Cinema.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRoom_Cinema.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRoom_Cinema.Location = new System.Drawing.Point(0, 56);
            this.btnRoom_Cinema.Name = "btnRoom_Cinema";
            this.btnRoom_Cinema.Size = new System.Drawing.Size(201, 56);
            this.btnRoom_Cinema.TabIndex = 1;
            this.btnRoom_Cinema.Text = "Phòng Chiếu";
            this.btnRoom_Cinema.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoom_Cinema.Click += new System.EventHandler(this.btnRoom_Cinema_Click);
            // 
            // btnTypeScreen
            // 
            this.btnTypeScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnTypeScreen.BorderColor = System.Drawing.Color.White;
            this.btnTypeScreen.BorderRadius = 2;
            this.btnTypeScreen.BorderThickness = 1;
            this.btnTypeScreen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTypeScreen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTypeScreen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTypeScreen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTypeScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTypeScreen.FillColor = System.Drawing.Color.Transparent;
            this.btnTypeScreen.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTypeScreen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTypeScreen.Image = global::ManageCinema.Properties.Resources.screen;
            this.btnTypeScreen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTypeScreen.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTypeScreen.Location = new System.Drawing.Point(0, 0);
            this.btnTypeScreen.Name = "btnTypeScreen";
            this.btnTypeScreen.Size = new System.Drawing.Size(201, 56);
            this.btnTypeScreen.TabIndex = 0;
            this.btnTypeScreen.Text = "Loại Màn Hình";
            this.btnTypeScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTypeScreen.Click += new System.EventHandler(this.btnTypeScreen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 125);
            this.panel2.TabIndex = 2;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.pnlData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(201, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1050, 684);
            this.pnlData.TabIndex = 1;
            this.pnlData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlData_Paint);
            // 
            // DataUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.panel1);
            this.Name = "DataUC";
            this.Size = new System.Drawing.Size(1251, 684);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTypeScreen;
        private Panel pnlData;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnTicket;
        private Guna.UI2.WinForms.Guna2Button btnShowTimes;
        private Guna.UI2.WinForms.Guna2Button btnFormatMovie;
        private Guna.UI2.WinForms.Guna2Button btnMovie;
        private Guna.UI2.WinForms.Guna2Button btnType;
        private Guna.UI2.WinForms.Guna2Button btnRoom_Cinema;
    }
}
