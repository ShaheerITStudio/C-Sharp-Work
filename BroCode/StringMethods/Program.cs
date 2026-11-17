using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //it all about strings methods
            string name = "Hello World";
            string phone = "123-456-7890";
            string upperName = name.ToUpper();
            string lowerName = name.ToLower();
            string trimmedPhone = phone.Trim();
            string replacedName = name.Replace("World", "C#");
            string insertedName = name.Insert(5, " Beautiful");
            string lengthofphone = phone.Length.ToString();
            string substringName = name.Substring(6, 5);


            Console.Beep();
            Console.WriteLine("Original Name: " + name);
            Console.WriteLine("Uppercase Name: " + upperName);
            Console.WriteLine("Lowercase Name: " + lowerName);
            Console.WriteLine("Trimmed Phone: " + trimmedPhone);
            Console.WriteLine("Replaced Name: " + replacedName);
            Console.WriteLine("Inserted Name: " + insertedName);
            Console.WriteLine("Length of Phone: " + lengthofphone);
            Console.WriteLine("Substring of Name: " + substringName);
            Console.ReadKey();


        }
    }
}
