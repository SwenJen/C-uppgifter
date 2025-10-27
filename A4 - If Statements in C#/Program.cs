using System;


namespace If_Statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            int ageInput = Convert.ToInt32(age);

            if(ageInput >= 18)
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine("You can not vote.");
            }
        }
    }
}
