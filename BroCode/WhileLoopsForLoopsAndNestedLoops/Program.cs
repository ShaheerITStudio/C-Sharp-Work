using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsForLoopsAndNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // While Loop =Repeats some code while some condition is true
            String name = "";
            //stuck in infinite loop
            //while (1==1)
            //{
            //    Console.WriteLine("Enter your name: I am in infinite loop ");
            //}

            //While loop that asks user for their name and will not stop asking until they
            //provide a name
            //while (name == "")
            //{
            //    Console.WriteLine("Enter your name: ");
            //    name = Console.ReadLine();
            //}
            //Console.WriteLine("Hello " + name);



            // For Loop = Repeats some code a certain amount of times
            //for (int i = 1; i <= 10; i+=2)  // i++ means add 1 to i each time the loop runs
            //                                // while i+=2 means add 2 to i each time the loop runs which shows 5 digit which are  1 3 5 7 9
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 10; i >= 0; i--) // this loop will count down from 10 to 0
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Happy new year!");


            // Nested Loop = A loop inside of another loop
            Console.Write("How many Rows For rectangle ?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many Columns for rectangle?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol do you want to use for rectangle?: ");
            String symbol = Console.ReadLine();

            for(int i=0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.Beep();
            Console.ReadKey();
        }
    }
}
