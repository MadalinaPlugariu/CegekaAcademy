using System;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    internal class Lunchroom
    {
        private readonly IEat[] _eat;

        public Lunchroom(IEat[] eat)
        {
            _eat = eat;
        }

        public void StartLunching()
        {
            foreach (var luncher in _eat)
            {
                    Console.WriteLine(luncher.Eat());
            }
        }
    }
}