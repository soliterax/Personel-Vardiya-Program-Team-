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
    public partial class UserVardiyaControl : UserControl
    {
        public UserVardiyaControl()
        {
            InitializeComponent();
        }

        private void UserVardiyaControl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ConnectionMemory.conn.GetManager().GetData("select * from Personals");
            personelEkle1.kaydetClicked += kaydetClicked;
            if (dataGridView1.Rows.Count < 1)
                return;
            id = (dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value != null) ? int.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value.ToString()) : -1;
        }

        int id = -1;

        private void kaydetClicked(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ConnectionMemory.conn.GetManager().GetData("select * from Personals");
        }

        private void customButton2_Click(object sender, EventArgs e) //geri butonu
        {
            MainMenuUserControl c = new MainMenuUserControl();
            this.Dispose();
            GC.Collect();
            c.Dock = DockStyle.Fill;
            Application.OpenForms[1].Controls.Add(c);
        }

        private void customButton1_Click(object sender, EventArgs e) // kaydet butonu
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    ConnectionMemory.conn.GetManager().SendData($"update Personals set sicilno = '{dataGridView1.Rows[i].Cells[1].Value.ToString()}', " +
                        $"kadro='{dataGridView1.Rows[i].Cells[2].Value.ToString()}', unvan = '{dataGridView1.Rows[i].Cells[3].Value.ToString()}', name ='{dataGridView1.Rows[i].Cells[4].Value.ToString()}', surname='{dataGridView1.Rows[i].Cells[5].Value.ToString()}', tcno='{dataGridView1.Rows[i].Cells[6].Value.ToString()}', adres='{dataGridView1.Rows[i].Cells[7].Value.ToString()}', telno='{dataGridView1.Rows[i].Cells[8].Value.ToString()}', eposta='{dataGridView1.Rows[i].Cells[9].Value.ToString()}'" +
                        $"where id= '{dataGridView1.Rows[i].Cells[0].Value.ToString()}'");
                }
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionMemory.conn.GetManager().SendData($"delete from Personals where id='{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}'");
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
                dataGridView1.Rows[0].Cells[0].Value = 0;
            else if(dataGridView1.Rows.Count == 2)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = 1;
            }
            else
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = int.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString()) + 1;
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            personelEkle1.Visible = true;

        }
    }
}
