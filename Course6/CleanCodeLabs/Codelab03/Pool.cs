using CleanCodeLabs.Codelab03.Ducks;

namespace CleanCodeLabs.Codelab03
{
    public class Pool 
    {
        public void OpenForBusiness(params Duck[] ducks)
        {
            Quack(ducks);
            Swim(ducks);
        }
        private void Quack(Duck[] ducks)
        {
            foreach (var duck in ducks)
            {
                if (duck.GetType() == typeof(ElectronicDuck))
                {
                    ((ElectronicDuck)duck).TurnOn();
                }

                duck.Quack();
            }
        }

        private void Swim(Duck[] ducks)
        {
            foreach (var duck in ducks)
            {
                if (duck.GetType() != typeof(ElectronicDuck))
                {
                    duck.Swim();
                }
            }
        }
    }
}