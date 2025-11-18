using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            //string.Empty is more clear that you are looking for an empty string than "".
            //Also, you may accidentally place a space between the double  quotes and cause
            //an error, which is less likely with string.Empty.
            if (name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}.");
            } else
            {
                Console.WriteLine("Name is empty.");
            }
            
            Console.ReadLine();
        }
    }
}
