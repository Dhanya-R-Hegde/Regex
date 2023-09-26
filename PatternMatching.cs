using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExplanation
{
    internal class PatternMatching
    {
        public static void ValidateFirstName()
        {
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            string NamePattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexObj = new Regex(NamePattern);

            if (regexObj.IsMatch(FirstName))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name is Invalid");
                Console.ResetColor();
            }
            Console.WriteLine(FirstName);
        }

        public static void ValidateLastName()
        {
            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();
            string NamePattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regexObj = new Regex(NamePattern);

            if (regexObj.IsMatch(LastName))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name is Invalid");
                Console.ResetColor();
            }
            Console.WriteLine(LastName);
        }

        public static void ValidateEmail()
        {
            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();
            string NamePattern = "^[a-zA-Z]*[.+-]*[0-9a-zA-Z]+[@]+[0-9a-zA-Z]+[.]+[a-zA-z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";

            Regex regexObj = new Regex(NamePattern);

            if (regexObj.IsMatch(Email))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email is Invalid");
                Console.ResetColor();
            }
            Console.WriteLine(Email);
        }


        public static void ValidateMobileNumber()
        {
            Console.WriteLine("Enter the Mobile Number with Country Code");
            string MobileNumber = Console.ReadLine();
            string mobileNumberPattern = "^[0-9]{2,4}[ ]{1}[6-9]{1}[0-9]{9}$";

            Regex regexObj = new Regex(mobileNumberPattern);

            if (regexObj.IsMatch(MobileNumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mobile Number is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mobile Number is Invalid");
                Console.ResetColor();
            }
            Console.WriteLine(MobileNumber);
        }


        public static void ValidatePassword()
        {
            Console.WriteLine("Enter the Password");
            string Password = Console.ReadLine();
            string passwordPattern = "^[A-Z]{1,}[a-z]{1,}[~@#$^*()_+=[\\]{}|\\\\,.?: -]{1}[0-9]{1,}$";

            Regex regexObj = new Regex(passwordPattern);

            if (regexObj.IsMatch(Password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password is Invalid");
                Console.ResetColor();
            }
            Console.WriteLine(Password);
        }
    }
}
