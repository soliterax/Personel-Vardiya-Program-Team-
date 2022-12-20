using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using SoliteraxLibrary;
using SoliteraxLibrary.SQLSystem;
using SoliteraxControlLibrary;
using static Personel_Vardiya_Programı_Team_.SetupForm;
using Bunifu.UI.WinForms;

namespace Personel_Vardiya_Programı_Team_.Layouts.SetupPanels
{
    public class SetupStage3
    {

        protected CustomPanel panel = new CustomPanel();
        protected BunifuDataGridView data = new BunifuDataGridView();
        protected CustomTextBox dataName = new CustomTextBox();
        protected CustomTextBox dataSurname = new CustomTextBox();
        protected CustomTextBox dataTelno = new CustomTextBox();
        protected CustomTextBox dataUsername = new CustomTextBox();
        protected CustomTextBox dataPassword = new CustomTextBox();
        protected CustomComboBox dataPermission = new CustomComboBox();
        protected CustomButton saveButton = new CustomButton();
        protected CustomButton nextButton = new CustomButton();

        SetupForm f;
       
        /// <summary>
        /// get the SetupForm and mysteries calculations and problems we get output the panel yey
        /// </summary>
        /// <param name="s">you must definitly set this or you die from your coding skill</param>
        public void setupComponents(SetupForm s)
        {
            f = s;

            panel.Size = new Size(s.Width, (int)(s.Height * 0.95));
            panel.Location = new Point(0, 0);
            panel.Name = "setup3";
            panel.haveBorder = false;
            panel.haveEllipse = false;
            panel.BackColor = s.BackColor;


            data.Size = new Size(panel.Size.Width , (int)(panel.Size.Height * 0.8));
            data.Location = new Point(0,0);
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


            dataName.Size = new Size((panel.Size.Width / 6), (int)(panel.Size.Height * 0.1f));
            dataName.Location = new Point(0, data.Location.X + data.Size.Height);
            dataName.Name = "dataName";
            dataName.BackColor = panel.BackColor;
            dataName.ForeColor = Color.White;
            dataName.BorderColor = Color.MediumSlateBlue;
            dataName.BorderRadius = 0;
            dataName.BorderSize = 2;
            dataName.PlaceholderText = "Name";
            dataName.Font = new Font("Comic Sans MS", dataName.Size.Height/3.86f, FontStyle.Bold);

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

            dataUsername.Size = dataName.Size;
            dataUsername.Location = new Point(dataTelno.Location.X + dataTelno.Size.Width, dataName.Location.Y);
            dataUsername.Name = "dataUsername";
            dataUsername.BackColor = dataName.BackColor;
            dataUsername.ForeColor = dataName.ForeColor;
            dataUsername.BorderColor = dataName.BorderColor;
            dataUsername.BorderRadius = dataName.BorderRadius;
            dataUsername.BorderSize = dataName.BorderSize;
            dataUsername.PlaceholderText = "Username";
            dataUsername.Font = dataName.Font;

            dataPassword.Size = dataName.Size;
            dataPassword.Location = new Point(dataUsername.Location.X + dataUsername.Size.Width, dataName.Location.Y);
            dataPassword.Name = "dataPassword";
            dataPassword.BackColor = dataName.BackColor;
            dataPassword.ForeColor = dataName.ForeColor;
            dataPassword.BorderColor = dataName.BorderColor;
            dataPassword.BorderRadius = dataName.BorderRadius;
            dataPassword.BorderSize = dataName.BorderSize;
            dataPassword.PlaceholderText = "Password";
            dataPassword.Font = dataName.Font;

            dataPermission.Size = new Size(dataName.Size.Width, dataName.Size.Height - 15);
            dataPermission.Location = new Point(dataPassword.Location.X + dataPassword.Size.Width, dataName.Location.Y);
            dataPermission.Name = "dataPermission";
            dataPermission.BackColor = dataName.BackColor;
            dataPermission.ForeColor = dataName.ForeColor;
            dataPermission.BorderColor = dataName.BorderColor;
            dataPermission.BorderSize = dataName.BorderSize;
            dataPermission.Texts = "";
            dataPermission.Items.AddRange(new string[] {"Yönetici" , "Yetkili", "Çalışan" });


            nextButton.Size = dataName.Size;
            nextButton.Location = new Point((panel.Size.Width / 2) - (nextButton.Size.Width / 2), dataName.Location.Y + dataName.Size.Height + 2);
            nextButton.BackColor = panel.BackColor;
            nextButton.ForeColor = dataName.ForeColor;
            nextButton.TextColor = dataName.ForeColor;
            nextButton.BorderColor = dataName.BorderColor;
            nextButton.BorderSize = 2;
            nextButton.BorderRadius = dataName.BorderRadius;
            nextButton.Name = "nextButton";
            nextButton.Text = "Next";
            nextButton.Click += NextButton_Click;

            saveButton.Size = nextButton.Size;
            saveButton.Location = new Point(panel.Size.Width - saveButton.Size.Width, nextButton.Location.Y);
            saveButton.BackColor = nextButton.BackColor;
            saveButton.ForeColor = nextButton.ForeColor;
            saveButton.TextColor = nextButton.TextColor;
            saveButton.BorderColor = nextButton.BorderColor;
            saveButton.BorderSize = nextButton.BorderSize;
            saveButton.BorderRadius = nextButton.BorderRadius;
            saveButton.Name = "saveButton";
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;

            panel.Controls.Add(data);
            panel.Controls.AddRange(new Control[] {dataName, dataSurname, dataTelno, dataUsername, dataPassword, dataPermission});
            panel.Controls.AddRange(new Control[] { nextButton, saveButton });
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (dataName.Texts.Equals(""))
            {
                dataName.BorderColor = Color.Red;
                return;
            }
            if (dataSurname.Texts.Equals(""))
            {
                dataSurname.BorderColor = Color.Red;
                return;
            }
            if (dataTelno.Texts.Equals(""))
            {
                dataTelno.BorderColor = Color.Red;
                return;
            }
            if (dataUsername.Texts.Equals(""))
            {
                dataUsername.BorderColor = Color.Red;
                return;
            }
            if (dataPassword.Texts.Equals(""))
            {
                dataPassword.BorderColor = Color.Red;
                return;
            }
            if (dataPermission.Texts.Equals(""))
            {
                dataPermission.BorderColor = Color.Red;
                return;
            }
            ConnectionMemory.conn.GetManager().SendData($"insert into Users(name, surname, telno, username, password, perm) values ('{dataName.Texts.ToString()}', '{dataSurname.Texts.ToString()}', '{dataTelno.Texts.ToString()}', '{dataUsername.Texts.ToString()}', '{dataPassword.Texts.ToString()}', '{dataPermission.Texts.ToString()}')");
            ListTable();
        }

        protected void ListTable()
        {
            data.DataSource = ConnectionMemory.conn.GetManager().GetData("select id, name as 'Ad', surname as 'Soyad', telno as 'Telefon', username as 'Kullanıcı Adı', password as 'Şifre', perm as 'Yetki' from Users");
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            f.setupAddProgress(10);
            SetupStage4 st4 = new SetupStage4();
            st4.setupComponents(f);
            Application.OpenForms[0].Controls[1].Dispose();
            Application.OpenForms[0].Controls.Add(st4.GetPanel());

        }

        public Panel GetPanel()
        {
            return panel;
        }

    }
}
