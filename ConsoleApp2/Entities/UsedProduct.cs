using System;
using System.Globalization;

namespace ConsoleApp2.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            manufactureDate = date;
        }

        public override string priceTag()
        {
            return " (used)" + base.priceTag() + " (Manufacture date: " + manufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
