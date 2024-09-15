namespace TollFeeCalculator.Strategy
{
    /// <summary>
    /// Interface for defining a strategy to calculate toll fees.
    /// </summary>
    public interface ITollFeeStrategy
    {
        /// <summary>
        /// Calculates the toll fee based on the distance traveled.
        /// </summary>
        /// <param name="distance">The distance traveled</param>
        /// <returns>The calculated toll fee for the given distance.</returns>
        double CalculateTollFee(double distance);
    }
}
