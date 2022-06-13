using ManageCinema.Controls;

namespace ManageCinema
{
    public partial class HomePage : Form
    {
        MovieForStaffUC movieForStaffUC = new MovieForStaffUC();
        public HomePage()
        {
            InitializeComponent();
            ClickNavigateButton(btnMovie);
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(movieForStaffUC);
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnMovie);
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(movieForStaffUC);

        }
        void ClickNavigateButton(Guna.UI2.WinForms.Guna2GradientButton btn)
        {
            pnlNavigate.Top = btn.Top;
            pnlNavigate.Height = btn.Height;
            btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnTicket);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnSettings);
        }

        private void btnMovie_Leave(object sender, EventArgs e)
        {
            btnMovie.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnTicket_Leave(object sender, EventArgs e)
        {
            btnTicket.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Store.homePage = new HomePage();
            Form_Store.loginForm.Show();
        }

        private void btnShowTimes_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnShowTimes);
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(new Controls.ShowTimesForStaffUC());
        }

        private void btnShowTimes_Leave(object sender, EventArgs e)
        {
            btnShowTimes.BackColor = Color.FromArgb(40, 42, 52);
        }
    }
}