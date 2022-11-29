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
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            if(usernameTxt.Texts.Equals("admin") && passwordTxt.Texts.Equals("1234"))
            {
                this.Dispose();
                UserControl1 c = new UserControl1();
                c.Dock = DockStyle.Fill;
                Application.OpenForms[0].Controls.Add(c);
            }

        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
