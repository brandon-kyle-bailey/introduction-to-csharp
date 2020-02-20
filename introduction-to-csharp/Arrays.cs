using System;

namespace introduction_to_csharp.arrays
{
    class Arrays
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("This is arrays!");

            int[] luckyNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            string[] names = new string[luckyNumbers.Length];

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine("Lucky number is currently {0}", luckyNumbers[i]);
                names[i] = $"Name {i}";
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}