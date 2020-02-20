using System;

namespace introduction_to_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my C# Calculator.");

            Console.Write("First number: ");
            double numberOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second number: ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            double output = numberOne + numberTwo;

            Console.WriteLine("Output of addition of " + numberOne + " & " + numberTwo + " is: " + output);
        }
    }
}
