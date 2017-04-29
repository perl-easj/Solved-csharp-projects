using System;

namespace CalculationSimulation
{
    /// <summary>
    /// This class acts as a cache of already calculated results
    /// </summary>
    class Cache
    {
        private int[,] cacheValues;
        public Cache(int xDimension, int yDimension)
        {
            // Create a cache of results with the specified dimensions
            cacheValues = new int[xDimension, yDimension];

            for (int x = 0; x < xDimension; x++)
            {
                for (int y = 0; y < yDimension; y++)
                {
                    cacheValues[x, y] = Constants.CalculationNoValue;
                }
            }
        }

        /// <summary>
        /// Look up the value stored in cell [x,y]
        /// </summary>
        public int Lookup(int x, int y)
        {
            return cacheValues[x, y];
        }

        /// <summary>
        /// Stores the given value in cell [x,y]
        /// </summary>
        public void Insert(int x, int y, int value)
        {
            cacheValues[x, y] = value;
        }
    }
}
