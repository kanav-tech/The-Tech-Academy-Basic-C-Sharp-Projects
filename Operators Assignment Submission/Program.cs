// Program.cs
// Main program file that demonstrates the Employee class with operator overloading

using System;

namespace EmployeeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a header for the console application
            Console.WriteLine("Employee Comparison Demo");
            Console.WriteLine("========================\n");

            // Create the first Employee object and initialize its properties
            Employee employee1 = new Employee
            {
                Id = 101,                    // Assign unique identifier
                FirstName = "John",          // Assign first name
                LastName = "Smith"           // Assign last name
            };

            // Create the second Employee object and initialize its properties
            Employee employee2 = new Employee
            {
                Id = 102,                    // Assign different unique identifier
                FirstName = "Jane",          // Assign first name
                LastName = "Doe"             // Assign last name
            };

            // Display information about the first employee
            Console.WriteLine($"Employee 1: {employee1.FirstName} {employee1.LastName} (ID: {employee1.Id})");

            // Display information about the second employee
            Console.WriteLine($"Employee 2: {employee2.FirstName} {employee2.LastName} (ID: {employee2.Id})");
            Console.WriteLine();

            // Compare employee1 and employee2 using the overloaded == operator
            // This will return false because their Id properties are different (101 != 102)
            bool areEqual = employee1 == employee2;
            Console.WriteLine($"Are Employee 1 and Employee 2 equal? {areEqual}");

            // Compare employee1 and employee2 using the overloaded != operator
            // This will return true because their Id properties are different
            bool areNotEqual = employee1 != employee2;
            Console.WriteLine($"Are Employee 1 and Employee 2 not equal? {areNotEqual}");
            Console.WriteLine();

            // Create a third Employee object with the same Id as employee1
            Employee employee3 = new Employee
            {
                Id = 101,                    // Same Id as employee1
                FirstName = "Jonathan",      // Different first name
                LastName = "Smithson"        // Different last name
            };

            // Display information about the third employee
            Console.WriteLine($"Employee 3: {employee3.FirstName} {employee3.LastName} (ID: {employee3.Id})");
            Console.WriteLine();

            // Compare employee1 and employee3 using the overloaded == operator
            // This will return true because they have the same Id (both are 101)
            // Note: The names are different, but only Id is compared
            bool areEqual2 = employee1 == employee3;
            Console.WriteLine($"Are Employee 1 and Employee 3 equal? {areEqual2}");
            Console.WriteLine("(Note: They have the same ID but different names)");

            // Compare employee1 and employee3 using the overloaded != operator
            // This will return false because they have the same Id
            bool areNotEqual2 = employee1 != employee3;
            Console.WriteLine($"Are Employee 1 and Employee 3 not equal? {areNotEqual2}");

            // Wait for user input before closing the console window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}