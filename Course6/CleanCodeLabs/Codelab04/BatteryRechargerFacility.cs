using System;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    internal class BatteryRechargerFacility
    {
        public static void RechargeBatteriesOf(IRechargeBatteries[] rechargers)
        {
            foreach (var recharger in rechargers)
            {
                    Console.WriteLine(recharger.RechargeBatteries());
            }
        }
    }
}