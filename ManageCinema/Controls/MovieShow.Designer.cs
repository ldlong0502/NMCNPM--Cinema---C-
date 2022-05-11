namespace ManageCinema.Controls
{
    partial class MovieShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieShow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptrMovie = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuyTicket = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTrailer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnVoteStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label18 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.ptrStyle = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDirector = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblActor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStyle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTimeStart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMovie_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMovie)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrStyle)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.ptrMovie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 618);
            this.panel1.TabIndex = 0;
            // 
            // ptrMovie
            // 
            this.ptrMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptrMovie.Image = global::ManageCinema.Properties.Resources._1;
            this.ptrMovie.Location = new System.Drawing.Point(40, 107);
            this.ptrMovie.Name = "ptrMovie";
            this.ptrMovie.Size = new System.Drawing.Size(299, 428);
            this.ptrMovie.TabIndex = 0;
            this.ptrMovie.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnBuyTicket);
            this.panel2.Controls.Add(this.btnTrailer);
            this.panel2.Controls.Add(this.btnVoteStar);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Controls.Add(this.ptrStyle);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMovie_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(383, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 618);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(660, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 43);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.BorderRadius = 20;
            this.btnBuyTicket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuyTicket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuyTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuyTicket.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuyTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuyTicket.FillColor = System.Drawing.Color.Cyan;
            this.btnBuyTicket.FillColor2 = System.Drawing.Color.DarkGray;
            this.btnBuyTicket.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuyTicket.ForeColor = System.Drawing.Color.White;
            this.btnBuyTicket.Image = global::ManageCinema.Properties.Resources._4533901;
            this.btnBuyTicket.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBuyTicket.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBuyTicket.Location = new System.Drawing.Point(390, 550);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(172, 56);
            this.btnBuyTicket.TabIndex = 16;
            this.btnBuyTicket.Text = "MUA VÉ";
            this.btnBuyTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTrailer
            // 
            this.btnTrailer.BorderRadius = 20;
            this.btnTrailer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrailer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrailer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrailer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrailer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrailer.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrailer.ForeColor = System.Drawing.Color.White;
            this.btnTrailer.Image = global::ManageCinema.Properties.Resources.youtube_play;
            this.btnTrailer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTrailer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnTrailer.Location = new System.Drawing.Point(175, 550);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(172, 56);
            this.btnTrailer.TabIndex = 15;
            this.btnTrailer.Text = "TRAILER";
            this.btnTrailer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // btnVoteStar
            // 
            this.btnVoteStar.Location = new System.Drawing.Point(149, 500);
            this.btnVoteStar.Name = "btnVoteStar";
            this.btnVoteStar.ReadOnly = true;
            this.btnVoteStar.Size = new System.Drawing.Size(150, 35);
            this.btnVoteStar.TabIndex = 14;
            this.btnVoteStar.Value = 5F;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Snow;
            this.label18.Location = new System.Drawing.Point(36, 514);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "Đánh giá: ";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(15, 396);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(693, 101);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // ptrStyle
            // 
            this.ptrStyle.Image = global::ManageCinema.Properties.Resources._2d;
            this.ptrStyle.Location = new System.Drawing.Point(45, 335);
            this.ptrStyle.Name = "ptrStyle";
            this.ptrStyle.Size = new System.Drawing.Size(53, 46);
            this.ptrStyle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrStyle.TabIndex = 11;
            this.ptrStyle.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel6.Controls.Add(this.lblDirector);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Location = new System.Drawing.Point(149, 264);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 42);
            this.panel6.TabIndex = 10;
            // 
            // lblDirector
            // 
            this.lblDirector.BackColor = System.Drawing.Color.Transparent;
            this.lblDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirector.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDirector.Location = new System.Drawing.Point(0, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(198, 42);
            this.lblDirector.TabIndex = 7;
            this.lblDirector.Text = "Tokuda";
            this.lblDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 42);
            this.label15.TabIndex = 6;
            this.label15.Text = "Từ 14-05-2020";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 42);
            this.label16.TabIndex = 5;
            this.label16.Text = "Từ 14-05-2020";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.lblActor);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(149, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 42);
            this.panel5.TabIndex = 9;
            // 
            // lblActor
            // 
            this.lblActor.BackColor = System.Drawing.Color.Transparent;
            this.lblActor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActor.Location = new System.Drawing.Point(0, 0);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(376, 42);
            this.lblActor.TabIndex = 7;
            this.lblActor.Text = "Từ 14-05-2020";
            this.lblActor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(376, 42);
            this.label12.TabIndex = 6;
            this.label12.Text = "Từ 14-05-2020";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(376, 42);
            this.label13.TabIndex = 5;
            this.label13.Text = "Từ 14-05-2020";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Controls.Add(this.lblStyle);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(149, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 42);
            this.panel4.TabIndex = 8;
            // 
            // lblStyle
            // 
            this.lblStyle.BackColor = System.Drawing.Color.Transparent;
            this.lblStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStyle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStyle.Location = new System.Drawing.Point(0, 0);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(198, 42);
            this.lblStyle.TabIndex = 7;
            this.lblStyle.Text = "Hoạt Hình";
            this.lblStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 42);
            this.label9.TabIndex = 6;
            this.label9.Text = "Từ 14-05-2020";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 42);
            this.label10.TabIndex = 5;
            this.label10.Text = "Từ 14-05-2020";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.lbTimeStart);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(149, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 42);
            this.panel3.TabIndex = 6;
            // 
            // lbTimeStart
            // 
            this.lbTimeStart.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTimeStart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTimeStart.Location = new System.Drawing.Point(0, 0);
            this.lbTimeStart.Name = "lbTimeStart";
            this.lbTimeStart.Size = new System.Drawing.Size(198, 42);
            this.lbTimeStart.TabIndex = 7;
            this.lbTimeStart.Text = "Từ 14-05-2020";
            this.lbTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 42);
            this.label6.TabIndex = 6;
            this.label6.Text = "Từ 14-05-2020";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Từ 14-05-2020";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(36, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đạo diễn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(32, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diễn viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(32, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thể loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khởi chiếu: ";
            // 
            // lblMovie_name
            // 
            this.lblMovie_name.AutoSize = true;
            this.lblMovie_name.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMovie_name.ForeColor = System.Drawing.Color.White;
            this.lblMovie_name.Location = new System.Drawing.Point(32, 28);
            this.lblMovie_name.Name = "lblMovie_name";
            this.lblMovie_name.Size = new System.Drawing.Size(213, 40);
            this.lblMovie_name.TabIndex = 0;
            this.lblMovie_name.Text = "DORAEMON";
            // 
            // MovieShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1103, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoiveShow";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrStyle)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox ptrMovie;
        private Panel panel2;
        private Label label1;
        private Label lblMovie_name;
        private Panel panel3;
        private Label lbTimeStart;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Label lblStyle;
        private Label label9;
        private Label label10;
        private Panel panel6;
        private Label lblDirector;
        private Label label15;
        private Label label16;
        private Panel panel5;
        private Label lblActor;
        private Label label12;
        private Label label13;
        private Label label18;
        private Label lblDescription;
        private PictureBox ptrStyle;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuyTicket;
        private Guna.UI2.WinForms.Guna2GradientButton btnTrailer;
        private Guna.UI2.WinForms.Guna2RatingStar btnVoteStar;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}