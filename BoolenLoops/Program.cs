using System;

namespace BooleanLoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // BOOLEAN COMPARISON USING WHILE
            // -------------------------------

            // Create a counter variable starting at 1
            int counter = 1;

            // The while loop will continue running as long as the boolean condition is true.
            // In this case, the condition is: counter <= 3
            // This means the loop will run while counter is 1, 2, and 3.
            while (counter <= 3)
            {
                // Print the current counter value to the console
                Console.WriteLine("WHILE LOOP: Counter is " + counter);

                // Increase counter by 1 so the loop eventually stops
                counter++;
            }

            // Add a blank line for readability
            Console.WriteLine();


            // -----------------------------------
            // BOOLEAN COMPARISON USING DO-WHILE
            // -----------------------------------

            // Reset counter to 1 for the do-while example
            counter = 1;

            // A do-while loop ALWAYS runs at least once,
            // because the condition is checked AFTER the loop body executes.
            do
            {
                // Print the current counter value
                Console.WriteLine("DO-WHILE LOOP: Counter is " + counter);

                // Increase counter by 1
                counter++;

            } while (counter <= 3); // Boolean comparison checked after each loop

            // End of program message
            Console.WriteLine("\nProgram finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

