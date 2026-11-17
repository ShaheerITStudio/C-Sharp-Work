using System;


namespace ArthemticAndMathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //It all about athematic operations and Math class in C# programming language.
            double number = 10.0;

            //number=number + 5.0;
            //number += 5.0;
            //number++;

            //number = number - 5.0;
            //number -= 5.0;
            //number--;

            //number = number * 5.0;
            //number *= 5.0;

            //number = number / 5.0;
            //number /= 5.0;

            //number = number % 3.0;
            //number %= 3.0;


            //Math class in C# programming language.
            double X = 3.0;
            double Y = 5.0;
            double a = Math.Pow(X, 2.0);// it do that it take two arguments and return the first argument raised to the power of the second argument.
            double b = Math.Sqrt(X); // it do that it take one argument and return the square root of the argument.
            double c = Math.Abs(X); // it do that it take one argument and return the absolute value of the argument.
            double d = Math.Max(X, Y);// it do that it take two arguments and return the larger of the two arguments.
            double e = Math.Min(X, Y);// it do that it take two arguments and return the smaller of the two arguments.
            double f = Math.Round(3.5);// it do that it take one argument and return the nearest integer to the argument.
            double g = Math.Ceiling(3.5);// it do that it take one argument and return the smallest integer greater than or equal to the argument.
            double h = Math.Floor(3.5);// it do that it take one argument and return the largest integer less than or equal to the argument.
            double i = Math.PI; // it do that it return the value of pi.
            double j = Math.E; // it do that it return the value of e.
            double k = Math.Sin(X); // it do that it take one argument and return the sine of the argument.



            Console.Beep();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.ReadKey();


        }
    }
}
