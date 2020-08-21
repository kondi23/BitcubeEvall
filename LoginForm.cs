using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCLoginRegistrationForm.Connection;
using System.Data.SqlClient;

namespace BCLoginRegistrationForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TxtUsername.Select(); //focus on username


            if (Properties.Settings.Default.EmailAddress != string.Empty)
            {
                TxtUsername.Text = Properties.Settings.Default.EmailAddress;

            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close
        }

        private void LnkLblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //show registration form
            RegistrationForm registration = new RegistrationForm();
            registration.ShowDialog();
            this.Hide();
        }

        private void ChckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //show password char
            if (ChckShowPassword.Checked == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsername.Text) && !string.IsNullOrEmpty(TxtPassword.Text))
            {

                SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-0997K4M;Initial Catalog=UserRegistrationDB;Integrated Security=True");
                SqlCommand sqlComm = new SqlCommand("SELECT * FROM tblUser WHERE EmailAddress = @EmailAddress and Password = @Password", sqlConn);
                sqlConn.Open();
                //sqlComm.CommandType = CommandType.StoredProcedure;
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                // SqlDataReader dataReader = sqlComm.ExecuteReader();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                sqlComm.Parameters.AddWithValue("@EmailAddress", TxtUsername.Text); 
                sqlComm.Parameters.AddWithValue("@Password", TxtPassword.Text);
                DataSet dataSet = new DataSet();

                dataAdapter.SelectCommand = sqlComm;
                dataAdapter.Fill(dataTable);



                if (dataTable.Rows.Count > 0)
                {
                    TxtUsername.Clear();
                    TxtPassword.Clear();
                    ChckShowPassword.Checked = false;
                    this.Hide();
                   

                    BCMainForm mainForm = new BCMainForm();
                    mainForm.ShowDialog();
                    mainForm = null;

                    this.Show();
                    this.TxtUsername.Select();

                }
                else
                {
                    MessageBox.Show("Username or Password incorrect. /n Try Agian","LOGIN FORM FOR BC", MessageBoxButtons.OK, MessageBoxIcon.Stop) ;
                    TxtUsername.Focus();
                    TxtUsername.SelectAll();
                }

            }
            else
            {
                MessageBox.Show("Please enter username and password. ", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUsername.Select();
            }
        }

        private void chckBoxRememberPass_CheckedChanged(object sender, EventArgs e)
        {
            //user must have option to select remember email address
            if (chckBoxRememberPass.Checked == true)
            {
                Properties.Settings.Default.EmailAddress  = TxtUsername.Text;

                Properties.Settings.Default.Save();
            }

            if (chckBoxRememberPass.Checked == false)
            {
                Properties.Settings.Default.EmailAddress = "";
                Properties.Settings.Default.Save();

            }
        }
    }
}
