using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// Represents a single standard 6-sided die
    /// </summary>
    class Die
    {
        // one random object for all instances of die = static
        private static Random rand;
        /// <summary>
        /// Runs before any other instances are created
        /// </summary>
        
        static Die()
        {
            rand = new Random();
        }

        /// <summary>
        /// Rolls die after die is constructed to begin with
        /// a random number.
        /// </summary>
        public Die()
        {
            
            Roll();
        }

        /// <summary>
        /// The currently rolled value.
        /// </summary>
        public byte FaceUpValue { get; private set; }

        /// <summary>
        /// Roles die and give the face up value a randome number
        /// between 1 and 6 inclusive.
        /// </summary>
        /// <Returns>returns the rolled number</Returns>>
        public byte Roll()
        {
            const int minDieInBound = 1;
            const int maxDieExUpperBound = 7;

            //random needs to be fixed. Will not work in succession.
            // make random object to share
            //Random rand = new Random();
            int numRolled = rand.Next(minDieInBound, maxDieExUpperBound);

            FaceUpValue = (byte)numRolled;
            return FaceUpValue;
        }
    }
}
