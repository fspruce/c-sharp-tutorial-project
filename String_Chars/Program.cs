using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Fintan"; // String must be in "" not ''
            char letter = 'a'; // Char accepts one singular character, uses '' not ""

            Console.Write("Your name is "); // Write instead of WriteLine allows text to be on same line
            Console.Write(name); 
            Console.WriteLine();
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}
