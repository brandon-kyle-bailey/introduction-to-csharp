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

            Console.WriteLine("Ouput of addition of {0} & {1} is: {2}", numberOne, numberTwo, output);

            Console.WriteLine("Press the Enter key to exit.");
            Console.ReadLine();
        }
    }
}
