namespace Login
{
    public partial class Form1 : Form
    {
        LoginDB loginEngine = new LoginDB();

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
            bool userLoginVerified = false;

            if ((txtLoginUsername.Text != String.Empty) && (txtLoginPassword.Text != string.Empty)) { 
                userLoginVerified = loginEngine.verifyUser(txtLoginUsername.Text, txtLoginPassword.Text);
            }

            if (userLoginVerified)
            {
                FrmDash formDash = new FrmDash();
                this.Hide();
                formDash.ShowDialog();
                this.Show();
                pnlLogin.Visible= !pnlLogin.Visible;
                pnlWelcome.Visible= !pnlWelcome.Visible;
            }
            else
            {
                MessageBox.Show("Invalid login details provided","Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            if (loginEngine.isUsernameAvailable(txtRegisterUsername.Text))
            {
                User newUser = new User(txtRegisterUsername.Text,txtRegisterPassword.Text);
                
                if (loginEngine.addNewUser(newUser) == newUser)
                {
                    MessageBox.Show($"Registration completed!\nUsername : {newUser.getUsername()}", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    pnlLogin.Visible = !pnlLogin.Visible;
                    pnlRegister.Visible = !pnlRegister.Visible;
                }
                else
                {
                    MessageBox.Show("Unable to complete registration...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Username has already been used\nPlease use another username","Invalid Username",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
