using System;

namespace ConditionalStructuresExamples
{
    class Program
    {
        // Set of named constants using an enum
        enum Level
        {
            Low,
            Medium,
            High
        }

        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar); // Output: Medium
        }

    }
}