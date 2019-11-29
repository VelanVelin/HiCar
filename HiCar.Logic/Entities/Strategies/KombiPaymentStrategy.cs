using System;
using System.Collections.Generic;
using System.Text;

namespace HiCar.Logic.Entities.Strategies
{
    class KombiPaymentStrategy : IPaymentStrategy
    {
        public double GetPriceForRental(double dailyRent, double totalDaysRented, double baseKmPrice, double drivenKmWhenRented)
        {
            if (dailyRent <= 0) throw new ArgumentOutOfRangeException(nameof(dailyRent));
            if (totalDaysRented <= 0) throw new ArgumentOutOfRangeException(nameof(totalDaysRented));
            if (baseKmPrice <= 0) throw new ArgumentOutOfRangeException(nameof(baseKmPrice));
            if (drivenKmWhenRented <= 0) throw new ArgumentOutOfRangeException(nameof(drivenKmWhenRented));

            return dailyRent * totalDaysRented * (double)1.3 + baseKmPrice * drivenKmWhenRented;
        }
    }
}
