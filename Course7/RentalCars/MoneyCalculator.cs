using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    class MoneyCalculator
    {
        readonly double pricePerDay = 20;
        public virtual double UpdateTotalAmountOfMoney(Rental _rentals, double thisAmount)
        {
            thisAmount += _rentals.DaysRented * pricePerDay * 1.5;
            return thisAmount;
        }

        public virtual double UpdateFrequencyPoints(Rental _rentals, double thisAmount)
        {
            if (_rentals.Customer.FrequentRenterPoints >= 5)
            {
                thisAmount *= 0.95;
            }
            return thisAmount;
        }
    }
}
