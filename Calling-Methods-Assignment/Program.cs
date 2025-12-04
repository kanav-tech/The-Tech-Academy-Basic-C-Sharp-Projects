// Program.cs - Complete single file version
// This file contains both the Program class and MathMethods class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    // MathMethods class containing three mathematical methods
    public class MathMethods
    {
        // Create a method that takes one integer parameter and returns an integer
        // This method calculates power points by multiplying the input by 15
        public static int PowerUp(int energy)
        {
            // Calculate power points using the energy value
            int powerPoints = energy * 15;

            // Return the calculated power points
            return powerPoints;
        }

        // Create a method that takes one integer parameter and returns an integer
        // This method calculates shield strength based on armor rating
        public static int Shield(int armor)
        {
            // Set base protection value
            int base_protection = 5;

            // Set armor multiplier
            int armor_multiplier = 8;

            // Set reduction factor
            int reduction = -2;

            // Calculate critical defense coefficient
            double crit_defense = 0.75;

            // Calculate total shield strength using formula
            int shieldStrength = (int)((base_protection + (armor_multiplier + armor + reduction)) * crit_defense);

            // Return the shield strength value
            return shieldStrength;
        }

        // Create a method that takes one integer parameter and returns an integer
        // This method calculates damage output based on player's power level
        public static int Strike(int power)
        {
            // Set enemy resistance value
            int enemy_resistance = 3;

            // Set weapon strength
            int weapon_strength = 6;

            // Set bonus damage
            int bonus_damage = 2;

            // Set critical hit multiplier
            int crit_multiplier = 4;

            // Calculate total damage dealt to enemy
            int damageDealt = (power + (weapon_strength + bonus_damage) - enemy_resistance) * crit_multiplier;

            // Return the damage value
            return damageDealt;
        }
    }

    // Main Program class
    class Program
    {
        // Main method - entry point of the application
        static void Main(string[] args)
        {
            // Display welcome message informing user about the battle scenario
            Console.WriteLine("You've entered the Arena! A fierce Warrior appears and challenges you to combat.");

            // Ask user to input their energy level
            Console.WriteLine("Enter your energy level:");

            // Read user input for energy and convert to integer
            int energy = Convert.ToInt32(Console.ReadLine());

            // Call the PowerUp method and store the result
            int powerPoints = MathMethods.PowerUp(energy);

            // Display the power points calculation result
            Console.WriteLine("You have gathered " + powerPoints + " power points from " + energy + " energy.");

            // Ask user to input their armor rating
            Console.WriteLine("Enter your armor rating:");

            // Read user input for armor and convert to integer
            int armor = Convert.ToInt32(Console.ReadLine());

            // Call the Shield method passing the armor value
            int shieldStrength = MathMethods.Shield(armor);

            // Display the shield strength result
            Console.WriteLine("Your shield is active. Protection level: " + shieldStrength + " points.");

            // Ask user to input their power level for attack
            Console.WriteLine("Enter your power level for the strike:");

            // Read user input for power and convert to integer
            int power = Convert.ToInt32(Console.ReadLine());

            // Call the Strike method to calculate damage
            int damageDealt = MathMethods.Strike(power);

            // Display the damage calculation result
            Console.WriteLine("You have unleashed a devastating strike and dealt " + damageDealt + " points of damage!");

            // Wait for user to press any key before closing the program
            Console.ReadLine();
        }
    }
}