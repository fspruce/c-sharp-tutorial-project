using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            //Format can be used to change how a value appears in the terminal once printed.
            //Standard rounding rules apply.
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.#}", value)); //# removes trailing 0s
            Console.WriteLine(string.Format("{0:0.00}", value));

            Console.WriteLine();

            double money = -10D / 3D; //3.3333333...
            Console.WriteLine(money);
            //Pattern inside the {}, anything can be written either side.
            Console.WriteLine(string.Format("£{0:0.00}", money));
            Console.WriteLine(money.ToString("C")); //C for currency, compiler automatically figures out the currency symbol.
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2")); //Can define the no. of decimal places.

            Console.WriteLine();

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture)); //Defines culture via user's machine.
            //Defines the culture through a specific culture code.
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            Console.ReadLine();
        }
    }
}
