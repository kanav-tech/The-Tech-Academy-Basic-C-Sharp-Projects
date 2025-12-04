using System;

namespace MainMethodAssignment
{
    //Class that contains overloaded methods
    public class MathOperations
    {
        //First method that takes an integer
        public int Calculate(int number)
        {
            //Multiply number by 5
            return number * 5;
        }

        //Second method that takes a decimal number
        public int Calculate(decimal number)
        {
            //Add 15 to the decimal and convert to int
            int result = Convert.ToInt32(number);
            return result + 15;
        }

        //Third method that takes a string parameter
        public int Calculate(string number)
        {
            //Convert the string to an int to perform math operation
            int result = Convert.ToInt32(number);
            //Subtract 8 from the number
            return result - 8;
        }
    }

    //Main program class
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathOperations class
            MathOperations math1 = new MathOperations();

            //Call the first method with an int parameter
            Console.WriteLine(math1.Calculate(12));

            //Call the second method with a decimal parameter
            Console.WriteLine(math1.Calculate(8.5m));

            //Call the third method with a string parameter
            Console.WriteLine(math1.Calculate("25"));
        }
    }
}