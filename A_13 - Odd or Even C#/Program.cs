using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput); 

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is even: {number % 2}");
                
            }
            else
            {
                Console.WriteLine($"The number is odd: {number % 2}");
            }

            

        }
    }
}
