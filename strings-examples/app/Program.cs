using System;

namespace StringsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";
            // String Length
            int length = text.Length;
            Console.WriteLine("Length of the string: " + length);

            // String to Upper Case
            string upperCase = text.ToUpper();
            Console.WriteLine("Upper case: " + upperCase);

            // String to Lower Case
            string lowerCase = text.ToLower();
            Console.WriteLine("Lower case: " + lowerCase);

            // String concatenation
            string addText = " Welcome to C#.";
            string resultConcat = string.Concat(text, addText);
            Console.WriteLine("Concatenated string: " + resultConcat);

            // String interpolation
            string resultInterpolation = $"{text}{addText}";
            Console.WriteLine("Interpolated string: " + resultInterpolation);

            // Get index of a character
            int indexOfW = text.IndexOf('W');
            Console.WriteLine("Index of 'W': " + indexOfW);

            // Get substring
            string substring = text.Substring(7, 5); // Should return "World"
            Console.WriteLine("Substring: " + substring);
        }
    }
}