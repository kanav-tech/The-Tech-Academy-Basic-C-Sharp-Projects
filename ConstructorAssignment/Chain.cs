using System;

namespace ConstructorAssignment
{
    // Define a public class called Chain
    public class Chain
    {
        // Properties to store name and favorite number
        public string Name { get; set; }
        public float Num { get; set; }

        // Constructor #1: Accepts one parameter (a float for favorite number)
        // This constructor chains to Constructor #3 by passing the num and a default name "Bob"
        public Chain(float num) : this(num, "Bob")
        {
            // Call WriteLine method to display the number and default name
            Console.WriteLine(num + " and your default name is " + Name);
        }

        // Constructor #2: Accepts one parameter (a string for name)
        // This constructor chains to Constructor #3 by passing 42 as default favorite number and the provided name
        public Chain(string name) : this(42, name)
        {
            // Call WriteLine method to display the name and default favorite number
            Console.WriteLine(name + " and your default favorite number is " + Num);
        }

        // Constructor #3: Accepts both parameters (a float and a string)
        // This is the main constructor that initializes both properties
        public Chain(float num, string name)
        {
            // Assign the provided name to the Name property
            Name = name;
            // Assign the provided number to the Num property
            Num = num;
        }
    }
}

