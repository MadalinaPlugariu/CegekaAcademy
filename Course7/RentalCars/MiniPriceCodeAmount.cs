using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
     internal class MiniPriceCodeAmount:MoneyCalculator
    {
        double pricePerDay = 20;
        public override double UpdateTotalAmountOfMoney(Rental _rentals, double thisAmount)
        {
            thisAmount += pricePerDay * 3 * 0.75;
            if (_rentals.DaysRented > 3)
                thisAmount += (_rentals.DaysRented - 3) * pricePerDay * 0.5;
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
