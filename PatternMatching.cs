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
    }
}
