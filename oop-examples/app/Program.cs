using System;

namespace OOPExamples
{
    class Person
    {
        // Class attributes (fields) with automatic properties
        // These properties will automatically create private fields
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize the object
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Base class (parent) for inheritance
    class Vehicle
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    // Derived class (child) that inherits from Vehicle
    class Car : Vehicle
    {
        public string modelName = "Mustang";  // Car field
    }



    // Abstract class example
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (child) that inherits from Animal
    class Pig : Animal
    {
        // Overriding the abstract method with a body
        public override void animalSound()
        {

            Console.WriteLine("The pig says: wee wee");
        }
    }

    // Interface example
    interface IFirstInterface
    {
        // Interface method (does not have a body)
        void myMethod();
    }

    interface ISecondInterface
    {
        // Interface method (does not have a body)
        void myOtherMethod();
    }

    // Class that implements both interfaces
    class MyClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("The first interface method is called.");
        }

        // Implementing the method from the second interface
        public void myOtherMethod()
        {
            Console.WriteLine("The second interface method is called.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person = new Person("Yasmin", 20);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");


            // Create an instance of the Car class
            Car myCar = new Car();
            // Accessing the inherited method
            myCar.honk(); // Outputs: Tuut, tuut!


            // Create an instance of the Pig class
            Pig myPig = new Pig();
            myPig.animalSound(); // Outputs: The pig says: wee wee
            myPig.sleep(); // Outputs: Zzz


            // Create an instance of MyClass
            MyClass myObject = new MyClass();
            myObject.myMethod(); // Outputs: The first interface method is called.
            myObject.myOtherMethod(); // Outputs: The second interface method is called.
        }
    }
}