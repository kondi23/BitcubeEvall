using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


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
            MessageBox.Show("WELCOME TO THE SITE'S PROFILE PAGE", "PROFILE FORM");
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Edit profile
            this.Hide();
            frmChangeProfile changeProfile = new frmChangeProfile();
            changeProfile.Show();

        }



        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword();
            changePassword.Show();
            this.Hide();
        }
    }
}
