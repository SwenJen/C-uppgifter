using System;

namespace Conversion_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "12345";
            int number = int.Parse(numberAsString);
            Console.WriteLine($"The converted number is: {number}");
        }
    }
}
