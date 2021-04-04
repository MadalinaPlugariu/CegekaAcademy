using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab01
{
    public class CarManager
    {
        CarConcatenation car = new CarConcatenation();
        private readonly List<Car> _carsDb = new List<Car>(new[]
        {
            new Car("1", "Golf III", "Volkswagen"),
            new Car("2", "Multipla", "Fiat"),
            new Car("3", "Megane", "Renault")
        });

        public List<Car> GetList()
        {
            return _carsDb;
        }

        public Car GetCarFromDb(string carId)
        {
            foreach (var car in _carsDb)
            {
                if (car.Id.Equals(carId))
                {
                    return car;
                }
            }

            return null;
        }

        public string GetCarsNames()
        {
            var carName = car.BuildCarsNames();
            return carName.Substring(0, carName.Length - 2);
        }

        public Car GetBestCar()
        {
            Car bestCar = null;
            foreach (var car in _carsDb)
            {
                if (bestCar == null || car.Model.CompareTo(bestCar.Model) > 0)
                {
                    bestCar = car;
                }
            }
            return bestCar;
        }
    }
}