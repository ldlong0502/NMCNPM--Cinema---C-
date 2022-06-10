namespace ManageCinema
{
    partial class Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.butt3 = new System.Windows.Forms.Button();
            this.button222 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "staff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnAdmin
            // 
            this.pnAdmin.Location = new System.Drawing.Point(1, 87);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(1083, 365);
            this.pnAdmin.TabIndex = 1;
            // 
            // butt3
            // 
            this.butt3.Location = new System.Drawing.Point(153, 58);
            this.butt3.Name = "butt3";
            this.butt3.Size = new System.Drawing.Size(75, 23);
            this.butt3.TabIndex = 0;
            this.butt3.Text = "customer";
            this.butt3.UseVisualStyleBackColor = true;
            this.butt3.Click += new System.EventHandler(this.butt3_Click);
            // 
            // button222
            // 
            this.button222.Location = new System.Drawing.Point(257, 58);
            this.button222.Name = "button222";
            this.button222.Size = new System.Drawing.Size(75, 23);
            this.button222.TabIndex = 0;
            this.button222.Text = "account";
            this.button222.UseVisualStyleBackColor = true;
            this.button222.Click += new System.EventHandler(this.button222_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 459);
            this.Controls.Add(this.pnAdmin);
            this.Controls.Add(this.button222);
            this.Controls.Add(this.butt3);
            this.Controls.Add(this.button1);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Panel pnAdmin;
        private Button butt3;
        private Button button222;
    }
}