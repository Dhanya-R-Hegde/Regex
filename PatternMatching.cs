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

        
    }
}
