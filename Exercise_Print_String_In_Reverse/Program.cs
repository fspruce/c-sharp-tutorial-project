using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Print_String_In_Reverse
{
    internal class Program
    {
        /*
         * Ask user to input message.
         * Print in order.
         * Print in reverse.
         * 
         */
        static void Main(string[] args)
        {
            bool success = false;

            while (!success)
            {
                Console.Write("Enter your message: ");
                string message = Console.ReadLine();
                Console.WriteLine();

                if (!string.IsNullOrEmpty(message))
                {
                    string hbar = "";
                    for (int i = 0; i < (message.Length + 14); i++)
                    {
                        hbar += "-";
                    }
                    Console.WriteLine(hbar);
                    Console.WriteLine($"\"{message.ToUpper()}\" IN REVERSE!");
                    Console.WriteLine(hbar);
                    for (int i = (message.Length + 6); i >= 0; i--)
                    {
                        if (i > message.Length - 1)
                        {
                            Console.Write(" ");
                        } else
                        {
                            Console.Write(message[i]);
                            System.Threading.Thread.Sleep(150);
                        }
                            
                    }
                    success = true;
                }
                else
                {
                    Console.WriteLine("Your message was empty. Please try again.\n");
                }
            }

            Console.ReadLine();
        }
    }
}
