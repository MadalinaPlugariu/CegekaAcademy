using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    internal class RegularPriceCodeAmount : MoneyCalculator
    {
        readonly double pricePerDay = 20;
        public override double UpdateTotalAmountOfMoney(Rental _rentals, double thisAmount)
        {
            thisAmount += pricePerDay * 2;
            if (_rentals.DaysRented > 2)
                thisAmount += (_rentals.DaysRented - 2) * pricePerDay * 0.75;
            return thisAmount;
        }
        public override double UpdateFrequencyPoints(Rental _rentals, double thisAmount)
        {
            if (_rentals.Customer.FrequentRenterPoints >= 5)
            {
                thisAmount *= 0.95;
            }
            return thisAmount;
        }
    }
}
