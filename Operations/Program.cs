using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            age++; // Increase age by 1
            age = age + 10; // Increase age by specified amount
            age += 10; // Shorter version of above
            Console.WriteLine(age);
            age--; // Decrease age by 1
            age = age - 10;
            age -= 10;
            Console.WriteLine(age);
            age /= 10;
            Console.WriteLine(age); // Since age is an integer, decimal answers obtained will be truncated.

            double age2 = 23 / 10;
            Console.WriteLine(age2);

            string name = "Fintan";
            name += " is programming!";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b'; // Adding char values will add their unicode values and output the sum as its own new unicode character.
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++); // Increments the value after returning the i value.
            Console.WriteLine(++i); // Increments the value before returning the i value.


            Console.ReadLine();
        }
    }
}
