using FinalProject.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public class User
    {
        private byte _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole UserType { get; set; }
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 100)
                    _age = value;
                else
                    _age = 0;
            }
        }
        public string PropicPath { get; set; }

        public User(string name,string surname,string password, string email,byte age)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Age = age;
        }
        public User()
        {

        }
    }
}
