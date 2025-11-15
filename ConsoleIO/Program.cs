using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello my name is Fintan!");

            // Readline allows for user input, using Write instead of WriteLine allows for input on the same line as the prompt.
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            //We can convert user inputs as they enter them.
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);


            //There are many ways we can concatenate variables and strings in the output.
            Console.Write("Your name is ");
            Console.Write(name);
            Console.Write(" and your age is ");
            Console.Write(age);

            Console.WriteLine();

            Console.Write("Your name is " + name + " and your age is " + age);

            Console.WriteLine();

            Console.Write($"Your name is {name} and your age is {age}");

            Console.ReadLine();
        }
    }
}
