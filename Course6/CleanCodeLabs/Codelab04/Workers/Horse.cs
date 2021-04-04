using System;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Horse : Worker, IEat, IWork
    {
        public Horse(string name) : base(name)
        {
        }

        public string Eat()
        {
            return "Eating some jummy hay!";
        }

        public string Work()
        {
            return "Working like a true working horse";
        }
    }
}