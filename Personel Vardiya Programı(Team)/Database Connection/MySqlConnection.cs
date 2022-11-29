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
    public class MySqlConnection
    {

        string connectionKey = null;

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public MySqlConnection()
        {
            this.connectionKey = "Server=soliterax.com;Database=solitera_Deneme;user=solitera;Pwd=Bb39676321436;SslMode=none";
        }

        public MySqlConnection(string connectionKey)
        {
            this.connectionKey = connectionKey;
        }

        public void Connect()
        {
            con = new MySqlConnection("Server=soliterax.com;Database=solitera_Deneme;user=solitera;Pwd=Bb39676321436;SslMode=none");
            con.Connect();
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
