using System;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Robot : Worker, IWork, IRechargeBatteries
    {
        public Robot(string name) : base(name)
        {
        }

        public string RechargeBatteries()
        {
            return "RECHARGING BATTERIES, BEEP";
        }

        public string Work()
        {
            return "DOING SO MUCH WORK, BEEP";
        }
    }
}