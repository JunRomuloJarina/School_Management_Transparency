using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_Transparency.SchoolManagementTransparencyApp.Util
{
    internal class DatabaseConnection
    {


        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=R0mul0J@rin@;database=LMS");

        public MySqlConnection getconnection
        {
            get { return connection; }
        }
        //create a function to open conection
        public void openConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //create a function to close conection
        public void closeConnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
