using System;
using HiCar.Logic.Common;
using HiCar.Logic.Entities.Strategies;

namespace HiCar.Logic.Entities
{
    public class Rental : IAggregateRoot
    {
        public Guid Id { get; set; }
        public long MeterWhenRented { get; set; }
        public long MeterWhenReturned { get; set; }
        public double Price { get; set; }
        public double DaysRented { get; set; }
        public double RentPerDay { get; set; }
        public double BaseKmPrice { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public IPaymentStrategy PaymentStrategy { get; set; }

        private Rental()
        {
        }

        public Rental(long meterWhenRented, long meterWhenReturned, double price, Customer customer, Car car, IPaymentStrategy paymentStrategy)
        {
            MeterWhenRented = meterWhenRented;
            MeterWhenReturned = meterWhenReturned;
            Price = price;
            Customer = customer;
            Car = car;
            PaymentStrategy = paymentStrategy;
        }

        public virtual void Update(long meterWhenReturned)
        {
            MeterWhenReturned = meterWhenReturned;
        }

        public virtual void GetPriceOnReturn()
        {
            this.Price = this.PaymentStrategy.GetPriceForRental(DaysRented, RentPerDay, BaseKmPrice, MeterWhenReturned - MeterWhenRented);
        }
    }
}