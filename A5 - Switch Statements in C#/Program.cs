using System;


namespace Switch_Statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade with a number between 0-5: ");
            int grade = Convert.ToInt32(Console.ReadLine());    

            switch(grade)
            {
                case 5:
                    Console.WriteLine("Excellent");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 1:
                    Console.WriteLine("Needs improvement");
                    break;
                case 0:
                    Console.WriteLine("Fail");
                    break;
                default: Console.WriteLine("Invalid grade");
                    break;

            }
        }   
    }
}
