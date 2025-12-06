//Program.cs
using System;

namespace ParsingEnumsAssignment
{
    //Create an enum for the days of the week.
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Initialize a boolean variable to control the while loop
            bool isValid = false;

            //Keep looping until the user enters a valid day
            while (!isValid)
            {
                try
                {
                    //Prompt the user to enter the current day of the week.
                    Console.WriteLine("Enter the current day of the week:");
                    string? dayInput = Console.ReadLine();

                    //Assign the value to a variable of that enum data type you just created.
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayInput ?? "");

                    //Display a success message with the parsed day
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();

                    //Set isValid to true to exit the loop
                    isValid = true;
                }
                catch (ArgumentException)
                {
                    //Print error message if an invalid day is entered
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
        }
    }
}