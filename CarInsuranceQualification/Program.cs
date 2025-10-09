using System;

namespace CarInsuranceQualification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the application title
            Console.WriteLine("Car Insurance Application");

            // Prompt user for their age
            Console.WriteLine("What is your age?");
            // Read the age input and convert it to an integer
            int applicantAge = Convert.ToInt32(Console.ReadLine());

            // Ask if the applicant has ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            // Read the DUI response and convert to lowercase for consistent comparison
            string duiResponse = Console.ReadLine()?.ToLower() ?? "no";
            // Convert the string response to a boolean (true if they answered "yes")
            bool hasDUI = duiResponse == "yes";

            // Ask for the number of speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            // Read the number of tickets and convert to integer
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Display the qualification question
            Console.WriteLine("Qualified for insurance?");

            // Evaluate qualification based on business rules:
            // - Age must be greater than 15
            // - Must NOT have a DUI (hasDUI must be false)
            // - Speeding tickets must be 3 or fewer
            bool isQualified = (applicantAge > 15) && (!hasDUI) && (speedingTickets <= 3);

            // Display the qualification result as true or false
            Console.WriteLine(isQualified);

            // Pause to allow user to see the result
            Console.ReadLine();
        }
    }
}