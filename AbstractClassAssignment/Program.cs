// Import the System namespace for Console functionality
using System;

// Define the namespace for organizing the code
namespace AbstractClassAssignment
{
    // Create an abstract class called "Person" with two string properties: firstName and lastName
    public abstract class Person
    {
        // Property to store the first name of the person
        // Initialized to empty string to avoid null reference warnings
        public string firstName { get; set; } = string.Empty;

        // Property to store the last name of the person
        // Initialized to empty string to avoid null reference warnings
        public string lastName { get; set; } = string.Empty;

        // Abstract method SayName() - must be implemented by derived classes
        // This method has no implementation in the abstract class
        public abstract void SayName();
    }

    // Create the Employee class that inherits from the Person class
    public class Employee : Person
    {
        // Override and implement the SayName() method from the Person class
        // This method will display the employee's full name to the console
        public override void SayName()
        {
            // Write the first name and last name to the console
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }

    // Main Program class containing the entry point of the application
    class Program
    {
        // Main method - the starting point of the console application
        static void Main(string[] args)
        {
            // Instantiate a new Employee object with firstName "Sample" and lastName "Student"
            // Create the employee instance
            Employee sam = new Employee() { firstName = "Sample", lastName = "Student" };

            // Call the SayName() method on the employee object
            // This will display the employee's full name
            sam.SayName();

            // Keep the console window open until user presses a key
            Console.ReadLine();
        }
    }
}