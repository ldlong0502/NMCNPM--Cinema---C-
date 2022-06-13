using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCinema.Admin
{
    public partial class DataUC : UserControl
    {
        public DataUC()
        {
            InitializeComponent();
            pnlData.Controls.Clear();
            pnlData.Controls.Add(new TypeScreenUC());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            pnlData.Controls.Clear();
            pnlData.Controls.Add(new MovieUC());
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            pnlData.Controls.Clear();
            pnlData.Controls.Add(new GenreUC());
        }

        private void btnTypeScreen_Click(object sender, EventArgs e)
        {
            pnlData.Controls.Clear();
            pnlData.Controls.Add(new TypeScreenUC());
        }

        private void btnFormatMovie_Click(object sender, EventArgs e)
        {
            pnlData.Controls.Clear();
            pnlData.Controls.Add(new FormatMovieUC());
        }

        private void btnRoom_Cinema_Click(object sender, EventArgs e)
        {
            pnlData.Controls.Clear();
            pnlData.Controls.Add(new RoomCinemaUC());
        }

        private void btnShowTimes_Click(object sender, EventArgs e)
        {
            pnlData.Controls.Clear();
            pnlData.Controls.Add(new ShowTimesUC());
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            pnlData.Controls.Clear();
            pnlData.Controls.Add(new TicketUC());
        }
    }
}
