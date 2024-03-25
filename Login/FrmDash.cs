using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmDash : Form
    {
        public FrmDash()
        {
            InitializeComponent();
        }

        private void FrmDash_Load(object sender, EventArgs e)
        {
            lblUserGreeting.Text = $"Greetings {LoginDB.currentLoggedOnUser.getUsername()}!";
            this.Text = $"Dashboard - {LoginDB.currentLoggedOnUser.getUsername()}";
        }
    }
}
