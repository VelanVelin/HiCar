using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiCar.Logic.Entities
{
    public class Customer : Entity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Ssn { get; set; }

        private readonly IList<Rental> _rentals = new List<Rental>();
        public IReadOnlyList<Rental> Rentals => _rentals.ToList();

        public void RentCar(Car car, long meterWhenRented)
        {
            if (_rentals.Count >= 1)
            {
                throw new Exception("Cannot have more than 1 rental per customer!");
            }

            if (car.IsRented)
            {
                throw new Exception("Cannot rent a car that is already rented!");
            }
        }

        public void ReturnCar(Car car, long meterWhenReturned)
        {

        }
    }
}
