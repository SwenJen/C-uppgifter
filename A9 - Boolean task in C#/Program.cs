using System;


namespace Boolean_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 10;

            bool isTrue = true;

            //bool resultAnd = isTrue && (num1 > num3 && num2 < num4);
            //bool resultOr = isTrue || (num1 == num3 || num2 == num4);
            //bool resultNot = !isTrue;

            Console.WriteLine($"Logical AND: {isTrue && (num1 > num3 && num2 < num4)}");
            Console.WriteLine($"Logical OR: {isTrue || (num1 == num3 || num2 == num4)}");
            Console.WriteLine($"Logical NOT for true: {!isTrue}");

            Console.WriteLine("\n");

            Console.WriteLine($"num1 > num3: {num1 > num3}");
            Console.WriteLine($"num2 < num4: {num2 < num4}");
            Console.WriteLine($"num1 == num4: {num1 == num4}");
            Console.WriteLine($"num2 != num3: {num2 != num3}");

            Console.WriteLine("\n");

            bool expression1 = (num1 > num3) && (num2 < num4);
            bool expression2 = (num1 < num3) || (num2 > num4);
            Console.WriteLine($"Expression 1: {expression1}");
            Console.WriteLine($"Expression 2: {expression2}");
        }
    }
}
