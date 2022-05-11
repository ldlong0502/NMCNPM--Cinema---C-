using Guna.UI2.WinForms;
using ManageCinema.Controls;
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
        CardMovie[] cards = new CardMovie[5];
        string[] listName = new string[5]
        {
            "Đêm tối rực rỡ",
            "Conan",
            "Doraemon",
            "OnePeice",
            "Naruto",
        };
        Image[] listPicture = new Image[5]
        {
            Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\1.jpg"),
            Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\4.jpg"),
            Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\5.jpg"),
            Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\2.jpg"),
            Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\3.jpg"),
        };
        string style2D = "2D";
        static int num_current;
        static Point start;
        static Point end;
        Size size = new Size(253, 331);
        int posLeft,posRight;
        public MovieForm()
        {
            num_current = 0;
            InitializeComponent();
            btnMovie_Hot.FillColor = Color.Silver;
            btnMovie_Current.FillColor = Color.FromArgb(60, 63, 81);
            btnMocie_Future.FillColor = Color.FromArgb(60, 63, 81);
            btnMovie_Hot.ForeColor = Color.White;
            btnMovie_Current.ForeColor = Color.LightGray;
            btnMocie_Future.ForeColor = Color.LightGray;
            for(int i = 0; i < 5; i++)
            {
                cards[i] = new CardMovie(listName[i], style2D, listPicture[i]);
            }
            pnlCard1.Controls.Add(cards[num_current++]);
            pnlCard2.Controls.Add(cards[num_current++]);
            pnlCard3.Controls.Add(cards[num_current++]);
            pnlCard4.Controls.Add(cards[num_current++]);
            start = pnlCard1.Location;
            end = pnlCard4.Location;
            posLeft = 1;
            posRight = 4;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnMovie_Hot_Click(object sender, EventArgs e)
        {
            btnMovie_Hot.FillColor = Color.Silver;
            btnMovie_Current.FillColor = Color.FromArgb(60, 63, 81);
            btnMocie_Future.FillColor = Color.FromArgb(60, 63, 81);
            btnMovie_Hot.ForeColor = Color.White;
            btnMovie_Current.ForeColor = Color.LightGray;
            btnMocie_Future.ForeColor = Color.LightGray;
        }


        private void btnMovie_Current_Click(object sender, EventArgs e)
        {
            btnMovie_Current.FillColor = Color.Silver;
            btnMocie_Future.FillColor = Color.FromArgb(60, 63, 81);
            btnMovie_Hot.FillColor = Color.FromArgb(60, 63, 81);
            btnMovie_Hot.ForeColor = Color.LightGray;
            btnMovie_Current.ForeColor = Color.White;
            btnMocie_Future.ForeColor = Color.LightGray;
        }

        private void btnMocie_Future_Click(object sender, EventArgs e)
        {
            btnMocie_Future.FillColor = Color.Silver;
            btnMovie_Current.FillColor = Color.FromArgb(60, 63, 81);
            btnMovie_Hot.FillColor = Color.FromArgb(60, 63, 81);
            btnMovie_Hot.ForeColor = Color.LightGray;
            btnMovie_Current.ForeColor = Color.LightGray;
            btnMocie_Future.ForeColor = Color.White;
        }

        private void pnlNavigate_Paint(object sender, PaintEventArgs e)
        {

        }

        void setButonNavigateLocation()
        {
            btnNext.Location = new Point(178, 107);
            btnPrevious.Location = new Point(0, 104);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Panel pnlnew = new Panel();
            if (posLeft == 1)
            {
                pnlCard1.Dock = DockStyle.None;
                pnlCard1.Location = new Point(-1, pnlCard1.Location.Y);
                pnlCard1.Size = new Size(1, pnlCard1.Height);
                AnimationCard1.ShowSync(pnlCard1);
                pnlListCard.Controls.Remove(pnlCard1);
                AnimationCard2.ShowSync(pnlCard2);
                AnimationCard3.ShowSync(pnlCard3);
                AnimationCard4.ShowSync(pnlCard4);
                posLeft++;
                pnlnew.Name = "pnlCard1";

            }
            else if(posLeft == 2)
            {
                pnlCard2.Dock = DockStyle.None;
                pnlCard2.Location = new Point(-1, pnlCard1.Location.Y);
                pnlCard2.Size = new Size(1, pnlCard1.Height);
                AnimationCard2.ShowSync(pnlCard2);
                pnlListCard.Controls.Remove(pnlCard2);
                AnimationCard1.ShowSync(pnlCard1);
                AnimationCard3.ShowSync(pnlCard3);
                AnimationCard4.ShowSync(pnlCard4);
                posLeft++;
                pnlnew.Name = "pnlCard2";
            }
            else if (posLeft == 3)
            {
                pnlCard3.Dock = DockStyle.None;
                pnlCard3.Location = new Point(-1, pnlCard1.Location.Y);
                pnlCard3.Size = new Size(1, pnlCard1.Height);
                AnimationCard3.ShowSync(pnlCard3);
                pnlListCard.Controls.Remove(pnlCard3);
                AnimationCard1.ShowSync(pnlCard1);
                AnimationCard2.ShowSync(pnlCard2);
                AnimationCard4.ShowSync(pnlCard4);
                posLeft++;
                pnlnew.Name = "pnlCard3";
            }
            else if (posLeft == 4)
            {
                pnlCard4.Dock = DockStyle.None;
                pnlCard4.Location = new Point(-1, pnlCard1.Location.Y);
                pnlCard4.Size = new Size(1, pnlCard1.Height);
                AnimationCard3.ShowSync(pnlCard4);
                pnlListCard.Controls.Remove(pnlCard4);
                AnimationCard1.ShowSync(pnlCard1);
                AnimationCard2.ShowSync(pnlCard2);
                AnimationCard3.ShowSync(pnlCard3);
                posLeft = 1;
                pnlnew.Name = "pnlCard4";
            }    
            
            
            pnlListCard.Controls.Add(pnlnew);
            pnlnew.Size = size;
            if(num_current >= cards.Length)
                num_current = 0;
            pnlnew.Controls.Add(cards[num_current++]);
            pnlnew.Dock = DockStyle.Right;



        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pnlCard4.Dock = DockStyle.Right;
            pnlCard3.Dock = DockStyle.Right;
            pnlCard2.Dock = DockStyle.Right;
            pnlCard1.Dock = DockStyle.Right;
            Panel pnlnew = new Panel();
            if (posRight == 1)
            {
                pnlCard1.Dock = DockStyle.None;
                pnlCard1.Location = new Point(-1, pnlCard1.Location.Y);
                pnlCard1.Size = new Size(1, pnlCard1.Height);
                AnimationCard1.ShowSync(pnlCard1);
                pnlListCard.Controls.Remove(pnlCard1);
                AnimationCard2.ShowSync(pnlCard2);
                AnimationCard3.ShowSync(pnlCard3);
                AnimationCard4.ShowSync(pnlCard4);
                posLeft++;
                pnlnew.Name = "pnlCard1";

            }
            else if (posRight == 2)
            {
                pnlCard2.Dock = DockStyle.None;
                pnlCard2.Location = new Point(-1, pnlCard1.Location.Y);
                pnlCard2.Size = new Size(1, pnlCard1.Height);
                AnimationCard2.ShowSync(pnlCard2);
                pnlListCard.Controls.Remove(pnlCard2);
                AnimationCard1.ShowSync(pnlCard1);
                AnimationCard3.ShowSync(pnlCard3);
                AnimationCard4.ShowSync(pnlCard4);
                posLeft++;
                pnlnew.Name = "pnlCard2";
            }
            else if (posRight == 3)
            {
                pnlCard3.Dock = DockStyle.None;
                pnlCard3.Location = new Point(-1, pnlCard1.Location.Y);
                pnlCard3.Size = new Size(1, pnlCard1.Height);
                AnimationCard3.ShowSync(pnlCard3);
                pnlListCard.Controls.Remove(pnlCard3);
                AnimationCard1.ShowSync(pnlCard1);
                AnimationCard2.ShowSync(pnlCard2);
                AnimationCard4.ShowSync(pnlCard4);
                posLeft++;
                pnlnew.Name = "pnlCard3";
            }
            else if (posRight == 4)
            {
                pnlCard4.Dock = DockStyle.None;
                pnlCard4.Location = new Point(pnlCard4.Location.X+1, pnlCard1.Location.Y);
                pnlCard4.Size = new Size(1, pnlCard1.Height);
                AnimationCard3.ShowSync(pnlCard4);
                pnlListCard.Controls.Remove(pnlCard4);
                AnimationCard1.ShowSync(pnlCard1);
                AnimationCard2.ShowSync(pnlCard2);
                AnimationCard3.ShowSync(pnlCard3);
                posRight--;
                pnlnew.Name = "pnlCard3";
            }


            pnlListCard.Controls.Add(pnlnew);
            pnlnew.Size = size;
            if (num_current >= cards.Length)
                num_current = 0;
            pnlnew.Controls.Add(cards[num_current++]);
            pnlnew.Dock = DockStyle.Right;
        }
    }
}
