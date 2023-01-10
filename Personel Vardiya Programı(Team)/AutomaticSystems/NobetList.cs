using SoliteraxControlLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Data;
using static Personel_Vardiya_Programı_Team_.SetupForm;
using System.Threading;

namespace Personel_Vardiya_Programı_Team_.AutomaticSystems
{
    public class NobetList : FlowLayoutPanel
    {

        Panel panel = new Panel();
        FlowLayoutPanel panel2 = new FlowLayoutPanel();

        //Ust bilgiler
        CustomLabel label1 = new CustomLabel();
        CustomLabel label2 = new CustomLabel();
        CustomLabel label3 = new CustomLabel();
        CustomLabel label4 = new CustomLabel();
        CustomLabel label5 = new CustomLabel();

        public NobetList() : base()
        {
            InitializeComponents();
        }


        public void InitializeComponents()
        {
            this.Size = new Size(1046, 413);

            panel.Dock = DockStyle.Top;
            panel.Size = new Size(this.Size.Width, (int)(this.Size.Height * 0.1f));
            panel.Location = new Point(0,0);
            panel.BackColor = Color.Orchid;

            label1.Size = new Size(panel.Size.Width / 6, panel.Size.Height);
            label1.Location = new Point(label1.Size.Width, 0);
            label1.BackColor = panel.BackColor;
            label1.ForeColor = this.ForeColor;
            label1.Name = "label1";
            label1.Text = "00:00 - 08:00";
            label1.TextAlign = ContentAlignment.BottomCenter;

            label2.Size = label1.Size;
            label2.Location = new Point(label1.Location.X + label1.Size.Width, 0);
            label2.BackColor = label1.BackColor;
            label2.ForeColor = this.ForeColor;
            label2.Name = "label2";
            label2.Text = "08:00 - 16:00";
            label2.TextAlign = label1.TextAlign;

            label3.Size = label1.Size;
            label3.Location = new Point(label2.Location.X + label2.Size.Width, 0);
            label3.BackColor = label1.BackColor;
            label3.ForeColor = this.ForeColor;
            label3.Name = "label3";
            label3.Text = "16:00 - 00:00";
            label3.TextAlign = label1.TextAlign;

            label4.Size = label1.Size;
            label4.Location = new Point(label3.Location.X + label3.Size.Width, 0);
            label4.BackColor = label1.BackColor;
            label4.ForeColor = this.ForeColor;
            label4.Name = "label4";
            label4.Text = "08:00 - 16:00";
            label4.TextAlign = label1.TextAlign;

            label5.Size = label1.Size;
            label5.Location = new Point(label4.Location.X + label4.Size.Width, 0);
            label5.BackColor = label1.BackColor;
            label5.ForeColor = this.ForeColor;
            label5.Name = "label5";
            label5.Text = "09:00 - 17:00";
            label5.TextAlign = label1.TextAlign;

            panel.Controls.AddRange(new Control[] { label1, label2, label3, label4, label5 });

            panel2.Size = new Size(this.Size.Width, this.Size.Height - panel.Size.Height);
            panel2.Location = new Point(0, panel.Size.Height);
            panel2.BackColor = this.BackColor;
            panel2.FlowDirection = FlowDirection.TopDown;
            DataTable dt = ConnectionMemory.conn.GetManager().GetData("select * from Nobet" + DateTime.Now.Month);

            foreach(DataRow row in dt.Rows)
            {
                NobetListItem item = new NobetListItem(row, panel2.Size);
                item.BackColor = this.BackColor;
                item.ForeColor = this.ForeColor;
                if (panel2.Controls.Count < 1)
                {
                    panel2.Controls.Add(item);
                    continue;
                }
                panel2.Controls.Add(item);
            }
            Thread.Sleep(1000);

            this.Controls.Add(panel);
            this.Controls.Add(panel2);
        }


    }
}
