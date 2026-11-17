using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementSwitchesLogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //what is if statement = a basic form of descision making in programming.
            //It allows you to execute a block of code only if a specified condition is true.
            //Console.WriteLine("Please enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age >= 100)
            //{
            //    Console.WriteLine("You are a centenarian.");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("You are an adult.");
            //}
            //else if (age >= 13)
            //{
            //    Console.WriteLine("You are a teenager.");
            //}
            //else if (age >= 0)
            //{
            //    Console.WriteLine("You are a child.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age.");
            //}


            //it all about the if statement, it is a decision making statement that
            //allows you to execute a block of code only if a specified condition is true.
            //Console.WriteLine("Please Enter your name: ");
            //string name = Console.ReadLine();
            //if (name == "")
            //{
            //    Console.WriteLine("You did not enter a name.");

            //}
            //else
            //{
            //    Console.WriteLine($"Hello, name!");

            //}

            //or

            //if (name != "")
            //{
            //    Console.WriteLine($"Hello, {name}!");
            //}
            //else
            //{
            //    Console.WriteLine("You did not enter a name.");
            //}





            /// it all about switch statement, it is a decision making statement
            /// that allows you to execute a block of code based on the value of 
            /// a variable or expression. an effecient alternative to many else if statements.

            //Console.WriteLine("What day is it today?");
            //Console.WriteLine("Please enter in lower case letters: ");
            //string day = Console.ReadLine();

            //switch (day.ToLower())
            //{
            //    case "monday":
            //        Console.WriteLine("Today is Monday.");
            //        break;
            //    case "tuesday":
            //        Console.WriteLine("Today is Tuesday.");
            //        break;
            //    case "wednesday":
            //        Console.WriteLine("Today is Wednesday.");
            //        break;
            //    case "thursday":
            //        Console.WriteLine("Today is Thursday.");
            //        break;
            //    case "friday":
            //        Console.WriteLine("Today is Friday.");
            //        break;
            //    case "saturday":
            //        Console.WriteLine("Today is Saturday.");
            //        break;
            //    case "sunday":
            //        Console.WriteLine("Today is Sunday.");
            //        break;
            //    default:
            //        Console.WriteLine(day + " is an invalid day.");
            //        break;
            //}


            //it all about logical operators, it is used to
            //combine multiple conditions in an if statement.

            //&& for AND operator, it returns true if both conditions are true.
            //|| for OR operator, it returns true if at least one condition is true.
            //! for NOT operator, it returns true if the condition is false.

            Console.WriteLine("Please enter your temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if (temperature < 0 || temperature > 100)
            {
                Console.WriteLine("Temperature is out of range.");
            }
            else if (temperature >= 0 && temperature <= 32)
            {
                Console.WriteLine("It is freezing cold.");
            }
            else if (temperature > 32 && temperature <= 60)
            {
                Console.WriteLine("It is cold.");
            }
            else if (temperature > 60 && temperature <= 80)
            {
                Console.WriteLine("It is warm.");
            }
            else
            {
                Console.WriteLine("It is hot.");
            }
        }

    }
}
    