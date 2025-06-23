using System;

namespace MathClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            // Math.Max compares two numbers and returns the larger one
            int max = Math.Max(a, b);
            Console.WriteLine("Max between " + a + " and " + b + " is: " + max);

            // Math.Min compares two numbers and returns the smaller one
            int min = Math.Min(a, b);
            Console.WriteLine("Min between " + a + " and " + b + " is: " + min);

            // Math.Sqrt calculates the square root of a number
            double squareRoot = Math.Sqrt(25);
            Console.WriteLine("Square root of 25 is: " + squareRoot);

            // Math.Abs returns the absolute value of a number
            int absoluteValue = Math.Abs(-15);
            Console.WriteLine("Absolute value of -15 is: " + absoluteValue);

            // Math.Round rounds a number to the nearest integer
            double roundedValue = Math.Round(10.6);
            Console.WriteLine("Rounded value of 10.6 is: " + roundedValue);
        }
    }
}