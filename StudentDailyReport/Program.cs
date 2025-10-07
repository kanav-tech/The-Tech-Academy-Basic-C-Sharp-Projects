using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the college name header
            Console.WriteLine("Academy of Learning Career College");

            // Display the report title
            Console.WriteLine("Student Daily Report");

            // Prompt for and store the student's name
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine()!;

            // Ask which course the student is currently taking
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine()!;

            // Get the current page number from the student
            Console.WriteLine("What page number?");
            int currentPage = Convert.ToInt32(Console.ReadLine());

            // Check if the student needs assistance (boolean response)
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpResponse = Console.ReadLine()!;
            bool needsAssistance = bool.Parse(helpResponse);

            // Collect any positive experiences the student wants to share
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine()!;

            // Gather additional feedback from the student
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string additionalFeedback = Console.ReadLine()!;

            // Ask about study duration for the day
            Console.WriteLine("How many hours did you study today?");
            string hoursInput = Console.ReadLine()!;
            int studyDuration = Convert.ToInt32(hoursInput);

            // Display closing message to the student
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}