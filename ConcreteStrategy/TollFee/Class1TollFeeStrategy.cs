using TollFeeCalculator.Strategy;

namespace TollFeeCalculator.ConcreteStrategy
{
    /// <summary>
    /// Concrete Strategy for calculating toll fees for Class 1 vehicles
    /// </summary>
    public class Class1TollFeeStrategy : ITollFeeStrategy
    {
        private double CLASS1_RATE = 5.25;
        /// <summary>
        /// Calculates the toll fee for Class 1 vehicles based on the distance traveled.
        /// </summary>
        /// <param name="distance">The distance traveled</param>
        /// <returns>The total calculated toll fee</returns>
        public double CalculateTollFee(double distance)
        {
            return distance * CLASS1_RATE;
        }
    }
}
