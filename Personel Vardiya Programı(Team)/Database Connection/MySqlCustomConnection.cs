using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Personel_Vardiya_Programı_Team_.Database_Connection
{
    public class MySqlCustomConnection
    {

        string connectionKey = null;

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public MySqlCustomConnection()
        {
            //this.connectionKey = "Server=3.67.188.79;Database=vardiya;user=root;Pwd=;SslMode=none";
        }

        /*public MySqlConnection(string connectionKey)
        {
            this.connectionKey = connectionKey;
        }*/

        public void Connect()
        {
            con = new MySqlConnection("Server=127.0.0.1;Database=test;Uid=root;Pwd=''");
            con.Open();
            if(con.State == System.Data.ConnectionState.Open)
                MessageBox.Show("Bağllantı Sağlandı");
        }

        public void setConnectionKey(string connectionKey)
        {
            this.connectionKey = connectionKey;
        }

        public void generateConnectionKey(string hostIp, string dbname, string charset, string username, string password)
        {
            connectionKey = "mysql:host=" + hostIp + ";dbname=" + dbname + ";charset=" + charset + ";uid=" + username + ";pwd=" + password;
        }

       

    }
}
