using SoliteraxControlLibrary;
using SoliteraxLibrary.FileSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Vardiya_Programı_Team_.Layouts.SetupPanels
{
    public class SetupControl
    {

        SetupForm f;

        protected CustomPanel panel = new CustomPanel();
        
        protected CustomLabel label = new CustomLabel();

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
            label.Location = new Point(0, (panel.Size.Height / 2) - (label.Size.Height / 2));
            label.Name = "";
            label.Text = "Personel Vardiya Programı\n" + str[0];
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.White;
            label.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(label);

            t.Interval = 1500;
            t.Tick += T_Tick;
        }

        string[] str = new string[4] { "Denetleniyor...", "Güncellemeler Kontrol Ediliyor...", "Bağlantı Sağlanıyor...", "Başlatılıyor..." };

        public void StartInitialize() => t.Start();

        int s = 0;

        private void T_Tick(object sender, EventArgs e)
        {
           s++;
            if(s < str.Length)
                label.Text = "Personel Vardiya Programı\n" + str[s];
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
                this.f.Controls.Clear();
                GC.Collect();
            }
        }

        public Panel GetPanel() => panel;

    }
}
