using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Validator
    {
        public bool IsEmpty(params string[] txbxs)
        {
            bool isEmpty = false;
            foreach (string txbx in txbxs)
            {
                if (string.IsNullOrEmpty(txbx))
                {
                    isEmpty = true;
                    break;
                }
            }
            return isEmpty;
        }
        public bool isValidEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;

            }
            else return false;
        }
        public bool isValidPassword(string password)
        {
            if (password.Length >= 4)
            {
                return true;

            }
            else return false;
        }
        public bool isValidAgeValue(string age)
        {
            bool validAge = false;
            if (!string.IsNullOrEmpty(age))
            {
                if (byte.TryParse(age, out byte result))
                {
                    if (result > 0 && result <= 100)
                        validAge = true;
                }
                   
               
                
            }
            return validAge;
        }


    }
}
