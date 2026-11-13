
using System;
using System.Collections.Generic;

// ======================================================
// SIX-PART ASSIGNMENT
// PART 1: STRING ARRAY AND USER INPUT
// ======================================================

/*
 * Step 1: Create a one-dimensional array of strings.
 * The array contains three example strings.
 */
string[] words = { "Hello", "Welcome", "Goodbye" };

// Step 2: Ask the user to enter some text.
Console.WriteLine("Please enter some text:");
string userInput = Console.ReadLine();

// Step 3: Loop through each element in the array.
// Append the user's input to the end of every string.
// This loop updates the array but does not print anything.
for (int i = 0; i < words.Length; i++)
{
    words[i] = words[i] + userInput;
}

// Step 4: Create a second loop to display each
// updated string individually in the console.
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i]);
}

// End of Part 1


// ======================================================
// PART 2: INFINITE LOOP
// ======================================================

// The following is an example of an infinite loop:
//
// while (true)
// {
//     Console.WriteLine("This loop never ends!");
// }
//
// The loop above would continue forever because
// its condition is always true.
//
// FIX:
// We introduce a counter variable and give the
// while loop a condition that eventually becomes false.

// Initialise the counter at zero.
int counter = 0;

// Execute the loop while the counter is less than 5.
while (counter < 5)
{
    Console.WriteLine("This is loop number: " + counter);

    // Increase the counter by 1 each time the loop runs.
    // This ensures the condition eventually becomes false.
    counter++;
}

// The infinite loop has now been fixed because
// the counter eventually reaches 5 and stops the loop.

// End of Part 2




// ======================================================
// PART 3: LOOPS USING COMPARISON OPERATORS
// ======================================================

// PART 3A: Loop using the LESS THAN (<) operator

// Initialise a counter at zero.
int lessThanCounter = 0;

// Continue looping while the counter is less than 5.
while (lessThanCounter < 5)
{
    Console.WriteLine("Less than loop: " + lessThanCounter);

    // Increase the counter by one after each iteration.
    lessThanCounter++;
}

// The loop stops when the counter reaches 5.
// End of Part 3A



// PART 3B: Loop using the LESS THAN OR EQUAL TO (<=) operator

// Initialise a new counter at zero.
int lessThanOrEqualCounter = 0;

// Continue looping while the counter is less than or equal to 5.
while (lessThanOrEqualCounter <= 5)
{
    Console.WriteLine("Less than or equal to loop: " + lessThanOrEqualCounter);

    // Increase the counter by one after each iteration.
    lessThanOrEqualCounter++;
}

// The loop stops when the counter becomes 6.
// End of Part 3



// ======================================================
// PART 4: SEARCHING A LIST OF STRINGS
// ======================================================

// Step 1: Create a list of strings.
// Each item in this list is unique.
List<string> names = new List<string>()
{
    "James",
    "Michael",
    "Sarah",
    "David",
    "Emma",
    "Daniel"
};

// Step 2: Ask the user to enter text to search for.
Console.WriteLine("\nPART 4: Enter a name to search for:");
string searchInput = Console.ReadLine();

// Step 3: Create a variable to check whether a match is found.
bool matchFound = false;

// Step 4: Loop through each item in the list.
for (int i = 0; i < names.Count; i++)
{
    // Check whether the current list item contains the user's input.
    if (names[i].Contains(searchInput))
    {
        // Display the index of the matching list item.
        Console.WriteLine("Match found at index: " + i);

        // Record that a match has been found.
        matchFound = true;

        // Step 5: Stop the loop once a match is found.
        break;
    }
}

// Step 6: Check whether the search text was found.
if (matchFound == false)
{
    Console.WriteLine("Your input is not on the list.");
}

// End of Part 4


// ======================================================
// PART 5: FINDING MULTIPLE MATCHES IN A LIST
// ======================================================

// Step 1: Create a list of strings.
// The list contains repeated names to allow multiple matches.
List<string> repeatedNames = new List<string>()
{
    "James",
    "Sarah",
    "Michael",
    "Sarah",
    "David",
    "Emma",
    "Sarah"
};

// Step 2: Ask the user to enter text to search for.
Console.WriteLine("\nPART 5: Enter a name to search for:");
string multipleSearchInput = Console.ReadLine();

// Step 3: Create a variable to check whether a match is found.
bool multipleMatchesFound = false;

// Step 4: Loop through every item in the list.
for (int i = 0; i < repeatedNames.Count; i++)
{
    // Check whether the current item contains the search text.
    if (repeatedNames[i].Contains(multipleSearchInput))
    {
        // Display the index of each matching item.
        Console.WriteLine("Match found at index: " + i);

        // Record that at least one match has been found.
        multipleMatchesFound = true;

        // There is deliberately NO break statement here.
        // This allows the loop to continue and find other matches.
    }
}

// Step 5: Check whether the search text was found.
if (multipleMatchesFound == false)
{
    Console.WriteLine("Your input is not on the list.");
}

// End of Part 5


// ======================================================
// PART 6: CHECKING FOR UNIQUE ITEMS AND DUPLICATES
// ======================================================

// Step 1: Create a list of strings.
// This list deliberately contains repeated letters.
List<string> duplicateCheckNames = new List<string>()
 {
     "A",
     "B",
     "C",
     "D",
     "C",
     "A"
 };

// Step 2: Create another list to store items
// that have already been checked.
List<string> previouslySeen = new List<string>();

// Step 3: Use a foreach loop to examine every item
// in the original list, one at a time.
foreach (string item in duplicateCheckNames)
{
    // Step 4: Check whether the current item
    // already exists in the previouslySeen list.
    if (previouslySeen.Contains(item))
    {
        // If the item is already in the list,
        // display a message identifying it as a duplicate.
        Console.WriteLine(item + " - this item is a duplicate");
    }
    else
    {
        // If the item has not appeared before,
        // display a message identifying it as unique.
        Console.WriteLine(item + " - this item is unique");

        // Add the current item to previouslySeen
        // so that future occurrences are recognised.
        previouslySeen.Add(item);
    }
}

// End of Part 6


