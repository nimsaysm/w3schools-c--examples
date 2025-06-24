using System.IO;

namespace ExceptionsExamples
{
    class Program
    {

        static void checkAge(int age)
        {
            if (age < 18)
            {
                // Throw an manual exception if the age is less than 18
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            // Example of handling exceptions with try-catch
            try
            {
                // Attempt to read a file that may not exist
                string filePath = "nonexistentfile.txt";
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException e)
            {
                // Handle the specific exception for file not found
                Console.WriteLine($"Error: The file '{e.FileName}' was not found.");
            }
            catch (Exception e)
            {
                // Handle any other exceptions that may occur
                Console.WriteLine($"An unexpected error occurred: {e.Message}");
            }
            finally
            {
                // Code that runs regardless of whether an exception occurred
                Console.WriteLine("Execution completed.");
            }

            checkAge(20);
        }
    }
}