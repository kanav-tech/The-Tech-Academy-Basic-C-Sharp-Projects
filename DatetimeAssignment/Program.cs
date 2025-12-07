//Program.cs
// Import the System namespace to access DateTime and Console classes
using System;

// Define the namespace for organizing the code
namespace DateTimeAssignment
{
    // Define the main Program class
    class Program
    {
        // Main method - entry point of the console application
        static void Main(string[] args)
        {
            // Step 1: Print the current date and time to the console
            // DateTime.Now gets the current system date and time
            Console.WriteLine("The current time is: " + DateTime.Now);

            // Step 2: Ask the user for a number
            // Display a prompt message asking for user input
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours: ");

            // Read the user's input from the console and parse it to a float (decimal number)
            // Console.ReadLine() captures the user's text input
            // The null-forgiving operator (!) tells the compiler we're sure this won't be null
            // float.Parse() converts the string input to a floating-point number
            float answer = float.Parse(Console.ReadLine()!);

            // Step 3: Print what time it will be in the amount of hours the user input
            // DateTime.Now gets the current time
            // .AddHours(answer) adds the user's number of hours to the current time
            // The entire output shows: current time, user input, and calculated future time
            Console.WriteLine("{0} + {1} hour(s) = {2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));

            // Keep the console window open until user presses a key
            // This prevents the application from closing immediately
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}