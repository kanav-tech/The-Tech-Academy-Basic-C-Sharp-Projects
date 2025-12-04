using System;

namespace VoidMethodAssignment
{
    //Class that contains a void method with two integer parameters
    public class MathOperations
    {
        //Void method that takes two integers as parameters
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            //Perform a math operation on the first integer (multiply by 3)
            int result = firstNumber * 3;

            //Display the result of the operation
            Console.WriteLine("First number multiplied by 3: " + result);

            //Display the second integer to the screen
            Console.WriteLine("Second number: " + secondNumber);
        }
    }

    //Main program class
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            //Call the method, passing in two numbers
            mathOps.PerformOperation(10, 25);

            //Add a blank line for readability
            Console.WriteLine();

            //Call the method again, specifying the parameters by name
            mathOps.PerformOperation(firstNumber: 15, secondNumber: 40);

            //Wait for user input before closing (optional)
            Console.ReadLine();
        }
    }
}