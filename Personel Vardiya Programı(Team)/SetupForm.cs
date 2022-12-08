using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personel_Vardiya_Programı_Team_.Database_Connection;

namespace Personel_Vardiya_Programı_Team_
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();

        private void SetupForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            //MySqlCustomConnection c = new MySqlCustomConnection();
            //c.Connect();
        }

        int i = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
            i++;
            if(i == 4)
            {
                MainForm form = new MainForm();
                form.Visible = true;
                form.Show();
                this.Visible = false;
            }
        }
    }
}
