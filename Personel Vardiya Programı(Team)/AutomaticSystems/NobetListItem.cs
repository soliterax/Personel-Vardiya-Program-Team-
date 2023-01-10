using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static Personel_Vardiya_Programı_Team_.AutomaticSystems.AutomaticVardiyaAlgoritm;
using System.Data;
using Personel_Vardiya_Programı_Team_.Base_Class;

namespace Personel_Vardiya_Programı_Team_.AutomaticSystems
{
    public class NobetListItem : Panel
    {

        DataRow dr;
        public NobetListItem(DataRow personal, Size s) : base() { dr = personal;  InitializeComponents(s); }

        Label date = new Label();
        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        Label label4 = new Label();
        Label label5 = new Label();

        public void InitializeComponents(Size s)
        {
            this.Size = new Size(s.Width, (int)(s.Height * 0.2f));
            

            date.Size = new Size(s.Width / 6, 0);
            date.Location = new Point(0, 0);
            date.BackColor = this.BackColor;
            date.ForeColor = this.ForeColor;
            date.Name = "date";
            date.Text = dr[0].ToString();

            label1.Size = date.Size;
            label1.Location = new Point(date.Size.Width, 0);
            label1.BackColor = this.BackColor;
            label1.ForeColor = this.ForeColor;
            label1.Name = "label1";
            label1.Text= dr[1].ToString();

            label2.Size = date.Size;
            label2.Location = new Point(label1.Location.X + label1.Size.Width, 0);
            label2.BackColor = this.BackColor;
            label2.ForeColor = this.ForeColor;
            label2.Name = "label2";
            label2.Text = dr[2].ToString();

            label3.Size = date.Size;
            label3.Location = new Point(label2.Location.X + label2.Size.Width, 0);
            label3.BackColor = this.BackColor;
            label3.ForeColor = this.ForeColor;
            label3.Name = "label3";
            label3.Text = dr[3].ToString();

            label4.Size = date.Size;
            label4.Location = new Point(label3.Location.X + label3.Size.Width, 0);
            label4.BackColor = this.BackColor;
            label4.ForeColor = this.ForeColor;
            label4.Name = "label4";
            label4.Text = dr[4].ToString();

            label5.Size = date.Size;
            label5.Location = new Point(label4.Location.X + label4.Size.Width, 0);
            label5.BackColor = this.BackColor;
            label5.ForeColor = this.ForeColor;
            label5.Name = "label5";
            label5.Text = dr[5].ToString();

            this.Controls.AddRange(new Control[] {date, label1, label2, label3, label4, label5});
            MessageBox.Show(dr[0].ToString());
        }

    }
}
