using System;
using System.Xml.Linq;


namespace Password_Checker_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a password with 6 characters or more: ");
            string password1 = Console.ReadLine();
            Console.Write("Please enter the same password again: ");
            string password2 = Console.ReadLine();

            // Length
            if (password1.Length >= 6 || password2.Length >= 6)
            {
            }
            else
            {
                Console.WriteLine("Please input 6 or more characters");
            }

            // Match
            if (!string.IsNullOrEmpty(password1) || !string.IsNullOrEmpty(password2))
            {
                if (password1 == password2)
                {
                    Console.WriteLine("Passwords match");
                }
                else if(password1 != password2)
                {
                    Console.WriteLine("Passwords do not match");
                }
                Console.ReadLine();
             
            }

            // Empty
            if (password1 + password2 != "")
            {
            }
            else
            {
                Console.WriteLine("Please enter a password");
            }
        }
    }
}
