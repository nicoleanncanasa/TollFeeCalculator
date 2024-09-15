using TollFeeCalculator.Strategy;

namespace TollFeeCalculator.ConcreteStrategy
{
    /// <summary>
    /// Concrete Strategy for ETC Payment
    /// </summary>
    public class ETCDiscountStrategy : IDiscountStrategy
    {
        // Discount rate for ETC payments (1%)
        private double DISCOUNT_RATE = 0.01;

        // Maximum discount allowed per toll fee transaction
        private double MAX_DISCOUNT = 20.00;

        /// <summary>
        /// Applies a discount to the given toll fee based on the ETC discount rate and the maximum discount limit.
        /// </summary>
        /// <param name="tollFee">The original toll fee before applying any discount.</param>
        /// <returns>The toll fee after applying the discount.</returns>
        public double ApplyDiscount(double tollFee)
        {          
            var discount = tollFee * DISCOUNT_RATE;

            discount = Math.Min(discount, MAX_DISCOUNT);

            tollFee -= discount;    

            return tollFee;
        }
    }
}
