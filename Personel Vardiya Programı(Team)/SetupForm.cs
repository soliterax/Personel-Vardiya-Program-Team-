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
using SoliteraxLibrary.SQLSystem;
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
        CustomPanel setup1 = new CustomPanel();
        CustomTextBox setup1IPAdress = new CustomTextBox();
        CustomTextBox setup1DatabaseName = new CustomTextBox();
        CustomTextBox setup1Username = new CustomTextBox();
        CustomTextBox setup1Password = new CustomTextBox();
        CustomTextBox setup1Port = new CustomTextBox();
        CustomButton setup1NextButton = new CustomButton();

        //Setup Stage 2 Components Registry
        CustomPanel setup2 = new CustomPanel();
        
        //Setup Stage 3 Components Registry
        CustomPanel setup3 = new CustomPanel();

        //Setup Progress Bar
        CustomProgressbar bar = new CustomProgressbar();
        CustomLabel progressText = new CustomLabel();

        void setupComponents()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * 0.6);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.5);

            #region Setup Stage 1 Component Configuration

            //Setup Stage 1 components
            setup1.Size = new Size(this.Width, (int)(this.Height * 0.95));
            setup1.Location = new Point(0, 0);
            setup1.Name = "setup1";
            setup1.haveBorder = false;
            setup1.haveEllipse = false;

            //Setup1 IP box component
            setup1IPAdress.Size = new Size((int)((setup1.Width / 2 ) - (setup1.Width * 0.2)) , (int)(setup1.Height * 0.1));
            setup1IPAdress.Location = new Point((setup1.Width / 2) - ((int)(setup1.Height * 0.1) + setup1IPAdress.Size.Width), (setup1IPAdress.Height));
            MessageBox.Show(setup1IPAdress.Location.X.ToString() + " | " + setup1IPAdress.Location.Y.ToString());
            setup1IPAdress.Name = "setup1IPAdress";
            setup1IPAdress.UnderlinedStyle = true;
            setup1IPAdress.BorderSize = 2;
            setup1IPAdress.BackColor = ColorTranslator.FromHtml("#353535");
            setup1IPAdress.PlaceholderText = "Sunucu IP";
            setup1IPAdress.ForeColor = Color.White;

            //Setup1 Database Name Component
            setup1DatabaseName.Size = new Size(setup1IPAdress.Width, setup1IPAdress.Height);
            setup1DatabaseName.Location = new Point((setup1.Width / 2) + ((int)(setup1.Height * 0.1)), (setup1IPAdress.Height));
            setup1DatabaseName.Name = "setup1DatabaseName";
            setup1DatabaseName.UnderlinedStyle = setup1IPAdress.UnderlinedStyle;
            setup1DatabaseName.BorderSize = setup1IPAdress.BorderSize;
            setup1DatabaseName.BackColor = setup1IPAdress.BackColor;
            setup1DatabaseName.PlaceholderColor = setup1IPAdress.PlaceholderColor;
            setup1DatabaseName.PlaceholderText = "Database Adı";
            setup1DatabaseName.ForeColor = Color.White;

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


            //Setup1 Database Port Component
            setup1Port.Size = new Size(setup1IPAdress.Width, setup1IPAdress.Height);
            setup1Port.Location = new Point((setup1.Width / 2) - (setup1Port.Width / 2), setup1Password.Location.Y + setup1Password.Size.Height + setup1IPAdress.Height);
            setup1Port.Name = "setup1Port";
            setup1Port.UnderlinedStyle = setup1IPAdress.UnderlinedStyle;
            setup1Port.BorderSize = setup1IPAdress.BorderSize;
            setup1Port.BackColor = setup1IPAdress.BackColor;
            setup1Port.PlaceholderColor = setup1IPAdress.PlaceholderColor;
            setup1Port.PlaceholderText = "Database Port";
            setup1Port.ForeColor = Color.White;

            //Setup1 Next Button Component
            setup1NextButton.Size = setup1Port.Size;
            setup1NextButton.Location = new Point((setup1.Width / 2) - (setup1NextButton.Width / 2), (setup1.Height - setup1NextButton.Height) - setup1IPAdress.Height);
            setup1NextButton.Name = "setup1NextButton";
            setup1NextButton.BorderSize = 1;
            setup1NextButton.BorderColor = Color.MediumSlateBlue;
            setup1NextButton.BorderRadius = 10;
            setup1NextButton.BackColor = this.BackColor;
            setup1NextButton.Text = "Sıradaki";
            setup1NextButton.Click += Setup1NextButton_Click;
            setup1NextButton.ForeColor = Color.White;

            #endregion

            #region Stage 2 Component Configuration

            //Setup Stage 2 Component
            setup2.Size = new Size(this.Width, (int)(this.Height * 0.95));
            setup2.Location = new Point(0, 0);
            setup2.Name = "setup1";
            setup2.haveBorder = false;
            setup2.haveEllipse = false;

            #endregion

            #region Setup 1 Component Registy
            //Register Sub Components the Main Panels
            setup1.Controls.Add(setup1IPAdress);
            setup1.Controls.Add(setup1DatabaseName);
            setup1.Controls.Add(setup1Username);
            setup1.Controls.Add(setup1Password);
            setup1.Controls.Add(setup1Port);
            setup1.Controls.Add(setup1NextButton);
            #endregion

            //Progress Bar 
            bar.Size = new Size(this.Width, (int)(this.Height * 0.05));
            bar.Location = new Point(0, this.Height - bar.Size.Height);
            bar.Name = "bar";
            bar.BackColor = setup1IPAdress.BackColor;
            bar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bar.Value = 10;
            bar.ShowValue = CustomProgressbar.TextPosition.None;

            progressText.Size = bar.Size;
            progressText.Location = new Point(0, 0);
            progressText.Name = "progressText";
            progressText.BackColor = Color.Transparent;
            progressText.Anchor = AnchorStyles.Left;
            progressText.Font = new Font("Comic Sans MS", 12, FontStyle.Regular);
            progressText.Text = "Kullanıcı Girişi Bekleniyor...";

            bar.Controls.Add(progressText);

            Controls.Add(setup1);
            Controls.Add(bar);
        }

        private void Setup1NextButton_Click(object sender, EventArgs e)
        {
            bar.Value += 10;
            progressText.Text = "Kurulum Yapılıyor...";
            if (bar.Value != 30)
                return;
            MainForm form = new MainForm();
            if (!setup1IPAdress.Texts.Equals(""))
            {
                ConnectDatabase db = new ConnectDatabase($"Data Source={setup1IPAdress.Texts};Initial Catalog={setup1DatabaseName.Texts};User ID={setup1Username.Texts};Password={setup1Password.Texts}", SoliteraxConnection.ConnectionType.SQL);

                db.Connect();
                DatabaseManager dm = db.GetManager();
                DataTable dt = dm.GetData("select * from Personals");
                string result = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    result += dt.Rows[i][0] + " " + dt.Rows[i][1] + " " + dt.Rows[i][2] + " " + dt.Rows[i][3] + Environment.NewLine;
                }
                MessageBox.Show(result);
            }
            form.Show();
            base.Hide();
            this.Hide();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            

            //dm.SendData("insert into Personals(name, surname, phone) values ('Ramazan', 'Solak', '+905667413508')");

        }

    }
}
