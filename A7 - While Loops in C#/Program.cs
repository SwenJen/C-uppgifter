using System;


namespace While_Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine(counter++);
                
            }
            Console.WriteLine("The loop has finished.");
        }
    }
}
