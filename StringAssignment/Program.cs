using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("=== String Operations Demonstration ===\n");

            // ===== PART 1: String Concatenation =====
            Console.WriteLine("--- Part 1: String Concatenation ---");

            // Declare three separate string variables
            string firstName = "John";
            string middleName = "Michael";
            string lastName = "Smith";

            // Concatenate the three strings together with spaces
            // Using the + operator to combine strings
            string fullName = firstName + " " + middleName + " " + lastName;

            // Display the concatenated result to the console
            Console.WriteLine("Concatenated full name: " + fullName);
            Console.WriteLine(); // Empty line for spacing

            // ===== PART 2: Convert String to Uppercase =====
            Console.WriteLine("--- Part 2: String to Uppercase ---");

            // Create a string variable with mixed case letters
            string cityName = "Toronto";

            // Display the original string before conversion
            Console.WriteLine("Original city name: " + cityName);

            // Use the ToUpper() method to convert all characters to uppercase
            string cityUppercase = cityName.ToUpper();

            // Display the converted uppercase string
            Console.WriteLine("Uppercase city name: " + cityUppercase);
            Console.WriteLine(); // Empty line for spacing

            // ===== PART 3: StringBuilder for Building Paragraph =====
            Console.WriteLine("--- Part 3: StringBuilder Paragraph ---");

            // Create a new StringBuilder object to efficiently build strings
            // StringBuilder is better for multiple string modifications than regular concatenation
            StringBuilder paragraph = new StringBuilder();

            // Append the first sentence to the StringBuilder
            paragraph.Append("The weather today is absolutely beautiful. ");

            // Append the second sentence to the StringBuilder
            paragraph.Append("The sun is shining brightly in the clear blue sky. ");

            // Append the third sentence to the StringBuilder
            paragraph.Append("It's a perfect day to go outside and enjoy nature. ");

            // Append the fourth sentence to the StringBuilder
            paragraph.Append("Many people are visiting the park with their families. ");

            // Append the fifth and final sentence to complete the paragraph
            paragraph.Append("Everyone seems happy and relaxed on this wonderful day.");

            // Convert the StringBuilder to a regular string using ToString() method
            string completeParagraph = paragraph.ToString();

            // Display the complete paragraph that was built sentence by sentence
            Console.WriteLine("Complete paragraph built with StringBuilder:");
            Console.WriteLine(completeParagraph);
            Console.WriteLine(); // Empty line for spacing

            // Display a summary of operations performed
            Console.WriteLine("--- Summary ---");
            Console.WriteLine($"Total paragraph length: {completeParagraph.Length} characters");
            Console.WriteLine($"Number of sentences: 5");

            // Keep console window open until user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}