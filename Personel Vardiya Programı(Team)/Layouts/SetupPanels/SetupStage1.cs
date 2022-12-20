using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoliteraxControlLibrary;
using SoliteraxLibrary;
using SoliteraxLibrary.SQLSystem;

namespace Personel_Vardiya_Programı_Team_.Layouts.SetupPanels
{
    public class SetupStage1
    {

        SetupForm f;

        CustomPanel setup1 = new CustomPanel();
        CustomTextBox setup1IPAdress = new CustomTextBox();
        CustomComboBox setup1DatabaseType = new CustomComboBox();
        CustomTextBox setup1Username = new CustomTextBox();
        CustomTextBox setup1Password = new CustomTextBox();
        CustomTextBox setup1DatabaseName = new CustomTextBox();
        CustomButton setup1NextButton = new CustomButton();

        public void setupComponents(SetupForm s)
        {
            f = s;
            #region Setup Stage 1 Component Configuration

            //Setup Stage 1 components
            setup1.Size = new Size(s.Width, (int)(s.Height * 0.95));
            setup1.Location = new Point(0, 0);
            setup1.Name = "setup1";
            setup1.haveBorder = false;
            setup1.haveEllipse = false;

            //Setup1 IP box component
            setup1IPAdress.Size = new Size((int)((setup1.Width / 2) - (setup1.Width * 0.2)), (int)(setup1.Height * 0.1));
            setup1IPAdress.Location = new Point((setup1.Width / 2) - ((int)(setup1.Height * 0.1) + setup1IPAdress.Size.Width), (setup1IPAdress.Height));
            setup1IPAdress.Name = "setup1IPAdress";
            setup1IPAdress.UnderlinedStyle = true;
            setup1IPAdress.BorderSize = 2;
            setup1IPAdress.BackColor = ColorTranslator.FromHtml("#353535");
            setup1IPAdress.PlaceholderText = "Sunucu IP";
            setup1IPAdress.ForeColor = Color.White;
            setup1IPAdress.TabIndex = 0;
            setup1IPAdress.Texts = "haxtar.database.windows.net";

            //Setup1 Database Name Component
            setup1DatabaseName.Size = new Size(setup1IPAdress.Width, setup1IPAdress.Height);
            setup1DatabaseName.Location = new Point((setup1.Width / 2) + ((int)(setup1.Height * 0.1)), (setup1IPAdress.Height));
            setup1DatabaseName.Name = "setup1DatabaseName";
            setup1DatabaseName.BorderSize = setup1IPAdress.BorderSize;
            setup1DatabaseName.BackColor = setup1IPAdress.BackColor;
            setup1DatabaseName.ForeColor = Color.White;
            setup1DatabaseName.PlaceholderColor = setup1IPAdress.PlaceholderColor;
            setup1DatabaseName.PlaceholderText = "Database Adı";
            setup1DatabaseName.UnderlinedStyle = setup1IPAdress.UnderlinedStyle;
            setup1DatabaseName.TabIndex = 1;
            setup1DatabaseName.Texts = "Vardiya";

            //Setup1 Database Username component
            setup1Username.Size = new Size(setup1IPAdress.Width, setup1IPAdress.Height);
            setup1Username.Location = new Point(setup1IPAdress.Location.X, setup1IPAdress.Location.Y + setup1IPAdress.Size.Height + setup1IPAdress.Height);
            setup1Username.Name = "setup1Username";
            setup1Username.UnderlinedStyle = setup1IPAdress.UnderlinedStyle;
            setup1Username.BorderSize = setup1IPAdress.BorderSize;
            setup1Username.BackColor = setup1IPAdress.BackColor;
            setup1Username.PlaceholderColor = setup1IPAdress.PlaceholderColor;
            setup1Username.PlaceholderText = "Database Kullanıcı Adı";
            setup1Username.ForeColor = Color.White;
            setup1Username.TabIndex = 2;
            setup1Username.Texts = "haxtar";

            //Setup1 Database Password Component
            setup1Password.Size = new Size(setup1IPAdress.Width, setup1IPAdress.Height);
            setup1Password.Location = new Point(setup1DatabaseName.Location.X, setup1DatabaseName.Location.Y + setup1DatabaseName.Size.Height + setup1IPAdress.Height);
            setup1Password.Name = "setup1Password";
            setup1Password.UnderlinedStyle = setup1IPAdress.UnderlinedStyle;
            setup1Password.BorderSize = setup1IPAdress.BorderSize;
            setup1Password.BackColor = setup1IPAdress.BackColor;
            setup1Password.PlaceholderColor = setup1IPAdress.PlaceholderColor;
            setup1Password.PlaceholderText = "Database Sifre";
            setup1Password.ForeColor = Color.White;
            setup1Password.TabIndex = 3;
            setup1Password.PasswordChar = true;
            setup1Password.Texts = "Bb39676321436";

            //Setup1 Database Port Component
            setup1DatabaseType.Size = new Size(setup1IPAdress.Width, setup1IPAdress.Height);
            setup1DatabaseType.Location = new Point((setup1.Width / 2) - (setup1DatabaseType.Width / 2), setup1Password.Location.Y + setup1Password.Size.Height + setup1IPAdress.Height);
            setup1DatabaseType.Name = "setup1Port";
            setup1DatabaseType.BorderSize = setup1IPAdress.BorderSize;
            setup1DatabaseType.BackColor = setup1IPAdress.BackColor;
            setup1DatabaseType.ForeColor = Color.White;
            setup1DatabaseType.Items.AddRange(new string[] { "SQL", "MySQL", "Access" });
            setup1DatabaseType.TabIndex = 4;
            setup1DatabaseType.Texts = "SQL";

            //Setup1 Next Button Component
            setup1NextButton.Size = setup1DatabaseType.Size;
            setup1NextButton.Location = new Point((setup1.Width / 2) - (setup1NextButton.Width / 2), (setup1.Height - setup1NextButton.Height) - setup1IPAdress.Height);
            setup1NextButton.Name = "setup1NextButton";
            setup1NextButton.BorderSize = 1;
            setup1NextButton.BorderColor = Color.MediumSlateBlue;
            setup1NextButton.BorderRadius = 10;
            setup1NextButton.BackColor = setup1.BackColor;
            setup1NextButton.Text = "Sıradaki";
            setup1NextButton.Click += Setup1NextButton_Click;
            setup1NextButton.ForeColor = Color.White;

            #endregion

            #region Setup 1 Component Registy
            //Register Sub Components the Main Panels
            setup1.Controls.Add(setup1IPAdress);
            setup1.Controls.Add(setup1DatabaseType);
            setup1.Controls.Add(setup1Username);
            setup1.Controls.Add(setup1Password);
            setup1.Controls.Add(setup1DatabaseName);
            setup1.Controls.Add(setup1NextButton);
            #endregion
            SoliteraxLibrary.FileSystem.SoliteraxFile file = new SoliteraxLibrary.FileSystem.SoliteraxFile(Environment.CurrentDirectory + "\\connection.txt");
            SonsuzLock sl = new SonsuzLock("h@xt@r", 3);
            //MessageBox.Show(sl.sifrecoz(file.Read()), "Şifre Kırıldı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Setup1NextButton_Click(object sender, EventArgs e)
        {
            
            MainForm form = new MainForm();
            f.setupAddProgress(10);
            f.setupSetProgressText("Kurulum Yapılıyor...");
            if (!setup1IPAdress.Texts.Equals(""))
            {
                ConnectDatabase db = new ConnectDatabase($"Data Source={setup1IPAdress.Texts};Initial Catalog={setup1DatabaseName.Texts};User ID={setup1Username.Texts};Password={setup1Password.Texts}", (setup1DatabaseType.Texts.Equals("SQL")) ? SoliteraxConnection.ConnectionType.SQL : SoliteraxConnection.ConnectionType.Access);
                //ConnectDatabase db = new ConnectDatabase($"Data Source=server.soliterax.com;Initial Catalog=Vardiya;User ID=haxtar;Password=Bb39676321436", SoliteraxConnection.ConnectionType.SQL);
                SetupForm.ConnectionMemory.conn = db;
                SetupStage2 ss2 = new SetupStage2();
                ss2.setupComponent(f);
                Application.OpenForms[0].Controls[0].Dispose();
                Application.OpenForms[0].Controls.Add(ss2.GetPanel());
                GC.Collect();
                ss2.StartSetup();
                
                
            }
            
        }

        
        public CustomPanel getPanel()
        {
            return setup1;
        }


    }
}
