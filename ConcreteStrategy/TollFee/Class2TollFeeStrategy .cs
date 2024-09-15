using TollFeeCalculator.Strategy;

namespace TollFeeCalculator.ConcreteStrategy
{
    /// <summary>
    /// Concrete Strategy for calculating toll fees for Class 2 vehicles
    /// </summary>
    public class Class2TollFeeStrategy : ITollFeeStrategy
    {
        private double CLASS2_RATE = 5.50;
        /// <summary>
        /// Calculates the toll fee for Class 2 vehicles based on the distance traveled.
        /// </summary>
        /// <param name="distance">The distance traveled</param>
        /// <returns>The total calculated toll fee</returns>
        public double CalculateTollFee(double distance)
        {
            return distance * CLASS2_RATE;
        }
    }
}
