using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathOperation1 class
            MathOperation1 mathOp = new MathOperation1();

            // Ask the user to enter the first parameter
            Console.WriteLine("Enter an integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the second parameter
            // or simply press Enter to use the default value
            Console.WriteLine("Enter a second integer, or just press Enter:");

            try
            {
                // Read and convert the second number
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Call the method with two parameters
                int results = mathOp.MathOperation(num1, num2);

                // Display the result
                Console.WriteLine(num1 + " x " + num2 + " = " + results);
            }
            catch
            {
                // Call the method with one parameter only
                // The optional parameter default value of 1 will be used
                int results = mathOp.MathOperation(num1);

                // Display the result using the default value
                Console.WriteLine(num1 + " x Default 1 = " + results);
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}