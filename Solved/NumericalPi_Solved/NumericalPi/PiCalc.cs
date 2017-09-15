using System;
using System.Threading.Tasks;

namespace NumericalPi
{
    public class PiCalc
    {
        public PiCalc()
        {
        }

        /// <summary>
        /// Executes the calculation of an 
        /// approximate value of pi.
        /// </summary>
        /// <param name="iterations">Number of iterations to perform</param>
        /// <returns>Approximate value of pi</returns>
        public double Calculate(int iterations)
        {
            int insideUnitCircleA = 0;
            int insideUnitCircleB = 0;
            int insideUnitCircleC = 0;
            int insideUnitCircleD = 0;

            Task taskA = Task.Run(() => { insideUnitCircleA = Iterate(iterations / 4); });
            Task taskB = Task.Run(() => { insideUnitCircleB = Iterate(iterations / 4); });
            Task taskC = Task.Run(() => { insideUnitCircleC = Iterate(iterations / 4); });
            Task taskD = Task.Run(() => { insideUnitCircleD = Iterate(iterations / 4); });

            Task.WaitAll(taskA, taskB, taskC, taskD);

            return (insideUnitCircleA + insideUnitCircleB + insideUnitCircleC + insideUnitCircleD) * 4.0 / iterations;
        }

        /// <summary>
        /// Perform a number of "dart-throwing" simulations.
        /// </summary>
        /// <param name="iterations">Number of dart-throws to perform</param>
        /// <returns>Number of throws within the unit circle</returns>
        public int Iterate(int iterations)
        {
            Random _generator = new Random();
            int insideUnitCircle = 0;

            for (int i = 0; i < iterations; i++)
            {
                double x = _generator.NextDouble();
                double y = _generator.NextDouble();

                if (x * x + y * y < 1.0)
                {
                    insideUnitCircle++;
                }
            }

            return insideUnitCircle;
        }
    }
}