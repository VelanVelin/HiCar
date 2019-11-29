namespace HiCar.Logic.Entities.Strategies
{
    public interface IPaymentStrategy
    {
        double GetPriceForRental(double dailyRent, double totalDaysRented, double baseKmPrice, double drivenKmWhenRented);
    }
}