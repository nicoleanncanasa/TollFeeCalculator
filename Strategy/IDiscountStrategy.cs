namespace TollFeeCalculator.Strategy
{
    /// <summary>
    /// Interface for defining a strategy to apply discounts to toll fees.
    /// </summary>
    public interface IDiscountStrategy
    {
        /// <summary>
        /// Applies a discount to the given toll fee.
        /// </summary>
        /// <param name="tollFee">The original toll fee before any discount is applied.</param>
        /// <returns>The toll fee after applying the discount.</returns>
        double ApplyDiscount(double tollFee);
    }
}
