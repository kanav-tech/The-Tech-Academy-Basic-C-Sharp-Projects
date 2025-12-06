using System;

namespace EmployeeQuittableApp
{
    // Define the IQuittable interface
    // This interface requires any implementing class to have a Quit() method
    public interface IQuittable
    {
        // Method signature for Quit - no implementation here, just the contract
        void Quit();
    }

    // Employee class that implements the IQuittable interface
    // The colon (:) means Employee inherits from IQuittable
    public class Employee : IQuittable
    {
        // Properties to store employee information
        // Auto-implemented properties with get and set accessors
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        // Constructor to initialize an Employee object with values
        public Employee(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        // Implementation of the Quit() method from IQuittable interface
        // This method must be implemented because Employee implements IQuittable
        public void Quit()
        {
            // Display a message when the employee quits
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the job.");
            Console.WriteLine("We wish them all the best in their future endeavors!");
        }

        // Additional method to display employee information
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}, ID: {Id}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object with sample data
            Employee emp = new Employee("John", "Smith", 12345);

            // Display the employee's information
            Console.WriteLine("Employee Information:");
            emp.DisplayInfo();
            Console.WriteLine();

            // Demonstrate polymorphism by creating an IQuittable reference
            // The reference type is IQuittable, but it points to an Employee object
            // This works because Employee implements the IQuittable interface
            IQuittable quittableEmployee = new Employee("Sarah", "Johnson", 67890);

            // Call the Quit() method through the IQuittable interface reference
            // This demonstrates polymorphism - using an interface type to call methods
            Console.WriteLine("Demonstrating polymorphism with IQuittable:");
            quittableEmployee.Quit();
            Console.WriteLine();

            // We can also call Quit() on the original Employee object
            Console.WriteLine("Calling Quit() on the first employee:");
            emp.Quit();

            // Wait for user input before closing the console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}