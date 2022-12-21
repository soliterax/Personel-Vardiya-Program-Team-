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
        protected CustomTextBox dataName = new CustomTextBox();
        protected CustomTextBox dataSurname = new CustomTextBox();
        protected CustomTextBox dataTelno = new CustomTextBox();
        protected CustomTextBox dataTarih = new CustomTextBox();

        protected CustomButton saveButton = new CustomButton();
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

            dataName.Size = new Size((panel.Size.Width / 5), (int)(panel.Size.Height * 0.1f));
            dataName.Location = new Point(0, data.Location.X + data.Size.Height);
            dataName.Name = "dataName";
            dataName.BackColor = panel.BackColor;
            dataName.ForeColor = Color.White;
            dataName.BorderColor = Color.MediumSlateBlue;
            dataName.BorderRadius = 0;
            dataName.BorderSize = 2;
            dataName.PlaceholderText = "Name";
            dataName.Font = new Font("Comic Sans MS", dataName.Size.Height / 3.86f, FontStyle.Bold);

            dataSurname.Size = dataName.Size;
            dataSurname.Location = new Point(dataName.Location.X + dataName.Size.Width, dataName.Location.Y);
            dataSurname.Name = "dataSurname";
            dataSurname.BackColor = dataName.BackColor;
            dataSurname.ForeColor = dataName.ForeColor;
            dataSurname.BorderColor = dataName.BorderColor;
            dataSurname.BorderRadius = dataName.BorderRadius;
            dataSurname.BorderSize = dataName.BorderSize;
            dataSurname.PlaceholderText = "Surname";
            dataSurname.Font = dataName.Font;

            dataTelno.Size = dataName.Size;
            dataTelno.Location = new Point(dataSurname.Location.X + dataSurname.Size.Width, dataName.Location.Y);
            dataTelno.Name = "dataTelno";
            dataTelno.BackColor = dataName.BackColor;
            dataTelno.ForeColor = dataName.ForeColor;
            dataTelno.BorderColor = dataName.BorderColor;
            dataTelno.BorderRadius = dataName.BorderRadius;
            dataTelno.BorderSize = dataName.BorderSize;
            dataTelno.PlaceholderText = "Phone";
            dataTelno.Font = dataName.Font;

            dataTarih.Size = dataName.Size;
            dataTarih.Location = new Point(dataTelno.Location.X + dataTelno.Size.Width, dataName.Location.Y);
            dataTarih.Name = "dataTarih";
            dataTarih.BackColor = dataName.BackColor;
            dataTarih.ForeColor = dataName.ForeColor;
            dataTarih.BorderColor = dataName.BorderColor;
            dataTarih.BorderRadius = dataName.BorderRadius;
            dataTarih.BorderSize = dataName.BorderSize;
            dataTarih.PlaceholderText = "Birthday";
            dataTarih.Font = dataName.Font;

            saveButton.Size = dataName.Size;
            saveButton.Location = new Point(dataTarih.Location.X + dataTarih.Size.Width, dataName.Location.Y);
            saveButton.BackColor = dataName.BackColor;
            saveButton.ForeColor = dataName.ForeColor;
            saveButton.TextColor = dataName.ForeColor;
            saveButton.BorderColor = dataName.BorderColor;
            saveButton.BorderSize = dataName.BorderSize;
            saveButton.BorderRadius = dataName.BorderRadius;
            saveButton.Name = "saveButton";
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;

            nextButton.Size = saveButton.Size;
            nextButton.Location = new Point((panel.Size.Width / 2) - (nextButton.Size.Width / 2), dataName.Location.Y + dataName.Size.Height + 5);
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
            panel.Controls.AddRange(new Control[] {dataName, dataSurname, dataTelno, dataTarih, saveButton, nextButton});

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
            data.DataSource = ConnectionMemory.conn.GetManager().GetData("select id, name as 'Ad', surname as 'Soyad', telno as 'Telefon', dtarih as 'Doğum Tarihi' from Personals");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(dataName.Texts.Equals("") && dataSurname.Texts.Equals("") && dataTelno.Texts.Equals("") && dataTarih.Texts.Equals(""))
            {
                return;
            }
            ConnectionMemory.conn.GetManager().SendData($"insert into Personals(name, surname, telno, dtarih) values ('{dataName.Texts.ToString()}', '{dataSurname.Texts.ToString()}', '{dataTelno.Texts.ToString()}', '{dataTarih.Texts.ToString()}')");
            ListTable();
        }

        public Panel GetPanel() => panel;

    }
}
