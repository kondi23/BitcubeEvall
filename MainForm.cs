using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BCLoginRegistrationForm
{
    public partial class BCMainForm : Form
    {
        public BCMainForm()
        {
            InitializeComponent();
        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }

        private void BCMainForm_Load(object sender, EventArgs e)
        {
       
        }

        private void lnklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lnklblFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Friends friends = new Friends();
            friends.Show();
            this.Hide();

        }

        private void lnklblProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Profile profile = new Profile();
            profile.Show();
            this.Hide();

        }
    }
}
