using System;
using System.Linq.Expressions;
using System.Threading;


namespace Message_Printer_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Original Order
            Console.WriteLine("Please enter the message: C# is fun, I am going to code C# tomorrow ");
            var message = Console.ReadLine();
            Console.WriteLine($"Printed message: {message} ");

            Console.WriteLine("\n");

            //Reverse Order
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            string newArray = new string(messageArray);
            Console.WriteLine($"Reverse order: {newArray}");

            Console.WriteLine("\n");

            //Letter by letter
            Console.WriteLine("Letter by letter:");
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
                Thread.Sleep(50);
            }
            //Letter by letter reverse
            Console.WriteLine("Letter by letter reverse:");
            for (int i = 0; i < message.Length; i++)
            {
                
                char[] messageArray1 = message.ToCharArray();
                Array.Reverse(messageArray1);
                string newArray1 = new string(messageArray1);
                

                Console.WriteLine(messageArray1[i]);
                Thread.Sleep(50);




            }



        }
    }





    
}
