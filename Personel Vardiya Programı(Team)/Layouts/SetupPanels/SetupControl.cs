using SoliteraxControlLibrary;
using SoliteraxLibrary;
using SoliteraxLibrary.FileSystem;
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
    public class SetupControl
    {

        SetupForm f;

        protected CustomPanel panel = new CustomPanel();

        protected CustomLabel label = new CustomLabel();
        protected CustomLabel row = new CustomLabel();

        Timer t = new Timer();

        public void setupComponents(SetupForm s)
        {
            f = s;

            panel.Size = new Size(s.Width, (int)(s.Height * 0.95));
            panel.Location = new Point(0, 0);
            panel.Name = "setup4";
            panel.haveBorder = false;
            panel.haveEllipse = false;
            panel.BackColor = s.BackColor;

            label.Size = new Size(panel.Width, (int)(panel.Size.Height * 0.2f));
            label.Location = new Point(0, 0);
            label.Name = "Header";
            label.Text = "Personel Vardiya Programı";
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.MediumSlateBlue;
            label.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;

            row.Size = label.Size;
            row.Location = new Point(0, panel.Size.Height - row.Size.Height);
            row.Name = "Row";
            row.Text = str[0];
            row.BackColor = label.BackColor;
            row.ForeColor = label.ForeColor;
            row.Font = new Font("Comic Sans MS", 15, FontStyle.Italic);
            row.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(label);
            panel.Controls.Add(row);

            this.f.setupAddProgress(25);

            t.Interval = 1500;
            t.Tick += T_Tick;
        }

        string[] str = new string[4] { "Denetleniyor...", "Güncellemeler Kontrol Ediliyor...", "Bağlantı Sağlanıyor...", "Başlatılıyor..." };

        public void StartInitialize() => t.Start();

        int s = 0;

        private void T_Tick(object sender, EventArgs e)
        {
            s++;
            this.f.setupAddProgress(25);
            if (s < str.Length)
                row.Text = str[s];
            if(s == 2)
            {
                SoliteraxLibrary.FileSystem.SoliteraxFile file = new SoliteraxLibrary.FileSystem.SoliteraxFile(Environment.CurrentDirectory + "\\connection.txt");
                SonsuzLock sl = new SonsuzLock("h@xt@r", 3);
                string s = sl.sifrecoz(file.Read());
                ConnectionMemory.conn = new SoliteraxLibrary.SQLSystem.ConnectDatabase(s, SoliteraxConnection.ConnectionType.SQL).Connect();
            }
            if (s == 4)
            {
                if (new SoliteraxFile(Environment.CurrentDirectory + "\\connection.txt").Read().Length <= 0)
                {
                    SetupStage1 st1 = new SetupStage1();
                    st1.setupComponents(this.f);
                    this.f.Controls[0].Dispose();
                    return;
                }
                t.Stop();
                MainForm f = new MainForm();
                this.f.Hide();
                f.Show();
                this.f.Controls[1].Dispose();
                this.f.Controls[0].Dispose();
                GC.Collect();
            }
        }

        public Panel GetPanel() => panel;

    }
}