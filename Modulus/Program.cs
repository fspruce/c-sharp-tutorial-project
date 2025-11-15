using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 2;

            Console.WriteLine(firstNum % secondNum); // Gives the modulus (remainder).
            Console.WriteLine(1000 % 90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);

            Console.ReadLine();
        }
    }
}
