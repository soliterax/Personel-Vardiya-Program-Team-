using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
