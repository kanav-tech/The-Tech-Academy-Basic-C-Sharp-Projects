using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        // Display the list to the user
        Console.WriteLine("List of numbers: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        // Variable to control the loop for valid input
        bool validInput = false;

        // Loop until user provides valid input
        while (!validInput)
        {
            // Step 1: Ask the user for a number to divide by
            Console.Write("Enter a number to divide each number in the list by: ");

            // Step 5: Put the division logic in a try/catch block
            try
            {
                // Read user input and parse it to a float
                string input = Console.ReadLine() ?? "";
                float divisor = float.Parse(input);

                // Check if the user entered zero
                if (divisor == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero. Please enter a non-zero number.\n");
                }
                else
                {
                    // Step 1: Loop through each number in the list and divide by user input
                    Console.WriteLine("\nResults:");
                    foreach (int num in numbers)
                    {
                        // Perform division and display result
                        float result = num / divisor;
                        Console.WriteLine($"{num} divided by {divisor} = {result}");
                    }

                    // Set validInput to true to exit the loop
                    validInput = true;
                }
            }
            // Step 5: Catch block to handle format exceptions (when user enters a string)
            catch (FormatException)
            {
                // Display error message for invalid input
                Console.WriteLine("Error: Invalid input. Please enter a valid number.\n");
            }
            // Catch any other general exceptions
            catch (Exception ex)
            {
                // Display the error message
                Console.WriteLine($"An error occurred: {ex.Message}\n");
            }
        }

        // Step 5: Message to indicate program has exited the try/catch block
        Console.WriteLine("\nThe program has emerged from the try/catch block and continued with execution.");
        Console.WriteLine("Program completed successfully!");
    }
}