using System;

namespace TypeCastingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit casting (automatically), passing from smaller to larger type
            int myInt = 9;
            double myDouble = myInt; // int to double
            Console.WriteLine("Implicit casting from int to double: " + myDouble);


            // Explicit casting (manually), passing from larger to smaller type
            double myDoubleNum = 8.76;
            int myIntNum = (int)myDoubleNum; // double to int
            Console.WriteLine("Explicit casting from double to int: " + myIntNum);

            // Using Convert class for type conversion
            string myString = "123";
            int myConvertedInt = Convert.ToInt32(myString); // string to int
            Console.WriteLine("Convert string to int: " + myConvertedInt);
        }
    }
}