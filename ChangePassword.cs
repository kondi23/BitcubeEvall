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

namespace BCLoginRegistrationForm
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtChangeEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            {

                //db connection
                SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-0997K4M;Initial Catalog=UserRegistrationDB;Integrated Security=True");
                sqlConn.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT (*) FROM tblUser WHERE EmailAddress = '" + txtChangeEmailAddress.Text + "'  AND Password = '" + txtOldPassword.Text + "'", sqlConn);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                errorProvider1.Clear();

                if (dataTable.Rows.Count > 1)
                {
                    if (txtNewPassword.Text == txtConfirmNewPassword.Text)
                    {

                        SqlDataAdapter dataAdapter1 = new SqlDataAdapter("Update tblUser set pass = '" + txtNewPassword.Text + "' WHERE EmailAddress = '" + txtChangeEmailAddress.Text + "' and Password = '" + txtOldPassword.Text + "'", sqlConn);
                        MessageBox.Show("Password Changed Successful", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        errorProvider1.SetError(txtNewPassword, "Password doesn't match");
                        errorProvider1.SetError(txtConfirmNewPassword, "Password doesn't match");

                    }
                }
                else
                {
                    errorProvider1.SetError(txtChangeEmailAddress, "Incorrect Password");
                    errorProvider1.SetError(txtOldPassword, "Incorrect Password");

                }


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
