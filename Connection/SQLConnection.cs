using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BCLoginRegistrationForm.Connection
{
    class SQLConnection
    { 
        //connection to SQL server
        public static string stringconn = "Data Source = DESKTOP-0997K4M; Initial Catalog = UserRegistrationDB; Integrated Security = True";

        //"Data Source=DESKTOP-0997K4M\\Kondi;Initial Catalog=UserRegistrationDB;Integrated Security=True"


        public static DataTable executeSQL(String SQL)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable table = new DataTable();

            try
            {
                connection.ConnectionString = stringconn;
                connection.Open();

                adapter = new SqlDataAdapter(SQL, connection);
                adapter.Fill(table);

                //close connection
                connection.Close();
                connection = null;
                return table;


            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error occured: " + ex.Message, "SQL connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                table = null;
            }
            return table;
        
        }
    }
}
