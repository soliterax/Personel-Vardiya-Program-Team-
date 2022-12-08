using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Vardiya_Programı_Team_.Layouts
{
    public partial class UserVardiyaControl : UserControl
    {
        public UserVardiyaControl()
        {
            InitializeComponent();
        }

        private void UserVardiyaControl_Load(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e) //geri butonu
        {
            MainMenuUserControl c = new MainMenuUserControl();
            this.Dispose();
            GC.Collect();
            c.Dock = DockStyle.Fill;
            Application.OpenForms[1].Controls.Add(c);
        }

        private void customButton1_Click(object sender, EventArgs e) // kaydet butonu
        {

        }
    }
}
