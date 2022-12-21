using SoliteraxLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Personel_Vardiya_Programı_Team_.SetupForm;

namespace Personel_Vardiya_Programı_Team_.Layouts
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (ConnectionMemory.conn == null)
            {
                SoliteraxLibrary.FileSystem.SoliteraxFile file = new SoliteraxLibrary.FileSystem.SoliteraxFile(Environment.CurrentDirectory + "\\connection.txt");
                SonsuzLock sl = new SonsuzLock("h@xt@r", 3);
                string s = sl.sifrecoz(file.Read());
                ConnectionMemory.conn = new SoliteraxLibrary.SQLSystem.ConnectDatabase(s, SoliteraxConnection.ConnectionType.SQL).Connect();
            }
            DataTable dt = ConnectionMemory.conn.GetManager().GetData("select username, password from Users");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].Equals(usernameTxt.Texts) && dt.Rows[i][1].Equals(passwordTxt.Texts))
                {
                    this.Dispose();
                    Application.OpenForms[1].Controls.Remove(this);
                    GC.Collect();
                    MainMenuUserControl c = new MainMenuUserControl();
                    c.Dock = DockStyle.Fill;
                    c.Visible = true;
                    Application.OpenForms[1].Controls.Add(c);
                    return;
                }
            }

            
            panel1.Visible = true;

        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        int sayi = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                sayi -= 1;
                if (sayi != 0)
                    return;
                panel1.Visible = false;
                sayi = 10;
            }
        }
    }
}
