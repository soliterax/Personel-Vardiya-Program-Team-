using Bunifu.UI.WinForms;
using SoliteraxControlLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Personel_Vardiya_Programı_Team_.SetupForm;

namespace Personel_Vardiya_Programı_Team_.Layouts.SetupPanels
{
    public class SetupStage4
    {

        SetupForm f;

        protected CustomPanel panel = new CustomPanel();

        protected BunifuDataGridView data = new BunifuDataGridView();
        protected PersonelEkle ekle = new PersonelEkle();

        protected CustomButton ekleButton = new CustomButton();
        protected CustomButton nextButton = new CustomButton();

        public void setupComponents(SetupForm s)
        {
            f = s;

            panel.Size = new Size(s.Width, (int)(s.Height * 0.95));
            panel.Location = new Point(0, 0);
            panel.Name = "setup4";
            panel.haveBorder = false;
            panel.haveEllipse = false;
            panel.BackColor = s.BackColor;

            data.Size = new Size(panel.Size.Width, (int)(panel.Size.Height * 0.8));
            data.Location = new Point(0, 0);
            data.Name = "data";
            data.BorderStyle = BorderStyle.None;
            data.Font = new Font("TW Cen MT", 15, FontStyle.Bold);
            data.BackgroundColor = panel.BackColor;
            data.ForeColor = Color.White;
            ListTable();
            data.Enabled = false;
            data.HeaderBackColor = Color.MediumSlateBlue;
            data.HeaderForeColor = Color.White;
            data.GridColor = panel.BackColor;
            data.Theme = BunifuDataGridView.PresetThemes.Dark;

            ekle.Visible = false;
            ekle.kaydetClicked += Eklendi;

            ekleButton.Size = new Size((panel.Size.Width / 5), (int)(panel.Size.Height * 0.1f));
            ekleButton.Location = new Point(panel.Size.Width - ekleButton.Size.Width, panel.Size.Height - ekleButton.Size.Height);
            ekleButton.BackColor = panel.BackColor;
            ekleButton.ForeColor = Color.White;
            ekleButton.Name = "ekleButton";
            ekleButton.TextColor = ekleButton.ForeColor;
            ekleButton.BorderColor = Color.MediumSlateBlue;
            ekleButton.BorderSize = 2;
            ekleButton.BorderRadius = 0;
            ekleButton.Text = "Add";
            ekleButton.Click += EkleButton_Click;

            nextButton.Size = new Size((panel.Size.Width / 5), (int)(panel.Size.Height * 0.1f));
            nextButton.Location = new Point((panel.Size.Width / 2) - (nextButton.Size.Width / 2), panel.Size.Height - nextButton.Size.Height);
            nextButton.BackColor = panel.BackColor;
            nextButton.ForeColor = Color.White;
            nextButton.TextColor = nextButton.ForeColor;
            nextButton.BorderColor = Color.MediumSlateBlue;
            nextButton.BorderSize = 2;
            nextButton.BorderRadius = 0;
            nextButton.Name = "nextButton";
            nextButton.Text = "Next";
            nextButton.Click += NextButton_Click;

            panel.Controls.Add(data);
            panel.Controls.Add(ekle);
            panel.Controls.Add(ekleButton);
            panel.Controls.Add(nextButton);

        }

        private void Eklendi(object sender, EventArgs e)
        {
            ListTable();
            ekle.Visible = false;
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            ekle.Visible = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            SetupStage5 st5 = new SetupStage5();
            st5.SetupComponents(f);
            Application.OpenForms[0].Controls[1].Dispose();
            Application.OpenForms[0].Controls.Add(st5.GetPanel());
            st5.StartProcess();
        }

        protected void ListTable()
        {
            data.DataSource = ConnectionMemory.conn.GetManager().GetData("select id, sicilno as 'Sicil No', kadro as 'Kadro', unvan as 'Unvan', name as 'Ad', surname as 'Soyad', tcno as 'TC', adres as 'Adres', telno as 'Telefon', eposta as 'Email' from Personals");
        }


        public Panel GetPanel() => panel;

    }
}
