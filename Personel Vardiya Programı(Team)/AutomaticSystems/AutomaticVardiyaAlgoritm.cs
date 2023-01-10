using Org.BouncyCastle.Crypto.Tls;
using Personel_Vardiya_Programı_Team_.Base_Class;
using Personel_Vardiya_Programı_Team_.VardiyaDataSetTableAdapters;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personel_Vardiya_Programı_Team_.SetupForm;

namespace Personel_Vardiya_Programı_Team_.AutomaticSystems
{
    public class AutomaticVardiyaAlgoritm
    {

        DataTable data;
        Personal[] users;
        LinkedList<PersonalStabilizer> stabilizers = new LinkedList<PersonalStabilizer>();
        LinkedList<PersonalStabilizer[]> weekCompleted;
        LinkedList<PersonalStabilizer[][]> monthCompleted;
        public void StartSystems()
        {
            data = ConnectionMemory.conn.GetManager().GetData("select * from Personals");
            users = new Personal[data.Rows.Count];
            for(int i = 0; i < users.Length; i++)
            {
                users[i] = new Personal(data.Rows[i]);
            }
            RandomizeList();
            Console.WriteLine("Boyut = " + stabilizers.Count);
            if(stabilizers.Count < 35)
            {
                throw new Exception();
            }    
        }

        public DataTable GetDataFromDatabase(int month) => ConnectionMemory.conn.GetManager().GetData($"select * from Nobet{month}");

        void RandomizeList()
        {
            for(int i = 0; i < users.Length; i++)
            {
                if (users[i].Unvan.ToLower().Equals("memur")) { 
                    for(int a = 0; a <= 5; a++)
                    {
                        stabilizers.AddLast(new PersonalStabilizer(users[i]));
                    }
                }
                else if (users[i].Unvan.ToLower().Equals("işçi") || users[i].Unvan.ToLower().Equals("isci") || users[i].Unvan.ToLower().Equals("işci"))
                {
                    for (int a = 0; a <= 6; a++)
                    {
                        stabilizers.AddLast(new PersonalStabilizer(users[i]));
                    }
                }
                else
                {
                    for (int a = 0; a <= 6; a++)
                    {
                        stabilizers.AddLast(new PersonalStabilizer(users[i]));
                    }
                }
            }
            LinkedList<PersonalStabilizer> _rawData = new LinkedList<PersonalStabilizer>();
            Random rand = new Random();
            
            while(stabilizers.Count > 0)
            {
                int sayi = rand.Next(0, stabilizers.Count);
                _rawData.AddLast(stabilizers.ToArray()[sayi]);
                stabilizers.Remove(stabilizers.ToArray()[sayi]);
                Console.WriteLine(_rawData.ToArray()[_rawData.ToArray().Length - 1].personel.Id);
            }

            stabilizers = _rawData;
        }

        public void StartAlgorithms(AlgorithmType type)
        {
            if(type == AlgorithmType.Week)
            {
                monthCompleted = null;
                WeekAlgorithm algorithm = new WeekAlgorithm(stabilizers);
                algorithm.StartAlgorithm();
                weekCompleted = algorithm.GetChosenPersonal();
                int a = 0;
                foreach (PersonalStabilizer[] ps in algorithm.GetChosenPersonal().ToArray())
                {
                    Console.WriteLine("--------------- Day " + (a + 1) + " ---------------");
                    foreach (PersonalStabilizer psd in ps)
                    {
                        Console.WriteLine(psd.personel.ToString());
                    }
                    a++;
                }
            }
            else
            {
                weekCompleted = null;
                MonthAlgorithm algorithm = new MonthAlgorithm(stabilizers);
                algorithm.StartAlgorithm();
                monthCompleted = algorithm.GetChosenPersonal();
            }
        }


        public void SaveTable()
        {
            DateTime dateTime= DateTime.Now;
            int dmonth = dateTime.Month;

            int day = dateTime.Day;
            int month = dateTime.Month;
            int year = dateTime.Year;
            ConnectionMemory.conn.GetManager().SendData($"create table Nobet{month}(" +
                $"date nvarchar(10)," +
                $"one int foreign key references Personals(id)," +
                $"two int foreign key references Personals(id)," +
                $"three int foreign key references Personals(id)," +
                $"four int foreign key references Personals(id)," +
                $"five int foreign key references Personals(id)" +
                $")");
            int[] ids = new int[5];
            
            if(weekCompleted != null)
            {
                foreach(PersonalStabilizer[] st in weekCompleted)
                {
                    for(int i = 0; i < st.Length; i++)
                    {
                        ids[i] = st[i].personel.Id;
                    }
                    ConnectionMemory.conn.GetManager().SendData($"insert into Nobet{dmonth}(date, one, two, three, four, five) values ('{day}.{month}.{year}', '{ids[0]}', '{ids[1]}', '{ids[2]}', '{ids[3]}', '{ids[4]}')");
                    dateTime = dateTime.AddDays(1);
                    day = dateTime.Day;
                    month = dateTime.Month;
                }
            }
            if(monthCompleted != null)
            {
                foreach (PersonalStabilizer[][] st in monthCompleted)
                {
                    foreach (PersonalStabilizer[] std in st)
                    {
                        for(int i = 0; i < std.Length; i++)
                        {
                            ids[i] = std[i].personel.Id;
                        }
                        ConnectionMemory.conn.GetManager().SendData($"insert into Nobet{dmonth}(date, one, two, three, four, five) values ('{day}.{month}.{year}', '{ids[0]}', '{ids[1]}', '{ids[2]}', '{ids[3]}', '{ids[4]}')");
                        dateTime = dateTime.AddDays(1);
                        day = dateTime.Day;
                        month = dateTime.Month;
                    }
                }
            }
        }


        public enum AlgorithmType
        {
            Week, Month
        }

        public class PersonalStabilizer
        {
            public Personal personel { get; set; }

            public PersonalStabilizer(Personal personel)
            {
                this.personel = personel;
            }
        }

    }
}
