using System;
using System.Collections.Generic;
using System.Text;

namespace introduction_to_csharp.advanced
{
    class AdvancedTechniques
    {
        public static void Run(string[] args)
        {

            HandleExceptions();
            Console.ReadLine();
        }

        static void HandleExceptions()
        {   try
            {
                Console.WriteLine("Enter a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter another number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());

                int output = numberOne / numberTwo;

                Console.WriteLine("Ouput: {0}", output);
            }
            catch(Exception err) 
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
