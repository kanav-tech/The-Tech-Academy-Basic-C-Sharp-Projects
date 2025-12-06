// Employee.cs
// This file contains the Employee class definition with operator overloading

namespace EmployeeComparison
{
    /// <summary>
    /// Represents an employee with basic identifying information
    /// </summary>
    public class Employee
    {
        // Property to store the unique identifier for the employee
        public int Id { get; set; }

        // Property to store the employee's first name
        // Nullable to avoid CS8618 warning about non-nullable properties
        public string? FirstName { get; set; }

        // Property to store the employee's last name
        // Nullable to avoid CS8618 warning about non-nullable properties
        public string? LastName { get; set; }

        /// <summary>
        /// Overloaded equality operator (==) to compare two Employee objects
        /// Compares employees based on their Id property only
        /// </summary>
        /// <param name="emp1">First employee to compare</param>
        /// <param name="emp2">Second employee to compare</param>
        /// <returns>True if both employees have the same Id, false otherwise</returns>
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null - they are equal if both are null
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // Check if only one object is null - they are not equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }

        /// <summary>
        /// Overloaded inequality operator (!=) to compare two Employee objects
        /// Must be overloaded as a pair with the == operator
        /// </summary>
        /// <param name="emp1">First employee to compare</param>
        /// <param name="emp2">Second employee to compare</param>
        /// <returns>True if employees have different Ids, false otherwise</returns>
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the == operator result
            return !(emp1 == emp2);
        }

        /// <summary>
        /// Override Equals method to maintain consistency with == operator
        /// This is a best practice when overloading == operator
        /// </summary>
        /// <param name="obj">Object to compare with current instance</param>
        /// <returns>True if objects are equal, false otherwise</returns>
        public override bool Equals(object? obj)
        {
            // Check if the object is an Employee type
            if (obj is Employee employee)
            {
                // Use the overloaded == operator for comparison
                return this == employee;
            }
            // Return false if object is not an Employee
            return false;
        }

        /// <summary>
        /// Override GetHashCode to maintain consistency with Equals
        /// This is required when overriding Equals method
        /// </summary>
        /// <returns>Hash code based on the Id property</returns>
        public override int GetHashCode()
        {
            // Return the hash code of the Id property
            return Id.GetHashCode();
        }
    }
}