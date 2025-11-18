using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            //Is safer than using (message == compare)
            if (message.Equals(compare)) 
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //if (name != "")
            if (!name.Equals(string.Empty)) 
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Invalid name input");
            }

                Console.ReadLine();
        }
    }
}
