using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operation 1: Multiply input by 50
            // Using long data type to handle inputs larger than 10,000,000
            Console.WriteLine("Enter a number to multiply by 50:");
            string input1 = Console.ReadLine()!;
            long number1 = Convert.ToInt64(input1);
            long result1 = number1 * 50;
            Console.WriteLine(number1 + " multiplied by 50 is: " + result1);
            Console.WriteLine(); // Empty line for better readability

            // Operation 2: Add 25 to the input
            Console.WriteLine("Enter a number to add 25 to:");
            string input2 = Console.ReadLine()!;
            int number2 = Convert.ToInt32(input2);
            int result2 = number2 + 25;
            Console.WriteLine(number2 + " plus 25 equals: " + result2);
            Console.WriteLine();

            // Operation 3: Divide input by 12.5
            // Using double to handle decimal division results
            Console.WriteLine("Enter a number to divide by 12.5:");
            string input3 = Console.ReadLine()!;
            double number3 = Convert.ToDouble(input3);
            double result3 = number3 / 12.5;
            Console.WriteLine(number3 + " divided by 12.5 equals: " + result3);
            Console.WriteLine();

            // Operation 4: Check if input is greater than 50
            // Using comparison operator to return true/false boolean result
            Console.WriteLine("Enter a number to check if it's greater than 50:");
            string input4 = Console.ReadLine()!;
            int number4 = Convert.ToInt32(input4);
            bool isGreaterThan50 = number4 > 50;
            Console.WriteLine("Is " + number4 + " greater than 50? " + isGreaterThan50);
            Console.WriteLine();

            // Operation 5: Find the remainder when dividing by 7
            // Using modulus operator (%) to get the remainder
            Console.WriteLine("Enter a number to divide by 7 and get the remainder:");
            string input5 = Console.ReadLine()!;
            int number5 = Convert.ToInt32(input5);
            int remainder = number5 % 7;
            Console.WriteLine("The remainder of " + number5 + " divided by 7 is: " + remainder);
            Console.WriteLine();

            // Keep console window open until user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}