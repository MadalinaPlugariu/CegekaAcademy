using System;
using System.Drawing;

namespace CleanCodeLabs.Codelab05
{
    public class Lamp:ILamp
    {
        public Lamp(Color lightColor)
        {
            LightColor = lightColor;
        }

        public Color LightColor { get; }

        public void TurnOn()
        {
            Console.WriteLine($"Lamp turned on, shining {LightColor} light");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lamp turned off");
        }

    }
}