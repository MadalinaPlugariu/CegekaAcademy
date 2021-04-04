using System.Drawing;

namespace CleanCodeLabs.Codelab05
{
    /// <summary>
    ///     A Switch to Turn something (in this case: a Lamp) ON or OFF
    /// </summary>
    internal class Switch
    {
        public readonly ILamp _ilamp;

        public Switch(ILamp ilamp)
        {
            _ilamp = ilamp;
            _ilamp = new Lamp(Color.Yellow);
        }

        public bool IsSwitchOn { get; private set; }
        public void Toggle()
        {
            IsSwitchOn = !IsSwitchOn;
            if (IsSwitchOn)
            {
                _ilamp.TurnOn();
            }
            else
            {
                _ilamp.TurnOff();
            }
        }
    }
}