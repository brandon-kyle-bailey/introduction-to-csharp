using System;

namespace introduction_to_csharp.calculator
{
    class Calculator
    {
        public static void Run(string[] args)
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
