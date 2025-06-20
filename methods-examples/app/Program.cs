using System;

namespace MethodsExamples
{
  class Program
  {
    // SayHello prints a greeting message with an optional name parameter
    static void SayHello(string name = "World")
    {
        Console.WriteLine("Hello, " + name + "!");
    }
    
    // SayPersonInfos prints a person's name and age using named arguments
    static void SayPersonInfos(string name, int age)
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }
    
    static int PlusMethod(int x, int y)
    {
    return x + y;
    }

    static double PlusMethod(double x, double y)
    {
    return x + y;
    }


        static void Main(string[] args)
        {
            SayHello("Yasmin");

            // Use named arguments to specify parameters in any order
            SayPersonInfos(age: 20, name: "Yasmin");

            // A method can have multiple overloads with the same name but different parameter types 
            PlusMethod(1, 2);
            PlusMethod(1.5, 2.5);
        }
  }
}