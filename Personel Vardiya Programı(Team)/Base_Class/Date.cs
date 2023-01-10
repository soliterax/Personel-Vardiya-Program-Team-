using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Vardiya_Programı_Team_.Base_Class
{
    public class Date
    {

        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public Date()
        {

        }

        public Date(int day)
        {
            this.day = day;
        }

        public Date(int day, int month) : this(day) { 
            this.month = month;
        }

        public Date(int day, int month, int year) : this(day, month)
        {
            this.year = year;
        }
    }
}
