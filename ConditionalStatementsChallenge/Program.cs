using System;

class Program
{
    static void Main()
    {
        // Ask the user for a number
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check the number using if, else if, and else
        if (number > 0)
        {
            // This block runs if the number is greater than zero
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            // This block runs if the number is less than zero
            Console.WriteLine("The number is negative.");
        }
        else
        {
            // This block runs only if the number is exactly zero
            Console.WriteLine("The number is zero.");
        }

        // Pause so the console doesn't close immediately
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}

