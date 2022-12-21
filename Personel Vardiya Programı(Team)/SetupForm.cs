using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Personel_Vardiya_Programı_Team_.Database_Connection;
using SoliteraxLibrary;
using SoliteraxControlLibrary;
using Bunifu;
using Bunifu.UI;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using SoliteraxLibrary.SQLSystem;
using Personel_Vardiya_Programı_Team_.Layouts.SetupPanels;
using System.IO;

namespace Personel_Vardiya_Programı_Team_
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
            setupComponents();
        }


        CustomLabel label = new CustomLabel();

        //Setup Stage 1 Components Registry
        SetupControl st1 = new SetupControl();

        //Setup Stage 2 Components Registry
        CustomPanel setup2 = new CustomPanel();

        //Setup Stage 3 Components Registry
        CustomPanel setup3 = new CustomPanel();

        //Setup Progress Bar
        Bunifu.UI.Winforms.BunifuProgressBar bar = new Bunifu.UI.Winforms.BunifuProgressBar();
        CustomLabel progressText = new CustomLabel();
       
        void setupComponents()
        {

            

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.6);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.5);

            st1.setupComponents(this);


            #region Stage 2 Component Configuration

            //Setup Stage 2 Component
            setup2.Size = new Size(this.Width, (int)(this.Height * 0.95));
            setup2.Location = new Point(0, 0);
            setup2.Name = "setup1";
            setup2.haveBorder = false;
            setup2.haveEllipse = false;

            #endregion



            //Progress Bar 
            bar.Size = new Size(this.Width, (int)(this.Height * 0.05));
            bar.Location = new Point(0, this.Height - bar.Size.Height);
            bar.Name = "bar";
            bar.ProgressBackColor = st1.GetPanel().BackColor;
            bar.ProgressColorLeft = Color.MediumSlateBlue;
            bar.ProgressColorRight = Color.MediumSlateBlue;
            bar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bar.Value = 0;
            bar.Animation = 4;
            bar.AnimationStep = 10;
            bar.BackgroundImage = ((System.Drawing.Image)(new System.ComponentModel.ComponentResourceManager(typeof(SetupForm)).GetObject("bunifuProgressBar1.BackgroundImage")));
            bar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            bar.BorderRadius = 5;
            bar.BorderThickness = 2;
            bar.MaximumValue = 100;
            bar.MinimumValue = 0;



            progressText.Size = bar.Size;
            progressText.Location = new Point(0, 0);
            progressText.Name = "progressText";
            progressText.BackColor = Color.Transparent;
            progressText.Anchor = AnchorStyles.Left;
            progressText.Font = new Font("Comic Sans MS", 12, FontStyle.Regular);
            progressText.Text = "Kullanıcı Girişi Bekleniyor...";

            bar.Controls.Add(progressText);

            Controls.Add(st1.GetPanel());
            Controls.Add(bar);
            st1.StartInitialize();
        }

        public void setupAddProgress(int value)
        {
            bar.Value += value;
        }

        public void setupSetProgressText(string text)
        {
            progressText.Text = text;
        }



        private void SetupForm_Load(object sender, EventArgs e)
        {


            //dm.SendData("insert into Personals(name, surname, phone) values ('Ramazan', 'Solak', '+905667413508')");

        }

        public class CustomDataView : CustomPanel
        {

            CustomPanel upPanel = new CustomPanel();
            CustomPanel centerPanel = new CustomPanel();

            public CustomDataView()
            {

            }

            protected void setupComponents()
            {
                if (base.Controls.Count > 0)
                {
                    base.Controls.Clear();
                    GC.Collect();
                }


            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                setupComponents();
            }

            public class CustomDataViewElement : CustomPanel
            {

                Control[] controls;

                public CustomDataViewElement()
                {

                }

                public CustomDataViewElement(Control[] args)
                {
                    controls = args;
                }

                public Control[] Items
                {
                    get
                    {
                        return controls;
                    }
                    set
                    {
                        this.controls = value;
                        base.Invalidate();
                    }
                }

                protected override void OnPaint(PaintEventArgs e)
                {
                    base.OnPaint(e);
                }

            }
        }

        public static class ConnectionMemory
        {
            public static ConnectDatabase conn;
        }

    }
}
