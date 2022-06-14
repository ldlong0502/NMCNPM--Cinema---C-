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
            this.ptrFormat3 = new System.Windows.Forms.PictureBox();
            this.ptrFormat2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrailer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnVoteStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label18 = new System.Windows.Forms.Label();
            this.ptrFormat1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMovie_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMovie)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFormat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFormat2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFormat1)).BeginInit();
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
            this.ptrMovie.Location = new System.Drawing.Point(38, 81);
            this.ptrMovie.Name = "ptrMovie";
            this.ptrMovie.Size = new System.Drawing.Size(304, 454);
            this.ptrMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrMovie.TabIndex = 0;
            this.ptrMovie.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.ptrFormat3);
            this.panel2.Controls.Add(this.ptrFormat2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.lblDirector);
            this.panel2.Controls.Add(this.lblActor);
            this.panel2.Controls.Add(this.lblGenre);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnTrailer);
            this.panel2.Controls.Add(this.btnVoteStar);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.ptrFormat1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMovie_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(383, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 618);
            this.panel2.TabIndex = 1;
            // 
            // ptrFormat3
            // 
            this.ptrFormat3.Image = global::ManageCinema.Properties.Resources._2D;
            this.ptrFormat3.Location = new System.Drawing.Point(210, 335);
            this.ptrFormat3.Name = "ptrFormat3";
            this.ptrFormat3.Size = new System.Drawing.Size(53, 46);
            this.ptrFormat3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrFormat3.TabIndex = 24;
            this.ptrFormat3.TabStop = false;
            // 
            // ptrFormat2
            // 
            this.ptrFormat2.Image = global::ManageCinema.Properties.Resources._2D;
            this.ptrFormat2.Location = new System.Drawing.Point(127, 335);
            this.ptrFormat2.Name = "ptrFormat2";
            this.ptrFormat2.Size = new System.Drawing.Size(53, 46);
            this.ptrFormat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrFormat2.TabIndex = 23;
            this.ptrFormat2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lblDescription);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 398);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(773, 96);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(10, 10);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(10, 10, 100, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(641, 96);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblDirector
            // 
            this.lblDirector.BackColor = System.Drawing.Color.White;
            this.lblDirector.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDirector.Location = new System.Drawing.Point(149, 264);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(305, 42);
            this.lblDirector.TabIndex = 21;
            this.lblDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActor
            // 
            this.lblActor.BackColor = System.Drawing.Color.White;
            this.lblActor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActor.Location = new System.Drawing.Point(149, 210);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(660, 42);
            this.lblActor.TabIndex = 20;
            this.lblActor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.Color.White;
            this.lblGenre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(149, 153);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(446, 42);
            this.lblGenre.TabIndex = 19;
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(149, 97);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(305, 42);
            this.lblTime.TabIndex = 18;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.Location = new System.Drawing.Point(859, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 43);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTrailer
            // 
            this.btnTrailer.BorderRadius = 20;
            this.btnTrailer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrailer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrailer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrailer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrailer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrailer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrailer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrailer.ForeColor = System.Drawing.Color.White;
            this.btnTrailer.Image = global::ManageCinema.Properties.Resources.showtime;
            this.btnTrailer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTrailer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTrailer.Location = new System.Drawing.Point(266, 550);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(343, 56);
            this.btnTrailer.TabIndex = 15;
            this.btnTrailer.Text = "LỊCH CHIẾU VÀ MUA VÉ";
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
            // ptrFormat1
            // 
            this.ptrFormat1.Image = global::ManageCinema.Properties.Resources._2D;
            this.ptrFormat1.Location = new System.Drawing.Point(45, 335);
            this.ptrFormat1.Name = "ptrFormat1";
            this.ptrFormat1.Size = new System.Drawing.Size(53, 46);
            this.ptrFormat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrFormat1.TabIndex = 11;
            this.ptrFormat1.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(1290, 618);
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
            ((System.ComponentModel.ISupportInitialize)(this.ptrFormat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFormat2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFormat1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox ptrMovie;
        private Panel panel2;
        private Label label1;
        private Label lblMovie_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label18;
        private Label lblDescription;
        private PictureBox ptrFormat1;
        private Guna.UI2.WinForms.Guna2GradientButton btnTrailer;
        private Guna.UI2.WinForms.Guna2RatingStar btnVoteStar;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblDirector;
        private Label lblActor;
        private Label lblGenre;
        private Label lblTime;
        private PictureBox ptrFormat3;
        private PictureBox ptrFormat2;
    }
}