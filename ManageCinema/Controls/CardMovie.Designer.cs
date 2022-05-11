namespace ManageCinema.Controls
{
    partial class CardMovie
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
            this.ptrMovie = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMovie_name = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMovie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptrMovie
            // 
            this.ptrMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptrMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptrMovie.Image = global::ManageCinema.Properties.Resources._1;
            this.ptrMovie.Location = new System.Drawing.Point(0, 0);
            this.ptrMovie.Name = "ptrMovie";
            this.ptrMovie.Size = new System.Drawing.Size(253, 233);
            this.ptrMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrMovie.TabIndex = 0;
            this.ptrMovie.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMovie_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 86);
            this.panel1.TabIndex = 3;
            // 
            // btnMovie_name
            // 
            this.btnMovie_name.BorderColor = System.Drawing.Color.White;
            this.btnMovie_name.BorderThickness = 2;
            this.btnMovie_name.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie_name.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovie_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMovie_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMovie_name.FillColor = System.Drawing.Color.Transparent;
            this.btnMovie_name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMovie_name.ForeColor = System.Drawing.Color.White;
            this.btnMovie_name.Location = new System.Drawing.Point(0, 0);
            this.btnMovie_name.Name = "btnMovie_name";
            this.btnMovie_name.Size = new System.Drawing.Size(253, 86);
            this.btnMovie_name.TabIndex = 0;
            this.btnMovie_name.Click += new System.EventHandler(this.btnMovie_name_Click);
            // 
            // CardMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptrMovie);
            this.Name = "CardMovie";
            this.Size = new System.Drawing.Size(253, 319);
            ((System.ComponentModel.ISupportInitialize)(this.ptrMovie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptrMovie;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnMovie_name;
    }
}
