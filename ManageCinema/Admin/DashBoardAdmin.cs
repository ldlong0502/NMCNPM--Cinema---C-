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
    public partial class DashBoardAdmin : Form
    {
        public DashBoardAdmin()
        {
            InitializeComponent();
        }

        private void pnlTask_Paint(object sender, PaintEventArgs e)
        {
            pnlTask.Controls.Add(new DataUC());
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(new DataUC());
        }
    }
}
