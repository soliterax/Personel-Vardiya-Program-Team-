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
            data.DataSource = ConnectionMemory.conn.GetManager().GetData("select id, name as 'Ad', surname as 'Soyad', telno as 'Telefon', username as 'Kullanıcı Adı', password as 'Şifre', perm as 'Yetki' from Users");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListTable();
        }

        private void customButton3_Click(object sender, EventArgs e) // sil
        {
            if (dataName.Texts.Equals("") && dataSurname.Texts.Equals("") && dataTelno.Texts.Equals("") && dataTarih.Texts.Equals(""))
            {
                return;
            }
            ConnectionMemory.conn.GetManager().SendData($"delete from Personals(name, surname, telno, dtarih) values ('{dataName.Texts.ToString()}', '{dataSurname.Texts.ToString()}', '{dataTelno.Texts.ToString()}', '{dataTarih.Texts.ToString()}')");
            ListTable();
        }

        private void customButton1_Click(object sender, EventArgs e) // kaydet
        {
            if (dataName.Texts.Equals("") && dataSurname.Texts.Equals("") && dataTelno.Texts.Equals("") && dataTarih.Texts.Equals(""))
            {
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
    }
}
