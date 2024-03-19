namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = !pnlLogin.Visible;
            pnlWelcome.Visible = !pnlWelcome.Visible;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            //hoe maak ek die login werk werk, gaan ons soos n for loop of if statement gebruik om alles te link met die?
            FrmDash formDash = new FrmDash();
            this.Hide();
            formDash.ShowDialog();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = !pnlRegister.Visible;
            pnlLogin.Visible = !pnlLogin.Visible;
        }

        private void lblRegisterLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = !pnlLogin.Visible;
            pnlRegister.Visible = !pnlLogin.Visible;
        }

        private void btnRegisterReg_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = !pnlLogin.Visible;
            pnlRegister.Visible = !pnlRegister.Visible;
        }
    }
}
