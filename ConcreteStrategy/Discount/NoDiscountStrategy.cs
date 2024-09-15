using TollFeeCalculator.Strategy;

namespace TollFeeCalculator.ConcreteStrategy
{
    /// <summary>
    /// Concrete Strategy for applying no discount. 
    /// This is used when no discount is applicable.
    /// </summary>
    public class NoDiscountStrategy : IDiscountStrategy
    {
        /// <summary>
        /// Applies no discount to the given toll fee. Simply returns the original toll fee.
        /// </summary>
        /// <param name="tollFee">The original toll fee without any discount.</param>
        /// <returns>The original toll fee, unchanged.</returns>
        public double ApplyDiscount(double tollFee)
        {
            return tollFee;
        }
    }
}
