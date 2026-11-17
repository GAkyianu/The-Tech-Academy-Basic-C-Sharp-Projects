using System;

namespace ClassMethodAssignment
{
    // Create a class that contains the method
    class MathOperations
    {
        // Create a void method that takes two integer parameters
        public void PerformMathOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer
            int result = num1 * 2;

            // Display the result of the math operation
            Console.WriteLine("First number multiplied by 2: " + result);

            // Display the second integer to the screen
            Console.WriteLine("Second number: " + num2);
        }
    }
}