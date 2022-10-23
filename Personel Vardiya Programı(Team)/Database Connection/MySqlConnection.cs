using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Vardiya_Programı_Team_.Database_Connection
{
    public class MySqlConnection
    {

        string connectionKey = null;

        MySqlClient cli = new MySqlClient();

        public MySqlConnection()
        {

        }

        public MySqlConnection(string connectionKey)
        {
            this.connectionKey = connectionKey;
        }

        public void Connect()
        {

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
