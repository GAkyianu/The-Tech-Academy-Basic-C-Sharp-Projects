
using System;
using System.Text; // Needed for StringBuilder

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenate three strings
            string part1 = "Hello, ";
            string part2 = "my name is ";
            string part3 = "Godfred.";
            string fullSentence = part1 + part2 + part3; // Combine all three strings
            Console.WriteLine(fullSentence); // Print the result

            // Convert a string to uppercase
            string message = "this will be uppercase.";
            string upperMessage = message.ToUpper(); // Convert to uppercase
            Console.WriteLine(upperMessage); // Print the uppercase version

            // Create a StringBuilder and build a paragraph
            StringBuilder sb = new StringBuilder(); // Create a new StringBuilder object

            sb.Append("This is the first sentence. "); // Add first sentence
            sb.Append("Here is the second sentence. "); // Add second sentence
            sb.Append("Finally, this is the third sentence."); // Add third sentence

            Console.WriteLine(sb.ToString()); // Print the full paragraph

            Console.ReadLine(); // Keep console window open
        }
    }
}
