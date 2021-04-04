using System;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Human : Worker, IEat, IWork
    {
        public Human(string name) : base(name)
        {
        }

        public string Eat()
        {
            return "Eating my 'bokes'";
        }

        public string Work()
        {
            return "Doing some hard work, but I do get tired";
        }
    }
}