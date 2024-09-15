using System.Runtime.InteropServices;
using TollFeeCalculator.Strategy;

namespace TollFeeCalculator.ConcreteStrategy
{
    /// <summary>
    /// Concrete Strategy for calculating toll fees for Class 3 vehicles
    /// </summary>
    public class Class3TollFeeStrategy : ITollFeeStrategy
    {
        private double CLASS3_RATE = 5.75;
        /// <summary>
        /// Calculates the toll fee for Class 3 vehicles based on the distance traveled.
        /// </summary>
        /// <param name="distance">The distance traveled</param>
        /// <returns>The total calculated toll fee</returns>
        public double CalculateTollFee(double distance)
        {
            return distance * CLASS3_RATE;
        }
    }
}
