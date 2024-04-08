using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

namespace Lab_12
{
    internal class DBConnection
    {
        static string DBConnect = "server=localhost; user=root; password=0672951355; database=loginsdb";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myconnect;
        static public MySqlCommand msCommand;

        public static bool ConnectionDB()
        {
            try
            {
                myconnect = new MySqlConnection(DBConnect);
                myconnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myconnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения", "Ошибка", MessageBoxButtons.OK);
                return false;
            }
        }
        public static void CloseDB()
        {
            myconnect.Close();
        }
        public MySqlConnection GetSqlConnection()
        {
            return myconnect;
        }
    }
}
