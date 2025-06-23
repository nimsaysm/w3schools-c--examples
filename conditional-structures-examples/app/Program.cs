using System;

namespace ConditionalStructuresExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 18;

            // If-Else statement to compare two numbers
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (x < y)
            {
                Console.WriteLine("x is less than y");
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }


            // Ternary operator to check if a number is even or odd
            string result = (x % 2 == 0) ? "x is even" : "x is odd";
            Console.WriteLine(result);

            // Switch statement to determine the day of the week
            int day = 4; // Corresponds to Thursday
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}