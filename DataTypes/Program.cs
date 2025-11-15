using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;
            //int z = 30;
            int x = 10,
                y = 20,
                z = 30;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int age = 25;
            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            long bigNumber = 900000000L; //L to specify the value is long (64bit not 32bit)
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double negative = -55.2D; //D to specify that the value is a double
            Console.WriteLine(negative);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float precision = 5.000001F;  //F to specify the value is a float (rather than double)
            Console.WriteLine(precision);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            decimal money = 14.99M; //M for decimal (rather than double)
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.ReadLine();
        }
    }
}
