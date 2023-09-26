namespace RegexExplanation
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Please select options : \n" + "1 To check for First Name \n" + "2 To check for Last Name \n"+"3 To check for Email \n"+"4 To check Mobile Number \n"+"5 To check Password \n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1 : PatternMatching.ValidateFirstName(); break;
                case 2: PatternMatching.ValidateLastName(); break;
                case 3: PatternMatching.ValidateEmail(); break;
                case 4: PatternMatching.ValidateMobileNumber(); break;
                case 5: PatternMatching.ValidatePassword(); break;
                default: Console.WriteLine("Enter a valid value"); break;

            }
        }
    }
}
