using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public abstract class IDuck
    {
        public abstract void Quack();
        public abstract void Swim();
        public abstract void Quack(Duck[] ducks);
        public abstract void Swim(Duck[] ducks);
    }
}
