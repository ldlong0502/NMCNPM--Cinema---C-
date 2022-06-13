using ManageCinema.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCinema.Controls
{
    public partial class CardInfoShowTimes : Form
    {
        public String? MovieName;
        public CardInfoShowTimes(string movieName)
        {
            InitializeComponent();
            LoadShowTime(movieName);
        }

        private void LoadShowTime(string movieName)
        {
            MovieName = movieName;
            lblMovieName.Text = movieName;
            flowLayoutShowtine.Controls.Clear();
            DataTable dt = ShowTimesDAO.SearchShowtimeByMovieNameOrdeyByShowtimesASC(MovieName!);
            foreach (DataRow dr in dt.Rows)
            {
                DateTime time = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);
                DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                DateTime lc = (DateTime)dr["Thời gian chiếu"];
                string[] list = lc.ToString().Split(' ');
                if (time.ToString().Split(' ')[0] == list![0])
                {
                    TextBox txt = new TextBox();
                    if (DateTime.Compare(lc, DateTime.Now) < 0)
                    {
                        txt.Enabled = false;
                    }
                    txt.ReadOnly = true;
                    txt.Size = new Size(80, 50);
                    txt.Multiline = true;
                    txt.TextAlign = HorizontalAlignment.Center;
                    txt.Margin = new Padding(5, 5, 5, 5);
                    txt.Text = list[1] + " " + list[2];
                    txt.BackColor = Color.White;
                    flowLayoutShowtine.Controls.Add(txt);
                }
            }
            if (flowLayoutShowtine.Controls.Count <= 0)
            {
                Label lbl = new Label();
                lbl.Text = "Chưa có lịch chiếu";
                lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                lbl.AutoSize = true;
                lbl.ForeColor = Color.White;
                flowLayoutShowtine.Controls.Add(lbl);
                return;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutShowtine.Controls.Clear();
            DataTable dt = ShowTimesDAO.SearchShowtimeByMovieNameOrdeyByShowtimesASC(MovieName!);
            foreach (DataRow dr in dt.Rows)
            {
                DateTime time = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);
                DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                DateTime lc = (DateTime)dr["Thời gian chiếu"];
                string[] list = lc.ToString().Split(' ');
                if (time.ToString().Split(' ')[0] == list![0])
                {
                    TextBox txt = new TextBox();
                    if (DateTime.Compare(lc, DateTime.Now) < 0)
                    {
                        txt.Enabled = false;
                    }
                    txt.ReadOnly = true;
                    txt.Size = new Size(80, 50);
                    txt.Multiline = true;
                    txt.TextAlign = HorizontalAlignment.Center;
                    txt.Margin = new Padding(5, 5, 5, 5);
                    txt.Text = list[1] + " " + list[2];
                    txt.BackColor = Color.White;
                    flowLayoutShowtine.Controls.Add(txt);
                }
            }
            if (flowLayoutShowtine.Controls.Count <= 0)
            {
                Label lbl = new Label();
                lbl.Text = "Chưa có lịch chiếu";
                lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                lbl.AutoSize = true;
                lbl.ForeColor = Color.White;
                flowLayoutShowtine.Controls.Add(lbl);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
