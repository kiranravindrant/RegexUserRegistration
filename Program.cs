using System;
using System.Text.RegularExpressions;


namespace RegexUserRegistration
{
    class Program
    {
        public static string namePattern = "^[A-Z]{1}[a-z]{2,}";
        public static string emailPattern = "^[A-z a-z]{3,}[.]?([a-z A-z 0-9]{3,})?[@][a-z A-z]{2,}[.]?[a-z]{2,}[.]?[a-z]{2,3}$";
        static void Main(string[] args)
        {
            Console.WriteLine("=======User Registration=====");
            Console.WriteLine("Enter your FirstName");
            string firstname = Console.ReadLine();

            Console.WriteLine(NameValidation(firstname));

            Console.WriteLine("Enter your LastName");
            string lastname = Console.ReadLine();
            Console.WriteLine(NameValidation(lastname));

            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine(EmailValidation(email));


        }
        static bool NameValidation(string name)
        {
            return Regex.IsMatch(name, namePattern);
        }

        static bool EmailValidation(string email)
        {
            return Regex.IsMatch(email, emailPattern);
        }



    }
}      


