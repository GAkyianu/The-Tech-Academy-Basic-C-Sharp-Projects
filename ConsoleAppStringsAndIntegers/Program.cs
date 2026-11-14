using System;
using System.Collections.Generic;

// ======================================================
// CONSOLE APP STRINGS AND INTEGERS ASSIGNMENT
// PART 1-5: DIVISION AND EXCEPTION HANDLING
// ======================================================

// Step 1: Create a list of integers.
List<int> numbers = new List<int>()
{
    10,
    20,
    30,
    40,
    50
};

// Step 2: Ask the user to enter a number.
Console.WriteLine("Please enter a number to divide each item in the list by:");

// Step 3: Start the try block.
// The program will attempt to execute the code inside it.
try
{
    // Read the user's input and convert it into an integer.
    int divisor = Convert.ToInt32(Console.ReadLine());

    // Loop through every number in the list.
    for (int i = 0; i < numbers.Count; i++)
    {
        // Divide the current list item by the user's number.
        int result = numbers[i] / divisor;

        // Display the original number and the result.
        Console.WriteLine(numbers[i] + " divided by " + divisor + " = " + result);
    }
}
// Step 4: The catch block handles errors from the try block.
catch (Exception ex)
{
    // Display the error message when an exception occurs.
    Console.WriteLine("An error occurred: " + ex.Message);
}

// Step 5: This message is outside the try/catch block.
// It should execute whether the try block succeeds or an error occurs.
Console.WriteLine("The program has continued after the try/catch block.");

// End of assignment


