using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool success = false;

            //While loops can then be used to ensure the program waits until the user enters the
            //correct value.
            while (!success)
            {
                Console.Write("Enter an integer: ");
                //Using a bool to store the TryParse shows whether the parse was successful.
                //This way if the user enters 0, then the program knows the conversion worked.
                success = int.TryParse(Console.ReadLine(), out num); //Prevents program from parsing to int if the user input didn't fit the format
                Console.WriteLine(success ? $"Your chosen integer is: {num}" : "Please enter a valid integer.");
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
