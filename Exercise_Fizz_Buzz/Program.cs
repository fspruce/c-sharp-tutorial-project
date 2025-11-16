using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Fizz_Buzz
{
    internal class Program
    {
        /*
         * Create a for loop from 1 to X.
         * 
         * A Multiple of:
         * 3 and 5 = FizzBuzz
         * 3 = Fizz
         * 5 = Buzz
         * else = number
         * 
         */
        static void Main(string[] args)
        {
            int loopCount;
            bool success = false;

            while (!success)
            {
                Console.Write("Enter an integer for how many numbers you want to go through: ");
                success = int.TryParse(Console.ReadLine(), out loopCount);
                Console.WriteLine();
                string output = "";

                for (int i = 1; i <= loopCount; i++) 
                {
                    if (i % 3 == 0)
                    {
                        output += "Fizz";
                    }
                    if (i % 5 == 0)
                    {
                        output += "Buzz";
                    }
                    Console.WriteLine(output != "" ? output : $"{i}");
                    output = "";
                }

            }

            Console.ReadLine();
        }
    }
}
