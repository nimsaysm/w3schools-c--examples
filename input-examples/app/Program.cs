using System;

namespace InputExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input from the console
            Console.WriteLine("Please enter your name:");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            // Get user input for age and convert it to an integer
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old!");
        }
    }
}