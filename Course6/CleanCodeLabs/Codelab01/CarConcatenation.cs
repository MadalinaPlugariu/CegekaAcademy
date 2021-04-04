using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab01
{
    class CarConcatenation
    {
        CarManager carManager = new CarManager();
        public string BuildCarsNames()
        {
            var sb = new StringBuilder();
            foreach (var car in carManager.GetList())
            {
                sb.Append(car.Brand);
                sb.Append(" ");
                sb.Append(car.Model);
                sb.Append(", ");
            }

            var carNames = sb.ToString();
            return carNames;
        }
    }
}
