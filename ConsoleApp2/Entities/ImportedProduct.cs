using System.Globalization;

namespace ConsoleApp2.Entities
{
    internal class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double cFee) : base(name, price)
        {
            customsFee = cFee;
        }

        public double totalPrice()
        {
            return Price + customsFee;
        }

        public override string priceTag()
        {
            return " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + customsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
