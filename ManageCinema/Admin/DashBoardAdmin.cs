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
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(new RevenueUC());
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(new DataUC());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(new CustomerUC());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(new StaffUC());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(new AccountUser());
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(new RevenueUC());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Store.admin = new DashBoardAdmin();
            Form_Store.loginForm.Show();
        }
    }
}
