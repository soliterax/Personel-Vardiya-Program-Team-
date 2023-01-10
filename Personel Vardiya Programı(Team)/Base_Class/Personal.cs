using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Vardiya_Programı_Team_.Base_Class
{
    public class Personal
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Date Birthday { get; set; }
        public string SicilNo { get; set; }
        public string Kadro { get; set; }
        public string Unvan { get; set; }
        public string TcNo { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string EPosta { get; set; }

        public Personal() { }

        public Personal(int id, string name, string surname, Date birthday, string sicilNo, string kadro, string unvan, string tcNo, string adress, string telephone, string ePosta)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Birthday = birthday;
            SicilNo = sicilNo;
            Kadro = kadro;
            Unvan = unvan;
            TcNo = tcNo;
            Adress = adress;
            Telephone = telephone;
            EPosta = ePosta;
        }

        public Personal(DataRow row)
        {
                Id = int.Parse(row[0].ToString());
                SicilNo = row[1].ToString();
                Kadro = row[2].ToString();
                Unvan = row[3].ToString();
                Name = row[4].ToString();
                Surname = row[5].ToString();
                TcNo = row[6].ToString();
                Adress = row[7].ToString();
                Telephone = row[8].ToString();
                EPosta = row[9].ToString();
        }

        public override string ToString()
        {
            return $"{SicilNo},{Kadro}, {Unvan}, {Name}, {Surname}, {TcNo}, {Adress}, {Telephone}, {EPosta}";
        }
    }
}
