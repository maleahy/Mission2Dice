using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Dice
{
    class DiceRoller
    {
        private Random random = new Random();
        //// Use an array to keep track of the number of times that each combination is thrown. In other words,
        //// keep track of how many times the combination of the two simulated dice is 2, how many times
        //// the combination is 3, and so on, all the way up through 12.

        public int[] RollDice(int numRolls)
        {
            int[] total = new int[13];

            for (int rolled = 0; rolled < numRolls; rolled++) // Corrected loop increment
            {
                int rollOne = random.Next(1, 7);
                int rollTwo = random.Next(1, 7);
                total[rollOne + rollTwo]++;
            }

            // That method in the second class should return the array containing the results.
            return total;
        }
    }
}
