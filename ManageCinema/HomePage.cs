namespace ManageCinema
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            ClickNavigateButton(btnMovie);

        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnMovie);

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

        private void pnlScreen_Paint(object sender, PaintEventArgs e)
        {
            MovieForm objForm = new MovieForm();
            objForm.TopLevel = false;
            pnlScreen.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}