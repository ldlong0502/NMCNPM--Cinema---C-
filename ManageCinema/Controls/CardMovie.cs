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
using ManageCinema.DTO;

namespace ManageCinema.Controls
{

    public partial class CardMovie : UserControl
    {
        private string movie_name = "";
        private List<FormatMovie> format = new List<FormatMovie>();
        private Image image = Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\1.jpg");
        
        public string Movie_name { get { return movie_name; } set { movie_name = value; } }
        public List<FormatMovie> Format { get { return format; } set { format = value; } }

        public Image Image
        {
            get { return image; } set { image = value; } 
        }
        public CardMovie(string movie_name , List<FormatMovie> listFormat, Image image)
        {
            Movie_name = movie_name;
            Format = format;
            Image = image;
            InitializeComponent();
            btnMovie_name.Text = Movie_name + "\n";
            foreach (FormatMovie format in listFormat)
            {
                btnMovie_name.Text += format.ScreenTypeName + ' ';
            }
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

