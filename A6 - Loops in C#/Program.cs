using System;


namespace Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {   // User input
            Console.Write("What would you like to loop?: ");
            string message = Console.ReadLine();

            Console.Write("How many times?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= loopCounter; i++) 

            Console.WriteLine(message);

            Console.WriteLine("The loop has finished!");

        }   
    }    
}
