using System;

namespace CallingMethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result1 = math.AddTen(number);
            int result2 = math.MultiplyByTwo(number);
            int result3 = math.SubtractFive(number);

            Console.WriteLine($"Add 10: {result1}");
            Console.WriteLine($"Multiply by 2: {result2}");
            Console.WriteLine($"Subtract 5: {result3}");

            Console.ReadLine();
        }
    }
}