using Bunifu.Framework.UI;
using SoliteraxControlLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Vardiya_Programı_Team_.Layouts.SetupPanels
{
    public class SetupStage5
    {
        SetupForm f;
        protected CustomPanel panel = new CustomPanel();

        protected BunifuCircleProgressbar bar = new BunifuCircleProgressbar();
        protected CustomLabel label = new CustomLabel();

        public void SetupComponents(SetupForm s)
        {

            f = s;

            panel.Size = new Size(s.Width, (int)(s.Height * 0.95));
            panel.Location = new Point(0, 0);
            panel.Name = "setup4";
            panel.haveBorder = false;
            panel.haveEllipse = false;
            panel.BackColor = s.BackColor;

            bar.Size = new Size((int)(panel.Size.Height / 2), (int)(panel.Size.Height / 2));
            bar.Location = new Point((panel.Size.Width / 2) - (bar.Size.Width / 2), (panel.Size.Height / 2) - (bar.Size.Height / 2));
            bar.Name = "bar";
            bar.MaxValue = 100;
            bar.Value = 10;
            bar.BackColor = panel.BackColor;
            bar.ForeColor = Color.White;
            bar.animated = true;
            bar.animationIterval = 3;
            bar.animationSpeed = 1;
            
            

            label.Size = new Size(panel.Size.Width, (int)(panel.Size.Height * 0.1f));
            label.Location = new Point(0, bar.Location.Y + bar.Size.Height);
            label.Name = "label";
            label.haveBorder = false;
            label.BackColor = panel.BackColor;
            label.ForeColor = Color.White;
            label.Font = new Font("Comic Sans MS", 15, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "Sizin için herşeyi hazır hale getiriyoruz.";


            panel.Controls.AddRange(new Control[] { bar, label });

        }

      

        public void StartProcess()
        {
            Thread th = new Thread(() =>
            {

                label.Text = "Sizin için Herşeyi Hazır Hale Getiriyoruz...";
                bar.Value += 0;
                Thread.Sleep(5000);
                //güncelleme kontrol kodları
                bar.Value += 20;
                Thread.Sleep(2000);
                bar.Value += 20;
                Thread.Sleep(5000);
                bar.Value += 60;
                

            });

            th.Start();
            th.Join();
            MainForm main = new MainForm();
            main.Show();
            f.Hide();
            panel.Dispose();
            Application.OpenForms[0].Controls[0].Dispose();
        }

        public Panel GetPanel() => panel;

    }
}
