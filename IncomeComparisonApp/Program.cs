using System;

namespace IncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Display header for first person's information
            Console.WriteLine("Person 1");

            // Prompt for and read Person 1's hourly rate
            Console.WriteLine("Hourly Rate?");
            string person1Rate = Console.ReadLine();

            // Prompt for and read Person 1's hours worked per week
            Console.WriteLine("Hours worked per week?");
            string person1Hours = Console.ReadLine();

            // Calculate Person 1's annual salary (hourly rate × hours per week × 52 weeks)
            int annualSalaryPerson1 = Convert.ToInt32(person1Rate) * Convert.ToInt32(person1Hours) * 52;

            // Display header for second person's information
            Console.WriteLine("Person 2");

            // Prompt for and read Person 2's hourly rate
            Console.WriteLine("Hourly Rate?");
            string person2Rate = Console.ReadLine();

            // Prompt for and read Person 2's hours worked per week
            Console.WriteLine("Hours worked per week?");
            string person2Hours = Console.ReadLine();

            // Calculate Person 2's annual salary (hourly rate × hours per week × 52 weeks)
            int annualSalaryPerson2 = Convert.ToInt32(person2Rate) * Convert.ToInt32(person2Hours) * 52;

            // Display Person 1's annual salary with label
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalaryPerson1);

            // Display Person 2's annual salary with label
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalaryPerson2);

            // Compare the two salaries and store the result as a boolean
            bool person1EarnsMore = annualSalaryPerson1 > annualSalaryPerson2;

            // Display the comparison question
            Console.WriteLine("Person 1 makes more money than Person 2");

            // Display the boolean result of the comparison (true/false)
            Console.WriteLine(person1EarnsMore);

            // Wait for user input before closing (optional, helps see output)
            Console.ReadLine();
        }
    }
}