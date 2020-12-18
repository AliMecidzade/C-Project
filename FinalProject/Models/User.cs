using FinalProject.Roles;
using System;

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
                if (value == default)
                    throw new ArgumentNullException("There is no given age value");
                else if (value > 0 || value < 100)
                    throw new InvalidAgeValueException("The given age value is not valid");
                else 
                    _age = value;
                          
              
            }
        }
        public string ProPicPath { get; set; }
        public bool IsConfirmedEmail { get; set; }
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
