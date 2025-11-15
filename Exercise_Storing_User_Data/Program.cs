using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Storing_User_Data
{
    internal class Program
    {
        /*
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Print variables line-by-line to the screen
         */

        static void Main(string[] args)
        {
            string name = "Fintan";
            string number = "0123456789"; // Phone number as string to allow for 0 at front of number.
            int age = 25;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
