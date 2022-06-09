using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageCinema.Controls;

namespace ManageCinema.Controls
{

    public partial class CardMovie : UserControl
    {
        private string movie_name = "";
        private string style = "";
        private Image image = Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\1.jpg");
        
        public string Movie_name { get { return movie_name; } set { movie_name = value; } }
        public string Style { get { return style; } set { style = value; } }

        public Image Image
        {
            get { return image; } set { image = value; } 
        }
        public CardMovie(string movie_name , string style, Image image)
        {
            Movie_name = movie_name;
            Style = style;
            Image = image;
            InitializeComponent();
            btnMovie_name.Text = Movie_name + "\n" + Style;
            ptrMovie.Image = Image;
        }

        private void btnMovie_name_Click(object sender, EventArgs e)
        {
            MovieShow moviePopUp = new MovieShow();
            moviePopUp.Show();
            Form_Store.homePage.Hide();
        }
    }
}

