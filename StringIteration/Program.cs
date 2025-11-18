using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";

            Console.WriteLine(message[0]); //C
            Console.WriteLine(message[1]); //#
            Console.WriteLine(message[2]); //
            Console.WriteLine(message[3]); //i
            //Console.WriteLine(message[13]); would cause an index out of range exception.
            Console.WriteLine();

            //A for loop can be used to iterate over strings.
            Console.WriteLine("-----------------------------");  
            Console.WriteLine("For loop");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < message.Length; i++)
            {
                //Console.WriteLine(message[i]);
                Console.Write(message[i]);
                //System.Threading.Thread.Sleep(); can be inserted if only being used once or twice.
                //If being used throughout the whole project:
                Thread.Sleep(150); //1000ms = 1s
                //This example allows the message to be typed out on screen one letter at at time,
                //similar to a keyboard/typewriter.
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));
            Console.WriteLine();
            //We can create our own version of this Contains function using this iteration process:

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('C'))
                {
                    contains = true;
                }
            }

            Console.WriteLine(contains);


            Console.ReadLine();
        }
    }
}
