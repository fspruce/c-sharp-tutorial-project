using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var can automatically detect what data type the variable should be,
            // but negatively effects the readability of the code.
            var age = 23;
            Console.WriteLine(age);

            var bigNumber = 90000L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.000001F;
            Console.WriteLine(precision);

            var name = "Fintan";
            Console.WriteLine(name);

            var ch = 'a';
            Console.WriteLine(ch);

            Console.ReadLine();
        }
    }
}
