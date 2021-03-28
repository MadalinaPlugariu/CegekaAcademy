using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Homework3
{
    class SolarSystem
    {
        private List<string> universe = new List<string>();
        public ReadOnlyCollection<string> UniverseRead
        {
            get
            {
                return universe.AsReadOnly();
            }
        }
        public List<string> Universe { get; private set; }
       

        public void AddNewPlanetAtTheEnd(string planet)
        {
            universe.Add(planet);
        }
        public void InsertNewPlanet(string planet, int index)
        {
            universe.Insert(index, planet);
        }
        public void RemovePlanet(int index)
        {
            universe.RemoveAt(index);
        }
        public void ReplacePlanet(string planet, int index)
        {
            universe[index] = planet;

        }
        public void SwapPlanets(int firstIndex, int secondIndex)
        {
            var aux = universe[firstIndex];
            universe[firstIndex] = universe[secondIndex];
            universe[secondIndex] = aux;
        }
        public void ReverseOrder()
        {
            universe.Reverse();
        }
        public void ReadOnly()
        {
           /* IList<string> universeRead = universe.AsReadOnly();*/
            foreach(var i in UniverseRead)
            {
                Console.WriteLine(i);
            }
        }
        public void Print()
        {
            foreach (var i in universe)
                Console.WriteLine(i);
        }

    }
}
