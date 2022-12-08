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
                Application.OpenForms[0].Controls.Remove(this);
                GC.Collect();
                MainMenuUserControl c = new MainMenuUserControl();
                
                c.Dock = DockStyle.Fill;
                c.Visible = true;
                Application.OpenForms[1].Controls.Add(c);
            }

        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
