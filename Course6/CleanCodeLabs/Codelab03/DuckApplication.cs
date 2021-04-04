using CleanCodeLabs.Codelab03.Ducks;

namespace CleanCodeLabs.Codelab03
{
    public class DuckApplication
    {
        public static void Start()
        {
            var pool = new Pool();
            pool.OpenForBusiness(new Duck(), new ElectronicDuck());
        }
    }
}