﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personel_Vardiya_Programı_Team_.Database_Connection;
using Personel_Vardiya_Programı_Team_.Layouts;
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

        private void customButton4_Click(object sender, EventArgs e) // çıkış yap butonu
        {
            this.Dispose();
            LoginUserControl c = new LoginUserControl();
            c.Dock = DockStyle.Fill;
            Application.OpenForms[0].Controls.Add(c);
        }

        private void customButton1_Click(object sender, EventArgs e) //personel butonu
        {
            this.Dispose();
            PersonelForm d = new PersonelForm();
            d.Dock = DockStyle.Fill;
            Application.OpenForms[0].Controls.Add(d);
        }

        private void customButton2_Click(object sender, EventArgs e) // vardiya butonu
        {
         // buraya otomatik vardiya algoritması çağırma
        }

        private void customButton3_Click(object sender, EventArgs e) // vardiya güncelleme butonu
        {
            this.Dispose();
            VardiyaForm d = new VardiyaForm();
            d.Dock = DockStyle.Fill;
            Application.OpenForms[0].Controls.Add(d);
        }
    }
}
