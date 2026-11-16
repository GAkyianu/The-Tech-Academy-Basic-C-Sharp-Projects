using System;


namespace MainMethodAssignment
{
    // This class contains overloaded methods that perform math operations
    public class MathOperations
    {
        // Method that accepts an integer
        public int Calculate(int number)
        {
            // Add 10 to the integer and return the result
            return number + 10;
        }

        // Overloaded method that accepts a decimal
        public int Calculate(decimal number)
        {
            // Multiply the decimal by 2
            decimal result = number * 2;

            // Convert the result to an integer and return it
            return Convert.ToInt32(result);
        }

        // Overloaded method that accepts a string
        public int Calculate(string number)
        {
            // Convert the string to an integer
            int convertedNumber = Convert.ToInt32(number);

            // Subtract 5 from the converted integer
            return convertedNumber - 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // Call the method that accepts an integer
            int intResult = math.Calculate(20);

            // Display the integer result
            Console.WriteLine("Integer result: " + intResult);

            // Call the method that accepts a decimal
            int decimalResult = math.Calculate(12.5m);

            // Display the decimal result
            Console.WriteLine("Decimal result: " + decimalResult);

            // Call the method that accepts a string
            int stringResult = math.Calculate("30");

            // Display the string result
            Console.WriteLine("String result: " + stringResult);

            // Keeps the console window open
            Console.ReadLine();
        }
    }
}
