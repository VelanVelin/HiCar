using System;

namespace HiCar.Logic.Entities.Strategies
{
    public class TruckPaymentStrategy : IPaymentStrategy
    {
        public double GetPriceForRental(double dailyRent, double totalDaysRented, double baseKmPrice, double drivenKmWhenRented)
        {
            if (dailyRent <= 0) throw new ArgumentOutOfRangeException(nameof(dailyRent));
            if (totalDaysRented <= 0) throw new ArgumentOutOfRangeException(nameof(totalDaysRented));
            if (baseKmPrice <= 0) throw new ArgumentOutOfRangeException(nameof(baseKmPrice));
            if (drivenKmWhenRented <= 0) throw new ArgumentOutOfRangeException(nameof(drivenKmWhenRented));

            return dailyRent * totalDaysRented * (double)1.5 + baseKmPrice * drivenKmWhenRented * (double)1.5;
        }
    }
}