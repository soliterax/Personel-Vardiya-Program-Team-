using Personel_Vardiya_Programı_Team_.AutomaticSystems;
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
    public partial class MainMenuUserControl : UserControl
    {
        public MainMenuUserControl()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            this.Dispose();
            GC.Collect();
            UsersUserControl c = new UsersUserControl();
            c.Dock = DockStyle.Fill;
            Application.OpenForms[1].Controls.Add(c);

        }

        private void customButton2_Click(object sender, EventArgs e) // otomatik vardiya
        {
            if (int.Parse(ConnectionMemory.conn.GetManager().GetData("select Count(id) from Personals").Rows[0][0].ToString()) <= 6)
            {
                MessageBox.Show("Your Database Personal entity is too low for this event. \nPlease add new entities!", "Not Enough Entity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AutomaticVardiyaAlgoritm alg = new AutomaticVardiyaAlgoritm();
            alg.StartSystems();
            alg.StartAlgorithms(AutomaticVardiyaAlgoritm.AlgorithmType.Week);
            alg.SaveTable();

            panel1.Controls[0].Invalidate();

        }

        private void customButton3_Click(object sender, EventArgs e) // vardiya ayarlama
        {
            this.Dispose();
            GC.Collect();
            UserVardiyaControl c = new UserVardiyaControl();
            c.Dock = DockStyle.Fill;
            Application.OpenForms[1].Controls.Add(c);
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            LoginUserControl c = new LoginUserControl();
            c.Dock = DockStyle.Fill;
            Application.OpenForms[1].Controls.Add(c);
        }

        private void MainMenuUserControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
