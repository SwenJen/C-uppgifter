using System;


namespace Input_and_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");
        }
    }
}
