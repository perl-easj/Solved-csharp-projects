using System;
using System.Threading;

namespace DiceGame
{
    /// <summary>
    /// This class represents a single N-sided die
    /// The creator of Die objects specify the value of N
    /// </summary>
    class DieNSides
    {
        #region Instance fields
        private int _value;
        private int _noOfSides;
        private Random _generator;
        #endregion

        #region Constructor
        public DieNSides(int noOfSides)
        {
            _noOfSides = noOfSides;
            _generator = new Random(); // The generator is used for generating random numbers
            Roll();  // This puts the die in a well-defined state
        }
        #endregion

        #region Properties
        public int Value
        {
            get { return _value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Roll the die: the value will be set to a random number
        /// between 1 and _noOfSides (both included).
        /// </summary>
        public void Roll()
        {
            Thread.Sleep(10); // This is needed for magical purposes...
            _value = _generator.Next(_noOfSides) + 1;
        } 
        #endregion
    }
}
