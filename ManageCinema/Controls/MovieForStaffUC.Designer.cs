namespace ManageCinema.Controls
{
    partial class MovieForStaffUC
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
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchByMovieName = new System.Windows.Forms.TextBox();
            this.ptrSearch = new Guna.UI2.WinForms.Guna2Button();
            this.clbGenre = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 192);
            this.panel1.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(891, 128);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 45);
            this.btnReset.TabIndex = 52;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchByMovieName);
            this.groupBox1.Controls.Add(this.ptrSearch);
            this.groupBox1.Controls.Add(this.clbGenre);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(826, 157);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearchByMovieName
            // 
            this.txtSearchByMovieName.Location = new System.Drawing.Point(22, 30);
            this.txtSearchByMovieName.Name = "txtSearchByMovieName";
            this.txtSearchByMovieName.PlaceholderText = "Tìm phim theo tên";
            this.txtSearchByMovieName.Size = new System.Drawing.Size(221, 32);
            this.txtSearchByMovieName.TabIndex = 48;
            // 
            // ptrSearch
            // 
            this.ptrSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ptrSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ptrSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ptrSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ptrSearch.FillColor = System.Drawing.Color.Transparent;
            this.ptrSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ptrSearch.ForeColor = System.Drawing.Color.White;
            this.ptrSearch.Image = global::ManageCinema.Properties.Resources.search;
            this.ptrSearch.Location = new System.Drawing.Point(249, 30);
            this.ptrSearch.Name = "ptrSearch";
            this.ptrSearch.Size = new System.Drawing.Size(32, 27);
            this.ptrSearch.TabIndex = 53;
            this.ptrSearch.Click += new System.EventHandler(this.ptrSearch_Click);
            // 
            // clbGenre
            // 
            this.clbGenre.CheckOnClick = true;
            this.clbGenre.FormattingEnabled = true;
            this.clbGenre.Location = new System.Drawing.Point(390, 30);
            this.clbGenre.MultiColumn = true;
            this.clbGenre.Name = "clbGenre";
            this.clbGenre.Size = new System.Drawing.Size(412, 112);
            this.clbGenre.TabIndex = 51;
            this.clbGenre.SelectedIndexChanged += new System.EventHandler(this.clbGenre_SelectedIndexChanged);
            // 
            // flowLayoutMovie
            // 
            this.flowLayoutMovie.AutoScroll = true;
            this.flowLayoutMovie.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMovie.Location = new System.Drawing.Point(0, 192);
            this.flowLayoutMovie.Name = "flowLayoutMovie";
            this.flowLayoutMovie.Size = new System.Drawing.Size(1012, 440);
            this.flowLayoutMovie.TabIndex = 4;
            // 
            // MovieForStaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.flowLayoutMovie);
            this.Controls.Add(this.panel1);
            this.Name = "MovieForStaffUC";
            this.Size = new System.Drawing.Size(1012, 632);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutMovie;
        private TextBox txtSearchByMovieName;
        private CheckedListBox clbGenre;
        private Guna.UI2.WinForms.Guna2Button ptrSearch;
        private Button btnReset;
        private GroupBox groupBox1;
    }
}
