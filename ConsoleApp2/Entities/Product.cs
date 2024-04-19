using System.Globalization;

namespace ConsoleApp2.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discont { get; set; }

        public Product()
        {
        }

        public Product(string name, double price, double discont = 0.0)
        {
            Name = name;
            Price = price;
            Discont = discont;
        }

        public virtual string priceTag()
        {
            return " $ " + (Price - (Price * (Discont / 100))).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
