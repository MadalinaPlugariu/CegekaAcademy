using System;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public class Duck:IDuck
    {
        public override void Quack()
        {
            Console.WriteLine("Quack...");
        }

        public override void Quack(Duck[] ducks)
        {
            throw new NotImplementedException();
        }

        public override void Swim()
        {
            Console.WriteLine("Swim...");
        }

        public override void Swim(Duck[] ducks)
        {
            throw new NotImplementedException();
        }
    }
}