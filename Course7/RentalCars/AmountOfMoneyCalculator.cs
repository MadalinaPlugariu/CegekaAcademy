using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    class AmountOfMoneyCalculator
    {
        public MoneyCalculator GetAmountOfMoney(Rental _rental)
        {
            switch (_rental.Car.PriceCode)
            {
                case PriceCode.Regular:
                    return new RegularPriceCodeAmount();
                case PriceCode.Mini:
                    return new MiniPriceCodeAmount();
                case PriceCode.Luxury:
                    return new LuxuryPriceCodeAmount();
                default:
                    return new MoneyCalculator();
            }
        }
    }
}
