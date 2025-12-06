using System;

namespace MethodsAndObjectsAssignment
{
    // Step 1: Create a Person class with FirstName and LastName properties
    class Person
    {
        // Property to store the person's first name (data type: string)
        // The = "" initializes the property to an empty string to avoid null reference warnings
        public string FirstName { get; set; } = "";

        // Property to store the person's last name (data type: string)
        // The = "" initializes the property to an empty string to avoid null reference warnings
        public string LastName { get; set; } = "";

        // Step 2: Create a void method called SayName() that prints the full name to console
        // This method takes no parameters and displays the person's full name
        public void SayName()
        {
            // Write the full name to the console in the format "Name: [FirstName] [LastName]"
            // 'this' keyword refers to the current instance of the Person class
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }

    // Step 3: Create an Employee class that inherits from Person
    // The colon (:) indicates inheritance - Employee inherits all properties and methods from Person
    class Employee : Person
    {
        // Add an Id property specific to Employee class (data type: int)
        // This property will store the employee's identification number
        public int Id { get; set; }
    }

    // Main Program class - entry point of the application
    class Program
    {
        // Main method - this is where program execution begins
        static void Main(string[] args)
        {
            // Step 4: Instantiate and initialize an Employee object
            // Create a new Employee object named 'employee' using object initializer syntax
            // Set FirstName to "Sample" and LastName to "Student"
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Step 5: Call the SayName() method inherited from the Person superclass
            // Even though SayName() is defined in Person class, Employee inherits it
            // This will display "Name: Sample Student" to the console
            employee.SayName();

            // Keep the console window open until user presses Enter
            // This allows us to see the output before the program closes
            Console.ReadLine();
        }
    }
}