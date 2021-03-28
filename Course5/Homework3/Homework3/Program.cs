using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            SolarSystem s = new SolarSystem();
            s.AddNewPlanetAtTheEnd("Earth");
            s.AddNewPlanetAtTheEnd("Mars");
            s.AddNewPlanetAtTheEnd("Uranus");
            s.AddNewPlanetAtTheEnd("Venus");
            s.AddNewPlanetAtTheEnd("Jupiter");

            s.InsertNewPlanet("Impostor", 1);

            s.ReplacePlanet("Moon", 3);

            s.RemovePlanet(2);

            s.SwapPlanets(0, 2);

            s.ReverseOrder();
            
            s.Print();

            //s.ReadOnly();
        }
    }
}
