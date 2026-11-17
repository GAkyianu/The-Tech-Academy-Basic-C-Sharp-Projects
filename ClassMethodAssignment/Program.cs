
using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method, passing two numbers
            mathOps.PerformMathOperation(10, 20);

            Console.WriteLine();

            // Call the method again using named parameters
            mathOps.PerformMathOperation(num1: 30, num2: 40);

            // Keep the console window open
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}