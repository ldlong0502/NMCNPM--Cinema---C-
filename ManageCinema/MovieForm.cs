using ManageCinema.Controls;
using ManageCinema.DAO;
using ManageCinema.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCinema
{
    public partial class MovieForm : Form
    {
        List<Movie> listMovie = MovieDAO.GetListMovie();
        public MovieForm()
        {
            InitializeComponent();
            LoadMovieForm();
        }

        private void LoadMovieForm()
        {
            int k = 0;
            while (k < 5)
            {
                for (int i = 0; i < listMovie.Count; i++)
                {
                    Image image = MovieDAO.byteArrayToImage(listMovie[i].Poster!);
                    List<FormatMovie> formats = FormatMovieDAO.GetListFormatMovieByMovie(listMovie[i].ID!);
                    CardMovie cardMovie = new CardMovie(listMovie[i].Name!, formats, image);
                    cardMovie.Margin = new Padding(30,20,0 ,0);
                    flowLayoutMovie.Controls.Add(cardMovie);
                }
                k++;
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
