﻿using ManageCinema.DAO;
using ManageCinema.DTO;
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
        
        public MovieShow()
        {
            InitializeComponent();
            ptrFormat2.Visible = ptrFormat3.Visible = false;
        }

        public MovieShow(Movie movie,List<FormatMovie> formats, Image image)
        {
            InitializeComponent();
            ptrFormat2.Visible = ptrFormat3.Visible = false;
            lblMovie_name.Text = movie.Name;
            ptrMovie.Image = image;
            lblActor.Text = movie.Actor;
            lblDirector.Text = movie.Director;
            lblDescription.Text = movie.Desc;
            lblTime.Text = "Từ " + String.Format("{0:dd/MM/yyyy HH:mm:ss}", movie.StartDate).ToString().Split(' ')[0] + " đến " + String.Format("{0:dd/MM/yyyy HH:mm:ss}", movie.EndDate).ToString().Split(' ')[0];
            List<Genre> listGenreOfMovie = MovieClassifyDAO.GetListGenreByMovieID(movie.ID!);
            for(int i = 0; i < listGenreOfMovie.Count; i++)
            {
                if(i == listGenreOfMovie.Count - 1)
                {
                    lblGenre.Text += listGenreOfMovie[i].Name;
                    break;
                }
                lblGenre.Text += listGenreOfMovie[i].Name + ", ";
            }
            if(formats.Count == 1)
            {
                if(formats[0].ScreenTypeName == "2D")
                    ptrFormat1.Image = global::ManageCinema.Properties.Resources._2D;
                else if (formats[0].ScreenTypeName == "3D")
                    ptrFormat1.Image = global::ManageCinema.Properties.Resources._3D;
                else ptrFormat1.Image = global::ManageCinema.Properties.Resources.IMAX;
            }
            else if(formats.Count == 2)
            {
                
                if (formats[0].ScreenTypeName == "2D" && formats[1].ScreenTypeName == "3D")
                {
                    ptrFormat1.Image = global::ManageCinema.Properties.Resources._2D;
                    ptrFormat2.Image = global::ManageCinema.Properties.Resources._3D;
                    ptrFormat2.Visible = true;
                }
                else if (formats[0].ScreenTypeName == "3D" && formats[1].ScreenTypeName == "IMAX")
                {
                    ptrFormat1.Image = global::ManageCinema.Properties.Resources._2D;
                    ptrFormat2.Image = global::ManageCinema.Properties.Resources._3D;
                    ptrFormat2.Visible = true;
                }
                else 
                {
                    ptrFormat1.Image = global::ManageCinema.Properties.Resources._2D;
                    ptrFormat2.Image = global::ManageCinema.Properties.Resources._3D;
                    ptrFormat2.Visible = true;
                }
            }
            else if(formats.Count == 3)
            {
                ptrFormat1.Image = global::ManageCinema.Properties.Resources._2D;
                ptrFormat2.Image = global::ManageCinema.Properties.Resources._3D;
                ptrFormat3.Image = global::ManageCinema.Properties.Resources.IMAX;
                ptrFormat2.Visible = ptrFormat3.Visible = true;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            CardInfoShowTimes showTimes = new CardInfoShowTimes(lblMovie_name.Text);
            showTimes.ShowDialog();
        }
    }
}
