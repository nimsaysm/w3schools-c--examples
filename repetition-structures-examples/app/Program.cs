using System;

namespace RepetitionStructuresExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // While repetition structure will continue as long as the condition is true
            Console.WriteLine("Executing while repetition structure with i = 0:");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do-While repetition structure will execute at least once before checking the condition
            Console.WriteLine("Executing do-while repetition structure with j = 0:");
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);

            // For repetition structure is used for a known number of iterations
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("For loop iteration: " + k);
            }


            // Foreach repetition structure is used to iterate over collections or arrays
            Console.WriteLine("Executing foreach repetition structure:");
            string[] fruits = { "Apple", "Banana", "Peach" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
            }
        }
    }
}