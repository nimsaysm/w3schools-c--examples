using System;

namespace ConditionalStructuresExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 1, 2, 3, 4, 5 };

            // Max returns the largest number in the array
            Console.WriteLine(myNumbers.Max()); // Should return 5

            // Min returns the smallest number in the array
            Console.WriteLine(myNumbers.Min()); // Should return 1

            // Sum returns the sum of the numbers in the array
            Console.WriteLine(myNumbers.Sum()); // Should return 15

            string[] myStrings = { "peach", "banana", "apple" };

            Console.WriteLine("Strings before sort:");
            foreach (string str in myStrings)
            {
                Console.WriteLine(str);
            }

            // Sort sorts the array in ascending order
            Array.Sort(myStrings);
            Console.WriteLine("Sorted strings:");
            foreach (string str in myStrings)
            {
                Console.WriteLine(str);
            }
        }
    }
}