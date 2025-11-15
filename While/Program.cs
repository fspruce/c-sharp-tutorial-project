using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        /*
         * Convert the following for loop to a while loop:
         * for (int i = 0; i < 10; i++)
         * {
         *      Console.WriteLine(i);
         * }
         * 
         * int i = 0;
         * while (i < 10)
         * {
         *     Console.WriteLine(i);
         *     i++;
         * }
         */
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second value: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            int answer = numberA * numberB;
            int answerInput = 0;
            Console.WriteLine();

            Console.Write($"What's the value of {numberA} x {numberB}?");
            Console.WriteLine();

            /*while (answerInput != answer) // Only executes if the condition is true.
            {
                Console.Write("Enter your answer: ");
                answerInput = Convert.ToInt32(Console.ReadLine());

                if (answerInput != answer)
                {
                    Console.WriteLine("Close, but it was wrong!");
                }

                Console.WriteLine();
            }*/

            do // Always executes once regardless of the while condition.
            {
                Console.Write("Enter your answer: ");
                answerInput = Convert.ToInt32(Console.ReadLine());

                if (answerInput != answer)
                {
                    Console.WriteLine("Close, but it was wrong!");
                }

                Console.WriteLine();
            } while (answerInput != answer);

            Console.WriteLine("Well done!");
            

            Console.ReadLine();
        }
    }
}
