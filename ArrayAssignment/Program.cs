using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ---------------------------------------------------------
        // 1. One-dimensional Array of strings
        // ---------------------------------------------------------

        // Create an array of strings
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Ask the user to select an index
        Console.WriteLine("Select an index from the string array (0 to 4):");
        string stringInput = Console.ReadLine();

        // Convert input to integer
        int stringIndex;

        // TryParse prevents the app from crashing if user enters letters
        if (int.TryParse(stringInput, out stringIndex))
        {
            // Check if index exists
            if (stringIndex >= 0 && stringIndex < fruits.Length)
            {
                Console.WriteLine("You selected: " + fruits[stringIndex]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the string array.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }


        // ---------------------------------------------------------
        // 2. One-dimensional Array of integers
        // ---------------------------------------------------------

        // Create an array of integers
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Ask the user to select an index
        Console.WriteLine("\nSelect an index from the integer array (0 to 4):");
        string intInput = Console.ReadLine();

        int intIndex;

        if (int.TryParse(intInput, out intIndex))
        {
            if (intIndex >= 0 && intIndex < numbers.Length)
            {
                Console.WriteLine("You selected: " + numbers[intIndex]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the integer array.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }


        // ---------------------------------------------------------
        // 3. List of strings
        // ---------------------------------------------------------

        // Create a list of strings
        List<string> colours = new List<string>()
        {
            "Red", "Blue", "Green", "Yellow"
        };

        // Ask the user to select an index
        Console.WriteLine("\nSelect an index from the string list (0 to 3):");
        string listInput = Console.ReadLine();

        int listIndex;

        if (int.TryParse(listInput, out listIndex))
        {
            if (listIndex >= 0 && listIndex < colours.Count)
            {
                Console.WriteLine("You selected: " + colours[listIndex]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the string list.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        // Pause the console so the user can see the output
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
