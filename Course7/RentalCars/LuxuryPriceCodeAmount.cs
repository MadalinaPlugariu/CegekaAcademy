using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    internal class LuxuryPriceCodeAmount : MoneyCalculator
    {
        readonly double pricePerDay = 70;
        public override double UpdateTotalAmountOfMoney(Rental _rentals, double thisAmount)
        {
            try
            {
                if (_rentals.Customer.FrequentRenterPoints < 3)
                {
                    throw new NotAllowedException("You're not allowed to add a luxury category if you're don't have minimum 3 FrequentRenterPoints");
                }
                thisAmount += pricePerDay;
            }
            catch(NotAllowedException e)
            {
                Console.WriteLine(e.Message);
            }
            return thisAmount;
            
        }
    }

    public class NotAllowedException : Exception
    {
        public NotAllowedException(string message) : base(message)
        {

        }
    }
}
