using System;
using System.Threading;

namespace DiceGame
{
    class DieNSides
    {
        private int _value;
        private int _noOfSides;
        private Random _generator;

        public int Value
        {
            get { return _value; }
        }

        public DieNSides(int noOfSides)
        {
            _noOfSides = noOfSides;

            // The generator is used for generating random numbers
            _generator = new Random();
            Thread.Sleep(10); // This is needed for magical purposes...
            Roll();  // This puts the die in a well-defined state
        }

        /// <summary>
        /// Roll the die: the value will be set to a random number
        /// between 1 and _noOfSides (both included).
        /// </summary>
        public void Roll()
        {
            _value = _generator.Next(_noOfSides) + 1;
        }
    }
}
