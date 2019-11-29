using System;

namespace HiCar.Logic.Entities.Strategies
{
    public class NormalPaymentStrategy : IPaymentStrategy
    {
        public double GetPriceForRental(double dailyRent, double totalDaysRented, double baseKmPrice, double drivenKmWhenRented)
        {
            if (dailyRent <= 0) throw new ArgumentOutOfRangeException(nameof(dailyRent));
            if (totalDaysRented <= 0) throw new ArgumentOutOfRangeException(nameof(totalDaysRented));
            return totalDaysRented * dailyRent;
        }
    }
}