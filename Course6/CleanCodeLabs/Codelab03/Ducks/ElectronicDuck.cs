using System;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public class ElectronicDuck : Duck
    {
        private bool _isSwitchedOn;

        public override void Quack()
        {
            if (_isSwitchedOn)
            {
                Console.WriteLine("Quack Quack... (in a robot voice)");
            }
        }

        public override void Swim()
        {
            throw new NotImplementedException("Eletronic ducks can't swim, they'll break in water!");
        }

        public void TurnOn()
        {
            _isSwitchedOn = true;
        }

        public void TurnOff()
        {
            _isSwitchedOn = false;
        }
    }
}