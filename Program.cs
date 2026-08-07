using System;

class Program
{
    static void Main()
    {
        // Display welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

        // --- Ask for package weight ---
        Console.Write("Please enter the package weight: ");

        // TryParse safely converts user input to an integer without crashing
        if (!int.TryParse(Console.ReadLine(), out int weight))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            Console.ReadKey();
            return; // End program if input is invalid
        }

        // Check if the package is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadKey();
            return; // End program if weight exceeds limit
        }

        // --- Ask for package width ---
        Console.Write("Please enter the package width: ");
        if (!int.TryParse(Console.ReadLine(), out int width))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            Console.ReadKey();
            return;
        }

        // --- Ask for package height ---
        Console.Write("Please enter the package height: ");
        if (!int.TryParse(Console.ReadLine(), out int height))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            Console.ReadKey();
            return;
        }

        // --- Ask for package length ---
        Console.Write("Please enter the package length: ");
        if (!int.TryParse(Console.ReadLine(), out int length))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            Console.ReadKey();
            return;
        }

        // --- Check total dimensions ---
        // Add width, height, and length together
        int dimensionTotal = width + height + length;

        // If total dimensions exceed 50, package is too large
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.ReadKey();
            return;
        }

        // --- Calculate the shipping quote ---
        // Multiply width * height * length to get volume
        int volume = width * height * length;

        // Multiply volume by weight, then divide by 100 to get final quote
        decimal quote = (volume * weight) / 100m;

        // --- Display the final quote ---
        Console.WriteLine($"\nYour estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");

        // Pause so the console stays open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
