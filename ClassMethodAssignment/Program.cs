using System;

namespace ClassMethodAssignment
{

    // Regular class that contains the assignment methods.
    public class MathOperations
    {
        // Void method.
        // Accepts an integer, divides it by 2, and outputs the result.
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"The number divided by 2 is: {result}");
        }

        // Method with an output parameter.
        // Returns the result through the out parameter.
        public void DivideByTwo(int number, out int result)
        {
            result = number / 2;
        }

        // Overloaded method.
        // Accepts a double value instead of an int.
        public void DivideByTwo(double number)
        {
            double result = number / 2;
            Console.WriteLine($"The decimal number divided by 2 is: {result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Call the static class method.
            Utilities.ShowMessage();

            // Instantiate the MathOperations class.
            MathOperations mathOps = new MathOperations();

            // Ask the user to enter a number.
            Console.Write("Please enter a whole number: ");

            // Convert user input into an integer.
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call the void method.
            mathOps.DivideByTwo(userNumber);

            // Demonstrate the method with an output parameter.
            mathOps.DivideByTwo(userNumber, out int outputResult);

            Console.WriteLine($"Result from output parameter: {outputResult}");

            // Demonstrate the overloaded method.
            mathOps.DivideByTwo(25.5);

            // Prevent the console window from closing immediately.
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
