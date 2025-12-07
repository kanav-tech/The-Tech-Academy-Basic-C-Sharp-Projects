using System;

namespace ConstructorAssignment
{
    // Main Program class that contains the entry point
    class Program
    {
        // Main method - entry point of the console application
        static void Main(string[] args)
        {
            // Create a const variable - a constant string that cannot be changed after initialization
            const string const1 = "Your name is: ";
            // Create another const variable for the favorite number prompt
            const string const2 = "Your favorite number is: ";

            // Display prompts to the console to ask user for input
            Console.WriteLine("Enter your name or favorite number: ");

            // Create a variable using the "var" keyword - compiler infers the type as string
            // This reads user input from the console
            var answer = Console.ReadLine();

            // Check if answer is null or empty to avoid null reference warnings
            if (string.IsNullOrEmpty(answer))
            {
                // If no input is provided, display a message and exit the program
                Console.WriteLine("No input provided. Exiting...");
                return;
            }

            // Try to parse the user input as a float number
            // If successful, it means the user entered a number
            if (float.TryParse(answer, out float x))
            {
                // If input is a number, display it to the console
                Console.WriteLine(const2);
                // Create a new Chain object using Constructor #1 (accepts only a float)
                // This will chain to Constructor #3
                Chain newChain = new Chain(x);
                // Read a line to pause before closing
                Console.ReadLine();
            }
            // If the input is not a number, treat it as a name (string)
            else
            {
                // Display the name to the console
                Console.WriteLine(const1);
                // Create a new Chain object using Constructor #2 (accepts only a string)
                // This will chain to Constructor #3
                Chain newChain = new Chain(answer);
                // Read a line to pause before closing
                Console.ReadLine();
            }
        }
    }
}