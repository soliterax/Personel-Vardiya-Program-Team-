using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using SoliteraxControlLibrary;
using SoliteraxLibrary;
using SoliteraxLibrary.SQLSystem;

namespace Personel_Vardiya_Programı_Team_.Layouts.SetupPanels
{
    public class SetupStage2
    {

        SetupForm f;
        private CustomPanel panel = new CustomPanel();
        private ListBox box = new ListBox();

        public void setupComponent(SetupForm s)
        {
            f = s;

            panel.Size = new Size(s.Width, (int)(s.Height * 0.95));
            panel.Location = new Point(0, 0);
            panel.Name = "setup1";
            panel.haveBorder = false;
            panel.haveEllipse = false;

            box.Size = panel.Size;
            box.Location = new Point(0, 0);
            box.Name = "box";
            box.ForeColor = Color.Green;
            box.BackColor = s.BackColor;
            box.BorderStyle = BorderStyle.None;
            //box.Font = new Font("Verdana", 15, FontStyle.Bold);
            //box.Font = new Font("Ariel", 15, FontStyle.Bold);
            box.Font = new Font("TW Cen MT", 15, FontStyle.Bold);

            panel.Controls.Add(box);
            
        }
        ConnectDatabase db;
        public void StartSetup()
        {
            Thread thread = new Thread(() =>
                        {


                            box.Items.Add("Veritabanı Ayarlama sistemleri başlatılıyor.");
                            box.Items.Add("Veritabanına bağlanılıyor");
                            f.setupAddProgress(10);
                            Thread.Sleep(1000);
                            db = SetupForm.ConnectionMemory.conn.Connect();
                            box.Items.Add("Veritabanı Tabloları Oluşturuluyor");

                            f.setupAddProgress(10);
                            Thread.Sleep(1000);
                CreateTable("users");
                            f.setupAddProgress(10);
                            Thread.Sleep(1000);
                CreateTable("personals");
                            Thread.Sleep(1000);
                CreateTable("saat");

                            box.Items.Add("Son Ayarlamalar yapılıyor...");
                            f.setupAddProgress(10);
                            Thread.Sleep(1000);
                            SoliteraxLibrary.FileSystem.SoliteraxFile file = new SoliteraxLibrary.FileSystem.SoliteraxFile(Environment.CurrentDirectory + "\\connection.txt");
                            SonsuzLock sl = new SonsuzLock("h@xt@r", 3);
                            file.Write(sl.sifrele(db.GetConnectionKey()));
                            box.Items[box.Items.Count - 1] += "Done!";
                            box.Items.Add("Bitiriliyor...9");
                            for (int i = 9; i >= 0; i--)
                            {
                                f.setupAddProgress(1);
                                if (i == 0)
                                    box.Items[box.Items.Count - 1] = box.Items[box.Items.Count - 1].ToString().Substring(0, box.Items[box.Items.Count - 1].ToString().Length - 1) + "Done!";
                                else
                                    box.Items[box.Items.Count - 1] = box.Items[box.Items.Count - 1].ToString().Substring(0, box.Items[box.Items.Count - 1].ToString().Length - 1) + i;
                                Thread.Sleep(1000);
                            }
                            f.setupSetProgressText("Kullanıcı Girişi Bekleniyor...");

                        });
            thread.Start();
            thread.Join();
            Application.OpenForms[0].Controls[1].Dispose();
            SetupStage3 st3 = new SetupStage3();
            st3.setupComponents(f);
            Application.OpenForms[0].Controls.Add(st3.GetPanel());
            

        }

        void CreateTable(string keyValue)
        {
            
            switch (keyValue)
            {
                case "users":
                    box.Items.Add("Users table creating...");
                    db.GetManager().SendData("create table Users(" +
                    "id int primary key identity(0,1)," +
                    "name nvarchar(30)," +
                    "surname nvarchar(50)," +
                    "telno nvarchar(13)," +
                    "username nvarchar(100)," +
                    "password nvarchar(255)," +
                    "perm nvarchar(255)" +
                    ")");
                    break;
                case "personals":
                    box.Items.Add("Personals table creating...");
                    db.GetManager().SendData("create table Personals(" +
                    "id int primary key identity(0,1)," +
                    "name nvarchar(30)," +
                    "surname nvarchar(50)," +
                    "telno nvarchar(13)," +
                    "dtarih nvarchar(10)" +
                    ")");
                    break;
                case "saat":
                    box.Items.Add("Saat table creating...");
                    db.GetManager().SendData("create table Saat(" +
                        "id int primary key identity(0,1)," +
                        "saat nvarchar(50)" +
                        ")");
                    db.GetManager().SendData("insert into Saat(saat) values ('00:00-08.00')");
                    db.GetManager().SendData("insert into Saat(saat) values ('08:00-16:00')");
                    db.GetManager().SendData("insert into Saat(saat) values ('16:00-00:00')");
                    break;
                default:
                    return;
            }
            box.Items[box.Items.Count - 1] += "Done!";
        }

        public CustomPanel GetPanel()
        {
            return panel;
        }
    }
}
