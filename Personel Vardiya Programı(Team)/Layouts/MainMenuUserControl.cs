﻿using System;
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
    }
}
