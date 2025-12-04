using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // ====================================================================
        // PART 1: One-dimensional Array with User Input
        // ====================================================================
        // Create a one-dimensional array of strings
        string[] wordstart = {
            "Welcome to The ",
            "I'm Principal, ",
            "Our goal is to provide our students with a "
        };

        // Create another array for demonstration
        string[] wordend = {
            " Academy.",
            ".",
            " learning experience."
        };

        // Ask the user to input some text
        List<string> responses = new List<string>();
        Console.WriteLine("Please enter your first name (noun):");
        responses.Add(Console.ReadLine() ?? "");
        Console.WriteLine("Please enter the name of someone infamous:");
        responses.Add(Console.ReadLine() ?? "");
        Console.WriteLine("Please enter an adjective:");
        responses.Add(Console.ReadLine() ?? "");

        // Create a loop that goes through each string in the Array, adding the user's text to the string.
        for (int i = 0; i < wordstart.Length; i++)
        {
            wordstart[i] += responses[i];
            Console.WriteLine(wordstart[i] + wordend[i]);
        }

        Console.ReadLine();
        // Then create a loop that prints off each string in the Array on a separate line.
        for (int i = 0; i < wordstart.Length; i++)
        {
            Console.WriteLine(wordstart[i] + wordend[i]);
        }

        Console.WriteLine("The strings we used:");
        Console.ReadLine();

        // ====================================================================
        // PART 2: Infinite Loop (Fixed)
        // ====================================================================
        // Create an infinite loop (Uncomment line "i--" for infinite loop.
        // Fix the infinite loop.
        // Comment "i--";

        // INFINITE LOOP EXPLANATION:
        // An infinite loop occurs when the loop condition never becomes false.
        // In this case, if we uncomment "i--", the counter decrements instead of 
        // incrementing, so i will never reach the end condition (wordstart.Length)
        // and the loop will run forever.

        // THE FIX: By commenting out "i--" and using "i++" instead, we ensure
        // the loop counter increments properly and will eventually exit when
        // i reaches wordstart.Length.

        for (int i = 0; i < wordstart.Length; i++)
        {
            Console.WriteLine(wordstart[i] + wordend[i]);
            // i--;  // This line causes infinite loop - COMMENTED OUT TO FIX
        }

        Console.ReadLine();

        // ====================================================================
        // PART 3: Loops with < and <= Operators
        // ====================================================================
        // "Is that a ghost?!"
        Console.WriteLine("Is that a ghost?!");
        StringBuilder boo = new StringBuilder();
        boo.Append("B");

        // Create a loop where the comparison that's used to determine whether 
        // to continue iterating the loop is a "<" operator.
        // This loop runs while boo.Length is LESS THAN 10 (stops at length 9)
        while (boo.Length < 10)
        {
            boo.Append("o");
        }
        boo.Append("!");
        Console.ReadLine();
        Console.WriteLine(boo);

        // Part 3b
        StringBuilder ahh = new StringBuilder();
        ahh.Append("A");

        // Add a loop where the comparison that's used to determine whether 
        // to continue iterating the loop is a "<=" operator.
        // This loop runs while ahh.Length is LESS THAN OR EQUAL TO 10 
        // (stops at length 10, one more iteration than the < operator)
        while (ahh.Length <= 10)
        {
            ahh.Append("h");
        }
        ahh.Append("!");
        Console.WriteLine(ahh);
        Console.ReadLine();

        // ====================================================================
        // PART 4: List with Unique Strings - Search and Display Index
        // ====================================================================
        // Create a List of strings where each item in the list is unique.
        List<string> teams = new List<string>() {
            "Bucks", "Raptors", "Celtics", "Sixers", "Heat", "Pacers",
            "Nets", "Magic", "Pistons", "Hornets", "Hawks", "Bulls",
            "Wizards", "Cavaliers"
        };

        Console.WriteLine("NBA Eastern Conference Standings:");

        // Ask the user to input text to search for in the list.
        Console.WriteLine("Please enter team name:");
        int standing = 0;
        bool isValid = false;
        int index = 0;

        // Create a loop that iterates through the list and then displays 
        // the index of the array that contains matching text on the screen.
        do
        {
            int i2 = 0;
            string teamRequest = Console.ReadLine() ?? "";

            foreach (string team in teams)
            {
                // Check if the user's input matches the current team
                if (teamRequest == team)
                {
                    standing = i2 + 1;
                    index = i2;
                }
                i2++;
            }

            // Add code to that above loop to tell a user if they put in 
            // text that isn't in the List.
            if (standing == 0)
            {
                Console.WriteLine("That is not a valid team name. Enter again:");
            }
            // Add code to that above loop that stops it from executing 
            // once a match has been found.
            else
            {
                isValid = true;
            }

        } while (!isValid);

        Console.WriteLine("Processing... Index is: " + index + ". So...");
        Console.WriteLine("Standing is: " + standing);
        Console.ReadLine();

        // ====================================================================
        // PART 5: List with Duplicate Strings - Display All Matching Indices
        // ====================================================================
        // Create a list of strings that has at least two identical strings in the list
        List<string> tables = new List<string>() {
            "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Vacant",
            "Taken", "Reserved", "Taken"
        };

        Console.WriteLine("Welcome to Swell Taco! - How to CHECK-IN as have a reservation type: " +
            "\"Reserved\". ..If you are joining a party that is already here type \"Taken\"! " +
            "...Otherwise type \"Vacant\".");

        // Ask the user to input text to search for in the list.
        Console.WriteLine("Please enter one of the 3 choices:");
        string selection = Console.ReadLine() ?? "";

        // Create a loop that iterates through the loop and then displays 
        // the indices of the array that contain matching text on the screen.
        while ((selection == "Vacant") || (selection == "Reserved") || (selection == "Taken"))
        {
            // Add code that tells a user if they put in text that isn't in the list.
            selection = Console.ReadLine() ?? "";
        }

        Console.WriteLine("The tables that match your selection are numbered:");

        // Create a loop that iterates through the loop and then displays 
        // the indices of the array that contain matching text on the screen.
        for (int i3 = 0; i3 < tables.Count; i3++)
        {
            if (selection == tables[i3])
            {
                Console.WriteLine(i3);
            }
        }

        Console.ReadLine();

        // ====================================================================
        // PART 6: List with Duplicates - Identify Unique vs Duplicate Items
        // ====================================================================
        // Create a list of strings that has at least two identical strings in the list
        List<string> names = new List<string> {
            "Joe", "Jim", "Jeffrey", "Bob", "Jeff", "Ray", "Ray"
        };

        Console.WriteLine("Class Roster:");

        // Create a foreach loop that evaluates each item in the list, and displays 
        // a message showing the string and whether or not it has already appeared in the list.
        foreach (string name in names)
        {
            // Check if this name appears more than once in the list
            // by comparing the first index where it appears with the last index
            if (names.IndexOf(name) != names.LastIndexOf(name))
            {
                // If IndexOf and LastIndexOf return different values, 
                // the name appears multiple times

                // Check if this is the first occurrence of the duplicate
                if (names.IndexOf(name) == names.IndexOf(name))
                {
                    Console.WriteLine(name + " - this item is unique");
                }
                else
                {
                    Console.WriteLine(name + " - this item is a duplicate");
                }
            }
            else
            {
                // If IndexOf and LastIndexOf return the same value,
                // this name only appears once in the list
                Console.WriteLine(name + " - this item is unique");
            }
        }

        // Better implementation using a HashSet to track seen names:
        Console.WriteLine("\n--- Better Implementation ---");
        HashSet<string> seenNames = new HashSet<string>();

        foreach (string name in names)
        {
            // Try to add the name to the HashSet
            // If it returns false, the name was already in the set (duplicate)
            if (seenNames.Add(name))
            {
                // Successfully added - this is the first occurrence
                Console.WriteLine(name + " - this item is unique");
            }
            else
            {
                // Failed to add - this name already appeared before
                Console.WriteLine(name + " - this item is a duplicate");
            }
        }

        Console.ReadLine();
    }
}