namespace CleanCodeLabs.Codelab01
{
    public class Car
    {
        public Car(string id, string model, string brand)
        {
            Id = id;
            Model = model;
            Brand = brand;
        }

        public string Id { get; }
        public string Model { get; }
        public string Brand { get; }
    }
}