using System;

class Program
{
    static void Main()
    {
        // Display the required welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine(); // Blank line for spacing

        // --- Ask for package weight ---
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());   // Convert user input to integer

        // Check if weight exceeds the limit
        if (weight > 50)
        {
            // If weight is too heavy, display error and end program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program immediately
        }

        // --- Ask for package width ---
        Console.WriteLine("Please enter the package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        // --- Ask for package height ---
        Console.WriteLine("Please enter the package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        // --- Ask for package length ---
        Console.WriteLine("Please enter the package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        // Check if total dimensions exceed the limit
        int dimensionTotal = width + height + length;

        if (dimensionTotal > 50)
        {
            // If dimensions are too large, display error and end program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program immediately
        }

        // --- Calculate the shipping quote ---
        // Multiply dimensions together, multiply by weight, then divide by 100
        int volume = width * height * length; // Calculate package volume
        decimal quote = (volume * weight) / 100m; // Use decimal for money

        // --- Display the final quote ---
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}

