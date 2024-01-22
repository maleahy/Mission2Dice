using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Dice

{
    class DiceWords
    {
        static void Main(string[] args)
        {
            // Allow the user to choose how many times the “dice” will be thrown. 
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numRolls = int.Parse(Console.ReadLine());

            // Then, once you have the number of rolls, pass that number to a second class that has a method that 
            // simulates the roll of the dice for the number of times that the user specified.
            // That method in the second class should return the array containing the results. 
            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(numRolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.");

            // In the first class, use that array to print a histogram (using the * character)
            // that shows the total percentage each number was rolled. Each * will represent
            // 1% of the total rolls.
            for (int total = 2; total <= 12; total++)
            {
                Console.Write($"{total}: ");
                int percentage = (int)Math.Round((double)(results[total] * 100) / numRolls);

                for (int percent = 0; percent < percentage; percent++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

