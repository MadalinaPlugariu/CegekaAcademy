using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    public class FactoryApp
    {
        public static void Run()
        {
            var workers = new Worker[]
            {
                new Human("Joe"),
                new Horse("Jack"),
                new Robot("Robo")
            };

            var factoryHall = new FactoryHall(workers);
            factoryHall.StartWorking();
        }
    }
}