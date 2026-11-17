using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RandomNumbersAndHypotenuseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //its all about the random numbers
            Random random = new Random();

            int randomNumber1 = random.Next(1, 10); // Generates a random number between 1 and 10
            int randomNumber2 = random.Next(1, 10); // Generates a random number between 1 and 10
            int randomNumber3 = random.Next(1, 10); // Generates a random number between 1 and 10

            double randomNumber = random.NextDouble() * 10; // Generates a random double between 0 and 10
            
            Console.Beep(); // Plays a beep sound
                            //Console.WriteLine($"Random Number 1: {randomNumber1}");
                            //Console.WriteLine($"Random Number 2: {randomNumber2}");
                            //Console.WriteLine($"Random Number 3: {randomNumber3}");

            //Console.WriteLine($"Random Double Number: {randomNumber}");

            //its all about the hypotenuse calculator = hypotenuse = sqrt(a^2 + b^2) it means that the hypotenuse is equal to the square root of a squared plus b squared
            Console.WriteLine("Enter the length of side a: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of side b: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            double c =Math.Sqrt((Math.Pow(sideA, 2) + Math.Pow(sideB, 2))); // Calculates the hypotenuse using the Pythagorean theorem
            Console.WriteLine("The length of the hypotenuse is: {c}");
        }
    }
}
