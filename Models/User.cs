using System;
using System.Collections.Generic;
using System.Text;

namespace _11AugHomeWork.Models
{
    class User
    {
        private string UserName;

        public string _userName
        {
            get
            {
                
               return UserName;
                
                
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25 )
                {
                    UserName = value;
                }
            }


        }
        private string Password;



        public string _password
        {
            get
            {

                return Password;



            }
            set
            {
                if (HasUpper(value) == true && HasLower(value) == true && HasDigit(value) == true && value.Length >= 8 && value.Length <= 25 )
                {
                    Password = value;
                }
            }
        }

        

        public void ShowInfo()
        {
            if (UserName != null && Password != null)
            {
                Console.WriteLine($"Username:{UserName} Password:{Password}");
            }
            else
                Console.WriteLine("Username or Password is wrong");

        }
        public bool HasDigit(string hasDigit)
        {
            bool checkNumber = false;
            foreach (char item in hasDigit)
            {
                checkNumber = Char.IsDigit(item);
                if (checkNumber == true)
                {
                    break;
                }
            }
            return checkNumber;
        }
        public bool HasLower(string hasLower)
        {
            bool checkLower = false;
            foreach (char item in hasLower)
            {
                checkLower = Char.IsLower(item);
                if (checkLower == true)
                {
                    break;
                }
            }
            return checkLower;
        }
        public bool HasUpper(string hasUpper)
        {
            bool checkUpper = false;
            foreach (char item in hasUpper)
            {
                checkUpper = Char.IsUpper(item);
                if (checkUpper == true)
                {
                    break;
                }
            }
            return checkUpper;
        }





















    }       
}
