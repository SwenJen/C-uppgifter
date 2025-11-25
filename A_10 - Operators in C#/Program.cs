using System;


namespace Operators_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10; //a
            int num2 = 20; //b
            int num3 = 30; //c
            int num4 = 40; //d
            int num5 = 50; //e
            int num6 = 60; //f

            Console.WriteLine("Arithmetic (Addition, Multiplication, Division)");
            Console.WriteLine($"a + b = {num1 + num2}");
            Console.WriteLine($"c * d = {num3 * num4}");
            Console.WriteLine($"e % f = {num5 * num6}");


            Console.WriteLine("Increment and Decrement");
            Console.WriteLine($"f++ is: {num6++}");// Postfix
            Console.WriteLine($"++f is: {++num6}");// Prefix
            Console.WriteLine($"f-- is: {num6--}");// Postfix
            Console.WriteLine($"--f is: {--num6}");// Prefix

            Console.WriteLine("Assignment Operators");
            Console.WriteLine($"e += is: {num5 += 5}");
            Console.WriteLine($"e -= is: {num5 -= 5}");
            Console.WriteLine($"e *= is: {num5 *= 5}");
            Console.WriteLine($"e /= is: {num5 /= 5}");
            Console.WriteLine($"e %= is: {num5 %= 5}");
        }
    }
}

