// Program.cs
using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Step 3: Get user input and call the DivideByTwo method
            Console.WriteLine("Enter a number to divide by 2:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            // Call the void method that divides by 2 and displays result
            mathOps.DivideByTwo(userNumber);

            // Step 4: Demonstrate method with output parameters
            int result;
            mathOps.PerformOperation(20, out result);
            Console.WriteLine($"Method with output parameter result: {result}");

            // Step 5: Demonstrate method overloading
            Console.WriteLine("\nDemonstrating method overloading:");
            mathOps.Calculate(10);
            mathOps.Calculate(10, 5);
            mathOps.Calculate(10.5, 3.2);

            // Step 6: Call static class method
            Console.WriteLine("\nCalling static class method:");
            StaticMathOperations.MultiplyByTwo(15);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Step 1: Create a class with a void method that divides by 2
    public class MathOperations
    {
        // Void method that takes an integer, divides it by 2, and outputs the result
        public void DivideByTwo(int number)
        {
            // Divide the input number by 2
            int result = number / 2;
            
            // Display the result to the console
            Console.WriteLine($"Result of {number} divided by 2 is: {result}");
        }

        // Step 4: Method with output parameter
        // This method demonstrates using 'out' parameter to return a value
        public void PerformOperation(int input, out int output)
        {
            // Perform a calculation and assign to output parameter
            output = input * 3;
        }

        // Step 5: Method overloading - same method name, different parameters
        
        // Overloaded method #1: Takes one integer parameter
        public void Calculate(int a)
        {
            Console.WriteLine($"Calculate with one int parameter: {a} * 2 = {a * 2}");
        }

        // Overloaded method #2: Takes two integer parameters
        public void Calculate(int a, int b)
        {
            Console.WriteLine($"Calculate with two int parameters: {a} + {b} = {a + b}");
        }

        // Overloaded method #3: Takes two double parameters
        public void Calculate(double a, double b)
        {
            Console.WriteLine($"Calculate with two double parameters: {a} * {b} = {a * b}");
        }
    }

    // Step 6: Declare a static class
    // Static classes cannot be instantiated and can only contain static members
    public static class StaticMathOperations
    {
        // Static method that multiplies a number by 2
        public static void MultiplyByTwo(int number)
        {
            // Calculate the result
            int result = number * 2;
            
            // Display the result
            Console.WriteLine($"Static method: {number} multiplied by 2 is: {result}");
        }
    }
}