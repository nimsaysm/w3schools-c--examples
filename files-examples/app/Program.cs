using System.IO;

namespace ConditionalStructuresExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello, World!";
            // Create a file and write the content of writeText to it
            File.WriteAllText("hello.txt", writeText);

            // Read the contents of the file
            string readText = File.ReadAllText("hello.txt");
            Console.WriteLine("Reading file content...");
            Console.WriteLine(readText);  // Output: Hello, World!

            // Check if the file exists
            Console.WriteLine("Checking if the file exists...");
            if (File.Exists("hello.txt"))
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            // Append text to the end of the file
            string appendText = "\nThis is an appended line.";
            File.AppendAllText("hello.txt", appendText);

            Console.WriteLine("Reading text to the updated file...");
            string updatedText = File.ReadAllText("hello.txt");
            Console.WriteLine(updatedText);  // Output: Hello, World!\nThis is an appended line.


            // Delete the file
            Console.WriteLine("Deleting the file...");
            if (File.Exists("hello.txt"))
            {
                File.Delete("hello.txt");
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File does not exist to delete.");
            }
        }
    }
}