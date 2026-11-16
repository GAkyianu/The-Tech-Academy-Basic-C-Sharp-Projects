using System;

class Program
{
    static void Main()
    {
        // Ask the user for their age
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        // Check voting eligibility using the != operator
        // The legal voting age is 18, so age != 18 means "age is not equal to 18"
        if (age != 18)
        {
            Console.WriteLine("Your age is not exactly 18.");
        }
        else
        {
            Console.WriteLine("Your age is exactly 18.");
        }

        // Now check full voting eligibility (must be 18 or older)
        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are NOT eligible to vote.");
        }

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}

