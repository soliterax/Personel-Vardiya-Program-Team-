using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Vardiya_Programı_Team_.Base_Class
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }

        public User() { }

        public User(int id, string name, string surname, string username, string password, string permission)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            Permission = permission;
        }
    }
}
