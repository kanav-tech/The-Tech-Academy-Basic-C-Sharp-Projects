using System;

namespace PackageExpressShipping
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message and instructions to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            // Read the weight input and convert it to a decimal for precision
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package weight exceeds the maximum allowed weight of 50
            if (packageWeight > 50)
            {
                // Display error message if package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End the program immediately using return
                return;
            }

            // Prompt the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            // Read and convert the width to decimal
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            // Read and convert the height to decimal
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

            // Prompt the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            // Read and convert the length to decimal
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total of all three dimensions
            decimal dimensionsTotal = packageWidth + packageHeight + packageLength;

            // Check if the sum of dimensions exceeds the maximum allowed total of 50
            if (dimensionsTotal > 50)
            {
                // Display error message if package dimensions are too large
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End the program immediately
                return;
            }

            // Calculate the shipping quote using the formula:
            // (width * height * length * weight) / 100
            decimal shippingQuote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

            // Display the calculated shipping quote formatted as currency with dollar sign
            Console.WriteLine("Your estimated total for shipping this package is: $" + shippingQuote.ToString("0.00"));

            // Display thank you message to the user
            Console.WriteLine("Thank you!");

            // Pause to allow user to see the result before window closes
            Console.ReadLine();
        }
    }
}