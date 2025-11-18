using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * \t for tab
             * \n for new line
             * \" to allow for speech marks within strings
             * \\ for backslash
             */
            string speech = "He said \"Something\"";
            string path = "C:\\Users\\Fintan Spruce\\Desktop\\Coding\\C#\nNew line test";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            /*
             * $ +
             * $"Your name is {name}"
             * "Your name is " + name"
             * 
             */

            //@ - verbatim identifier. Will print exactly what's within the string, ignoring escape characters.
            path = @"C:\\Users\\Fintan Spruce\\Desktop\\Coding\\C#" + "\nNew line test";
            Console.WriteLine(path);
            
            //When using verbatim identifier, double speechmarks needed rather than a backslash.
            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = @"Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
