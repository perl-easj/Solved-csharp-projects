using System;

namespace RolePlayV15
{
    /// <summary>
    /// This class is just a thin wrapper around the Random class
    /// </summary>
    class RandomNumberGenerator
    {
        private static Random _generator = new Random();

        /// <summary>
        /// Returns a random number in the interval specified by the parameters
        /// (both values included)
        /// </summary>
        /// <param name="min">Lower limit for random number</param>
        /// <param name="max">Upper limit for random number</param>
        /// <returns></returns>
        public static int RandomNumber(int min, int max)
        {
            return _generator.Next(min, max);
        }
    }
}
