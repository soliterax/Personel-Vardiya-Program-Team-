using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Personel_Vardiya_Programı_Team_.SetupForm;

namespace Personel_Vardiya_Programı_Team_.Layouts
{
    public partial class UsersUserControl : UserControl
    {
        public UsersUserControl()
        {
            InitializeComponent();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

            //Main Menu Lazım
            MainMenuUserControl c = new MainMenuUserControl();
            this.Dispose();
            GC.Collect();
            c.Dock = DockStyle.Fill;
            Application.OpenForms[1].Controls.Add(c);

        }
        protected void ListTable()
        {
            data.DataSource = ConnectionMemory.conn.GetManager().GetData("select id, name as 'Ad', surname as 'Soyad', telno as 'Telefon', dtarih as 'doğum tarihi' from Personals");

        }

        private void customButton3_Click(object sender, EventArgs e) // sil
        {
            
            if (dataName.Texts.Equals("") && dataSurname.Texts.Equals("") && dataTelno.Texts.Equals("") && dataTarih.Texts.Equals(""))
            {
                return;
            }
            ConnectionMemory.conn.GetManager().SendData($"delete from Personals(name, surname, telno, dtarih) where id = {dataid.Texts.ToString()}");
            ListTable();
            
        }

        private void customButton1_Click(object sender, EventArgs e) // kaydet
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
            if (dataTarih.Texts.Equals(""))
            {
                dataTarih.BorderColor = Color.Red;
                return;
            }
            ConnectionMemory.conn.GetManager().SendData($"insert into Personals(name, surname, telno, dtarih) values ('{dataName.Texts.ToString()}', '{dataSurname.Texts.ToString()}', '{dataTelno.Texts.ToString()}', '{dataTarih.Texts.ToString()}')");
            ListTable();
            
        }

        private void customtextBox_TextChanged(object sender, EventArgs e) // name
        {
            
        }

        private void customtextBox1_TextChanged(object sender, EventArgs e) // surname
        {
            
        }

        private void UsersUserControl_Load(object sender, EventArgs e)
        {
            ListTable();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataid.Texts = data.CurrentRow.Cells[0].Value.ToString();
            dataName.Text = data.CurrentRow.Cells[1].Value.ToString();
            dataSurname.Text = data.CurrentRow.Cells[2].Value.ToString();
            dataTelno.Text = data.CurrentRow.Cells[3].Value.ToString();
            dataTarih.Text = data.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
