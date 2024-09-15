using TollFeeCalculator.Strategy;

namespace TollFeeCalculator.ConcreteContext
{
    /// <summary>
    /// This class is responsible for setting and utilizing a toll fee calculation strategy 
    /// and a discount strategy to compute the final toll fee based on the provided distance.
    /// </summary>
    public class TollFeeCalculatorContext
    {
        private ITollFeeStrategy _tollFeeStrategy;
        private IDiscountStrategy _discountStrategy;

        /// <summary>
        /// Initializes a new instance of the TollFeeCalculatorContext class with the given toll fee and discount strategies.
        /// </summary>
        /// <param name="tollFeeStrategy">The strategy used to calculate the toll fee.</param>
        /// <param name="discountStrategy">The strategy used to apply any discounts on the toll fee.</param>
        public TollFeeCalculatorContext(ITollFeeStrategy tollFeeStrategy, IDiscountStrategy discountStrategy)
        {
            _tollFeeStrategy = tollFeeStrategy;
            _discountStrategy = discountStrategy;
        }

        /// <summary>
        /// Sets a new toll fee calculation strategy.
        /// </summary>
        /// <param name="tollFeeStrategy">The new toll fee calculation strategy to be used.</param>
        public void SetTollFeeStrategy(ITollFeeStrategy tollFeeStrategy)
        {
            _tollFeeStrategy = tollFeeStrategy;
        }

        /// <summary>
        /// Sets a new discount strategy.
        /// </summary>
        /// <param name="discountStrategy">The new discount strategy to be used.</param>
        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        /// <summary>
        /// Calculates the final toll fee based on the current toll fee calculation strategy and discount strategy.
        /// The distance is used by the toll fee strategy to calculate the base toll fee, and the discount strategy is applied afterward.
        /// </summary>
        /// <param name="distance">The distance traveled, which is used in calculating the toll fee.</param>
        /// <returns>The final toll fee after applying the discount.</returns>
        public double CalculateFinalTollFee(double distance)
        {
            var tollFee = _tollFeeStrategy.CalculateTollFee(distance);
            return _discountStrategy.ApplyDiscount(tollFee);    
        }
    }
}
