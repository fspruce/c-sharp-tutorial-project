using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Odd_Even_Checker
{
    internal class Program
    {
        /*
         * Create & initialise two ints
         * Make a variable to work out the remainder
         * Output remainder to the screen
         * Change the first int variable to another number
            * and recallculate the remainder
            * output new remainder to the screen
         */
        static void Main(string[] args)
        {
            int value_1 = 10;
            int value_2 = 2;
            double remainder = value_1 % value_2;
            Console.WriteLine(remainder);

            value_1 = 15;
            remainder = value_1 % value_2;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
