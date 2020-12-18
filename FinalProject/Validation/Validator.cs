using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Validator
    {
        public void IsEmpty(params string[] txbxs)
        {
            bool isEmpty = false;
            foreach (string txbx in txbxs)
            {
                if (string.IsNullOrEmpty(txbx))
                {
                    throw new ArgumentNullException("Please fill out all fields");
                }
            }
            
        }
        public void isValidEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
                throw new ArgumentNullException();
            if (!email.Contains("@"))
                throw new InvalidEmailException("Your email is worng");
        }
        public void isValidPassword(string password)
        {
            if (!string.IsNullOrEmpty(password))
                throw new ArgumentNullException();
            if (password.Length < 4)
                throw new InvalidPasswordException("Your passsword is wrong");
        }
        public void isValidAgeValue(string age)
        {
            if (!string.IsNullOrEmpty(age))
                throw new ArgumentNullException();
            else if (byte.TryParse(age, out byte result))
                throw new FormatException("The format of the given value is not correct");
            else if (result > 0 && result <= 100)
                throw new InvalidAgeValueException("The given Age value is invalid");
                      
                
                   
               
                
            
       
        }


    }
}
