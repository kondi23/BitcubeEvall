using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCLoginRegistrationForm.Connection;
using RegForm;

namespace BCLoginRegistrationForm
{
    public partial class RegistrationForm : Form
    {
        //hash Code
        hashCode hash = new hashCode();



        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear data
            clearControls();
            txtFirstName.Select();
        }

        private void clearControls()
        {
            //textbox clear
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //User must supply at least their first name and last name
            //check if email and password are inserted
            if (txtEmailAddress.Text == "" || txtPassword.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
            {
                //message to user
                MessageBox.Show("Please Fill In the mandatory fields");

            }


            //pass matching
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password doesn't match");
            }

            else
            {
                string yourSQL = "SELECT EmailAddress FROM tblUser WHERE EmailAddress = '" + txtEmailAddress.Text + "'";
                DataTable checkDuplicates = BCLoginRegistrationForm.Connection.SQLConnection.executeSQL(yourSQL);
                //check duplicates
                if (checkDuplicates.Rows.Count > 0)
                {
                    MessageBox.Show("The username already exists. Please try another username.",
                        "C# Registration Form : Registartion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailAddress.SelectAll();
                    return;
                }

                DialogResult result;
                result = MessageBox.Show("Is your information correct?", "Complete : Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string mySQL = string.Empty;

                    mySQL += "INSERT INTO tblUser (FirstName, LastName, EmailAddress, Contact, Password, ConfirmPassword) ";
                    mySQL += "VALUES ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmailAddress.Text + "',";
                    mySQL += "'" + txtContact.Text + "','" + txtPassword.Text + "','" + txtConfirmPassword.Text + "')";

                    BCLoginRegistrationForm.Connection.SQLConnection.executeSQL(mySQL);

                    MessageBox.Show("Your information was saved successfully.", "Completed : Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    clearControls();
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();

                }
            }



        }

        private void lnklblSignOn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            //show password char
            if (chkShowHide.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //password must be unique
            if (RegExPassword.checkPassword(txtPassword.Text.ToString()))
            {

                lblPassword.Text = ("Valid Password");
                lblPassword.ForeColor = Color.DarkGreen;
                btnSubmit.Enabled = true;

            }
            else
            {
                lblPassword.Text = ("Password must have at least \n * 1 uppercase character \n *1 lowercase character \n *1 special character  number \n *1 must be at least 6 characters long");
                btnSubmit.Enabled = false;

            }
        }
    }
}
