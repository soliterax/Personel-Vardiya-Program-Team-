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
using SoliteraxControlLibrary;
using SoliteraxLibrary;

namespace Personel_Vardiya_Programı_Team_
{
    public partial class MainForm : Form
    {

        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setupLayout();
        }

        private void setupLayout()
        {
            headerText.ForeColor = LayoutManager.getColor(LayoutManager.ColorComponents.textHeaderColor);
        }

        //Application Shutdown Method
        private void customPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Form State Minimize code
        private void customPictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
            InitializeComponent();
            setupLayout();
        }

        private void loginUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
