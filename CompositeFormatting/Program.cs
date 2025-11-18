using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Fintan";
            int age = 25;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nAge: " + age);

            //Concatentation: Okay for shorter strings with less variables, but can get
            //long and difficult to read as the string grows.
            Console.WriteLine("Your name is " + name + ", and your age is " + age);
            Console.WriteLine("Name: " + name + "\nAge: " + age);
            Console.WriteLine();
            //You can also use string.Concat to avoid using + to concatenate.
            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(test);
            Console.WriteLine();
            //Composite formatting is shorter than concatenation. **
            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
            Console.WriteLine("Name: {0}\nAge: {1}", name, age);
            Console.WriteLine();
            //String interpolation is easier to read than composite formatting, especially
            //when the variables are well-named and descriptive.
            Console.WriteLine($"Your name is {name}, and your age is {age}");
            Console.WriteLine($"Name: {name}\nAge: {age}");

            Console.ReadLine();
        }
    }

    /*
     * **Usually, string interpolation is the better option, except in a few small cases. For example,
     *   string interpolation came out much later than composite formatting, and so legacy software might
     *   prefer to use composite formatting.
     *   
     *   Furthermore, in apps like translator apps, a string may be formatted using a general greeting from
     *   a resource file. Different languages structure their sentences differently, but still use the same
     *   information. For example, in German "Your age is 30 and your name is Maria" might become "Ihr name
     *   ist Maria und ihr alter ist 30". In this case, composite formatting can be used so the information
     *   appears in the correct place dependent on the language.
     *   
     *   The English resource file could contain "Greeting = "Your name is {0} and your name is {1}."
     *   The German resource file could contain "Greeting = "Ihr name ist {1} und ihr alter ist {0}."
     *   Then the c# file would contain "string message = String.Format(ResourceManager.GetResource("Greeting"),
     *   age, name);"
     *   
     *   This way, the German translator does not need to know the exact c# variables being used to store the
     *   information, just that grammatically the {0} in the English resource file would point to an age and the
     *   {1} would point to a name, and where these variables would go in the German greeting.
     *   
     *   Even though string interpolation could technically be used also here, it would be at a higher risk
     *   of introducing errors to the code through mispelt variables (e.g. {Age} instead of {age}, or {naem}
     *   instead of {name}), and could be harder to track down where the error has occurred.
     */
}
