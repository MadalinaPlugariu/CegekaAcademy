using System;


namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            DummyDatabase d = new DummyDatabase();
            d.Connect();
            d.Save("Buna");
            d.Disconnect();

            d.Connect();
            d.Save("Hei");
            d.Disconnect();

            d.Connect();
            d.Save("Salut");
            d.Disconnect();

            d.Connect();
            d.Save("Hello");
            d.Disconnect();

            d.Connect();
            d.Save("Good bye!");
            d.Disconnect();

            d.Connect();
            d.Save("Adios!");
            d.Disconnect();

            foreach (var l in d.WordsSaved)
            {
                Console.WriteLine(l);
            }
        }
    }
}
