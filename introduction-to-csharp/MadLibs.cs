using System;

namespace introduction_to_csharp.madlibs
{
    class MadLibs
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("This is mad libs");

            Console.Write("Enter a color: ");
            string color = Convert.ToString(Console.ReadLine());

            Console.Write("Enter a plural noun: ");
            string pluralNoun = Convert.ToString(Console.ReadLine());

            Console.Write("Enter a celebrity: ");
            string celebrity = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Roses are {0}", color);
            Console.WriteLine("{0} are blue", pluralNoun);
            Console.WriteLine("I love {0}", celebrity);


        }
    }
}