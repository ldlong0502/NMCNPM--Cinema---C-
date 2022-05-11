using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCinema.Controls
{
    public partial class MovieShow : Form
    {
        private string movie_name = "" ;
        private string startTime = "";
        private string style = "";
        private string ani_style = "";
        private string actor = "";
        private string director = "";
        private Image image = Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\1.jpg");
        private string trailer = "https://youtu.be/mq5Hn2vZ90w";
        public string Movie_Name
        {
            get { return movie_name; }
            set { movie_name = value; }
        }
        public string Movie_StartTime
        {
            get { return startTime; }   
            set { startTime = value; }
        }
        public string Style
        {
            get { return style; }
            set { style = value; }
        }
        public string Ani_Style
        {
            get { return ani_style; }
            set { ani_style = value; }
        }
        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        public string Trailer
        {
            get { return trailer; }
            set { trailer = value; }
        }
        public MovieShow()
        {
            InitializeComponent();
        }

        public MovieShow(string movie_Name, string movie_StartTime, string style, string ani_Style, string actor, string director, Image image, string trailer)
        {
            InitializeComponent();
            Movie_Name = movie_Name;
            Movie_StartTime = movie_StartTime;
            Style = style;
            Ani_Style = ani_Style;
            Actor = actor;
            Director = director;
            Image = image;
            Trailer = trailer;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form_Store.homePage.Show();
            this.Close();
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = Trailer,
                UseShellExecute = true
            });
        }
    }
}
