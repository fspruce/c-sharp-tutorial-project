using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Times_Tables
{
    internal class Program
    {
        /*
         * Ask the user for a number for the table.
         * Write a for loop to print X times table.
         */
        static void Main(string[] args)
        {
            int timesTable = 0;
            bool success = false;

            Console.WriteLine("Choose an integer and I will print out the corresponding times table!");
            Console.WriteLine();

            while (!success)
            {
                Console.Write("Please enter an integer: ");
                success = int.TryParse(Console.ReadLine(), out timesTable );

                if (success) 
                {   
                    Console.WriteLine();
                    Console.WriteLine($"The {timesTable} Times Table!");
                    Console.WriteLine("------------------------------");
                    for (int i = 0; i <= 12; i++)
                    {
                        
                        Console.WriteLine($"{i} x {timesTable} = {i * timesTable}");
                    }
                } else
                {
                    Console.WriteLine("Please enter a valid integer.");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
