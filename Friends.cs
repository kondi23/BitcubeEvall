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
    public partial class Friends : Form
    {
        public Friends()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //redirects to login form
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //redirect to profile page
            this.Close();
            BCMainForm profilePage = new BCMainForm();
            profilePage.Show();
            this.Hide();

        }
    }
}
