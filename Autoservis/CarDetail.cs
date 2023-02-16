namespace Autoservis
{
    internal class CarDetail
    {
        public CarDetail(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public int Price { get; }
    }
}
