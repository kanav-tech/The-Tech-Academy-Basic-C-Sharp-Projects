using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("=== Array and List Index Selector ===\n");

            // ===== PART 1: String Array =====
            // Initialize a one-dimensional array containing various programming languages
            string[] languages = { "C#", "Python", "JavaScript", "Java", "Ruby", "Go" };

            // Display the available indices for the user
            Console.WriteLine("String Array - Programming Languages:");
            Console.WriteLine($"Available indices: 0 to {languages.Length - 1}");
            Console.Write("Please enter an index to view a language: ");

            // Attempt to parse user input and display the corresponding string
            try
            {
                // Read user input and check if it's not null
                string? input = Console.ReadLine();

                // Convert user input from string to integer
                int stringIndex = int.Parse(input ?? "");

                // Retrieve and display the string at the specified index
                Console.WriteLine($"Result: {languages[stringIndex]}\n");
            }
            catch (IndexOutOfRangeException)
            {
                // Handle case where user enters an invalid index
                Console.WriteLine("Error: That index doesn't exist in the array.\n");
            }
            catch (FormatException)
            {
                // Handle case where user enters non-numeric input
                Console.WriteLine("Error: Please enter a valid number.\n");
            }

            // ===== PART 2: Integer Array =====
            // Create an array of integers representing years
            int[] years = { 2020, 2021, 2022, 2023, 2024, 2025 };

            // Show available range to the user
            Console.WriteLine("Integer Array - Years:");
            Console.WriteLine($"Available indices: 0 to {years.Length - 1}");
            Console.Write("Please enter an index to view a year: ");

            // Process user input with error handling
            try
            {
                // Read user input and check if it's not null
                string? input = Console.ReadLine();

                // Read and convert the input to an integer index
                int intIndex = int.Parse(input ?? "");

                // Access the integer at the given index and display it
                Console.WriteLine($"Result: {years[intIndex]}\n");
            }
            catch (IndexOutOfRangeException)
            {
                // Inform user when the index is out of bounds
                Console.WriteLine("Error: That index doesn't exist in the array.\n");
            }
            catch (FormatException)
            {
                // Inform user when input is not a valid integer
                Console.WriteLine("Error: Please enter a valid number.\n");
            }

            // ===== PART 3: List of Strings =====
            // Create a List collection to store city names
            List<string> cities = new List<string>
            {
                "Toronto",
                "Vancouver",
                "Montreal",
                "Calgary",
                "Ottawa"
            };

            // Display available options to the user
            Console.WriteLine("List of Strings - Canadian Cities:");
            Console.WriteLine($"Available indices: 0 to {cities.Count - 1}");
            Console.Write("Please enter an index to view a city: ");

            // Handle user input with comprehensive error checking
            try
            {
                // Read user input and check if it's not null
                string? input = Console.ReadLine();

                // Parse the user's index selection
                int listIndex = int.Parse(input ?? "");

                // Retrieve and display the list element at the specified index
                Console.WriteLine($"Result: {cities[listIndex]}\n");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Display error message for invalid list index
                Console.WriteLine("Error: That index doesn't exist in the list.\n");
            }
            catch (FormatException)
            {
                // Display error message for non-numeric input
                Console.WriteLine("Error: Please enter a valid number.\n");
            }

            // Pause before closing to allow user to read output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}