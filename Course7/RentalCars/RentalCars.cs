using System;
using System.Collections.Generic;

namespace RentalCars
{
    public class RentalCars
    {
        private readonly List<Rental> _rentals = new List<Rental>();

        public RentalCars(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
            rental.Customer.AddRental(rental);
        }

        public string Statement()
        {
            double totalAmount = 0;
            var frequentRenterPoints = 0;

            var r = "Rental Record for " + Name + "\n";
            r += "------------------------------\n";
            var totalAmountOfMoney = new AmountOfMoneyCalculator();
            foreach (Rental rental in _rentals)
            {
                /*Amount of money for each kind of car*/
                double thisAmount = 0;
                var total = totalAmountOfMoney.GetAmountOfMoney(rental);
                thisAmount = total.UpdateTotalAmountOfMoney(rental, thisAmount);

                /*Frequency for each type of Car*/
                thisAmount = total.UpdateFrequencyPoints(rental, thisAmount);

                frequentRenterPoints = 1;

                if (rental.Car.PriceCode == PriceCode.Premium && rental.DaysRented > 1)
                    frequentRenterPoints++;


                IncreaseFrequentPoints(frequentRenterPoints, rental);

                r += rental.Customer.Name + "\t" + rental.Car.Model + "\t" + rental.DaysRented + "d \t" + thisAmount + " EUR\n";
                totalAmount += thisAmount;
            }
            r += "------------------------------\n";
            r += "Total revenue " + totalAmount + " EUR\n";

            return r;
        }

        private static void IncreaseFrequentPoints(int frequentRenterPoints, Rental rental)
        {
            rental.Customer.FrequentRenterPoints += frequentRenterPoints;
        }
    }
}