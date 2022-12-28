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
    public partial class PersonelEkle : UserControl
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            ConnectionMemory.conn.GetManager().SendData("insert into Personals(sicilno,kadro, unvan, name, surname, tcno, adres, telno, eposta ) values(" +
                $"'{sicilno.Texts}', '{kadro.Texts}', '{unvan.Texts}', '{name.Texts}', '{surname.Texts}', '{tcno.Texts}', '{adres.Texts}', '{telno.Texts}', '{eposta.Texts}'" +
                ")");
            sicilno.Texts = "";
            kadro.Texts = "";
            unvan.Texts = "";
            name.Texts = "";
            surname.Texts = "";
            tcno.Texts = "";
            adres.Texts = "";
            telno.Texts = "";
            eposta.Texts = "";
            this.Visible = false;
            kaydetClicked.Invoke(null, null);
        }

        public EventHandler kaydetClicked;

    }
}
