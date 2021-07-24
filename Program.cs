using System;
using System.Text.RegularExpressions;


namespace RegexUserRegistration
{
    class Program
    {
        public static string namePattern = "^[A-Z]{1}[a-z]{2,}";
        static void Main(string[] args)
        {
            Console.WriteLine("=======User Registration=====");
            Console.WriteLine("Enter your FirstName");
            string firstname = Console.ReadLine();

            Console.WriteLine(NameValidation(firstname));







        }
        static bool NameValidation(string name)
        {
            return Regex.IsMatch(name, namePattern);
        }
        




    }
}      


