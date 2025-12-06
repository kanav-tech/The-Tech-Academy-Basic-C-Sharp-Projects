//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    // 1. Create an Employee class with Id, FirstName and LastName properties
    public class Employee
    {
        // Property to store employee ID
        public int Id { get; set; }

        // Property to store employee's first name
        // Using = string.Empty to initialize and avoid nullable warnings
        public string FirstName { get; set; } = string.Empty;

        // Property to store employee's last name
        // Using = string.Empty to initialize and avoid nullable warnings
        public string LastName { get; set; } = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method, create a list of at least 10 employees.
            // At least two employees should have the first name "Joe".
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Schmidt" },
                new Employee() { Id = 2, FirstName = "John", LastName = "Thomas" },
                new Employee() { Id = 3, FirstName = "Jane", LastName = "Doe" },
                new Employee() { Id = 4, FirstName = "Danny", LastName = "Glover" },
                new Employee() { Id = 5, FirstName = "Deborah", LastName = "Hartley" },
                new Employee() { Id = 6, FirstName = "Mike", LastName = "Jones" },
                new Employee() { Id = 7, FirstName = "Joe", LastName = "Joesperson" },
                new Employee() { Id = 8, FirstName = "Maria", LastName = "Cohen" },
                new Employee() { Id = 9, FirstName = "Maria", LastName = "Rodriguez" },
                new Employee() { Id = 10, FirstName = "Stephanie", LastName = "Stevens" }
            };

            // 3. Using a foreach loop, create a new list of all employees with the first name "Joe".
            // Create a new empty list to store employees named Joe
            List<Employee> joes1 = new List<Employee>();

            // Loop through each employee in the employees list
            foreach (Employee employee in employees)
            {
                // Check if the current employee's FirstName property equals "Joe"
                if (employee.FirstName == "Joe")
                {
                    // If true, add this employee to the joes1 list
                    joes1.Add(employee);
                }
            }

            // 4. Do the same thing again, but this time with a lambda expression.
            // Use LINQ's Where method with a lambda expression to filter employees
            // The lambda expression (e => e.FirstName == "Joe") checks each employee's FirstName
            // ToList() converts the result to a List<Employee>
            List<Employee> joes2 = employees.Where(e => e.FirstName == "Joe").ToList();

            // 5. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            // Use LINQ's Where method with a lambda expression to filter by Id
            // The lambda expression (e => e.Id > 5) checks if employee's Id is greater than 5
            // ToList() converts the filtered result to a List<Employee>
            List<Employee> bigId = employees.Where(e => e.Id > 5).ToList();

            // Display the results to verify the code works correctly
            Console.WriteLine("Employees named 'Joe' (using foreach loop):");
            foreach (Employee joe in joes1)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees named 'Joe' (using lambda expression):");
            foreach (Employee joe in joes2)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with Id > 5:");
            foreach (Employee emp in bigId)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Wait for user input before closing
            Console.ReadLine();
        }
    }
}