using TollFeeCalculator.ConcreteContext;
using TollFeeCalculator.ConcreteStrategy;
using TollFeeCalculator.Enums;
using TollFeeCalculator.Strategy;


string continueCalculation = "y";

do
{
    ITollFeeStrategy tollFeeStrategy = null;
    IDiscountStrategy discountStrategy = null;

    Console.WriteLine("\nTOLL FEE CALCULATOR\n");

    Console.WriteLine("Enter vehicle type (1, 2, or 3):");
    if(!int.TryParse(Console.ReadLine(), out int vehicleClass))
    {
        Console.WriteLine("Invalid vehicle type.\n");
        continue;
    }

    switch (vehicleClass)
    {
        case (int)VehicleType.Class1:
            tollFeeStrategy = new Class1TollFeeStrategy();
            break;
        case (int)VehicleType.Class2:
            tollFeeStrategy = new Class2TollFeeStrategy();
            break;
        case (int)VehicleType.Class3:
            tollFeeStrategy = new Class3TollFeeStrategy();
            break;
        default:
            Console.WriteLine("Invalid vehicle type.\n");
            continue;
    }

    Console.WriteLine("Enter distance travelled:");
    if(!double.TryParse(Console.ReadLine(), out double distance))
    {
        Console.WriteLine("Invalid distance.\n");
        continue;
    }

    Console.WriteLine("Select payment mode (Enter 1 for Cash or 2 for ETC):");
    if (!int.TryParse(Console.ReadLine(), out int paymentMode))
    {
        Console.WriteLine("Invalid payment mode.\n");
        continue;
    }

    switch (paymentMode)
    {
        case (int)PaymentMode.Cash:
            discountStrategy = new NoDiscountStrategy();
            break;
        case (int)PaymentMode.ETC:
            discountStrategy = new ETCDiscountStrategy();
            break;
        default:
            Console.WriteLine("Invalid payment mode.\n");
            continue;
    }

    TollFeeCalculatorContext tollFeeCalculatorContext = new TollFeeCalculatorContext(tollFeeStrategy, discountStrategy);
    var tollFee = tollFeeCalculatorContext.CalculateFinalTollFee(distance);

    Console.WriteLine($"Final Toll Fee: {tollFee:F2}");


    Console.WriteLine("\nDo you want to calculate another toll fee? (y/n):");
    continueCalculation = Console.ReadLine()?.ToLower();
}
while (continueCalculation == "y");

Console.WriteLine("Exiting the toll fee calculator.");
