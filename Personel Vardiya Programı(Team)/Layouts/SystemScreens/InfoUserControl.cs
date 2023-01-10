using Personel_Vardiya_Programı_Team_.Base_Class;
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
using static Personel_Vardiya_Programı_Team_.SetupForm;

namespace Personel_Vardiya_Programı_Team_.Layouts.SystemScreens
{
    public partial class InfoUserControl : UserControl
    {

        DataRow p;

        public InfoUserControl()
        {
            InitializeComponent();
        }

        public InfoUserControl(DataRow p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void InfoUserControl_Load(object sender, EventArgs e)
        {
            date.Text = p[0].ToString();

            id1.Text = ConnectionMemory.conn.GetManager().GetData($"select name from Personals where id='{p[1].ToString()}'").Rows[0][0].ToString();
            id2.Text = ConnectionMemory.conn.GetManager().GetData($"select name from Personals where id='{p[2].ToString()}'").Rows[0][0].ToString();
            id3.Text = ConnectionMemory.conn.GetManager().GetData($"select name from Personals where id='{p[3].ToString()}'").Rows[0][0].ToString();
            id4.Text = ConnectionMemory.conn.GetManager().GetData($"select name from Personals where id='{p[4].ToString()}'").Rows[0][0].ToString();
            id5.Text = ConnectionMemory.conn.GetManager().GetData($"select name from Personals where id='{p[5].ToString()}'").Rows[0][0].ToString();
        }
    }
}
