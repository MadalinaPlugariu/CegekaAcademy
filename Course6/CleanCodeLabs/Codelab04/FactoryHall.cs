using System;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    public class FactoryHall
    {
        private readonly IWork[] _workers;
        private readonly IEat[] _eat;
        private readonly IRechargeBatteries[] _rechargeBatteries;

        public FactoryHall(IWork[] workers)
        {
            _workers = workers;
        }

        public FactoryHall(IEat[] eat)
        {
            _eat = eat;
        }
        public FactoryHall(IRechargeBatteries[] rechargeBatteries)
        {
            _rechargeBatteries = rechargeBatteries;
        }

        public FactoryHall(Worker[] workers)
        {
            Workers = workers;
        }

        public Worker[] Workers { get; }

        public void StartWorking()
        {
            // WORK
            foreach (var worker in _workers)
            {
                Console.WriteLine(worker.Work());
            }

            // EAT
            new Lunchroom(_eat).StartLunching();

            // RECHARGE BATTERIES
            BatteryRechargerFacility.RechargeBatteriesOf(_rechargeBatteries);
        }
    }
}