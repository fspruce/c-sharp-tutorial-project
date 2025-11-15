using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20; // Const declares the variable as a constant, can not be changed.
            const double percentVAT = vat / 100D; // Putting  D on the 100 allows for the result to be a double and have decimal values.
            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0"; // Allows for information to be given once, and therefore only changed once if a change is needed.
            Console.WriteLine(version);

            Console.ReadLine();
        }
    }
}
