using System.Globalization;

namespace HerancaPolimorfismo2.Entities
{
    class UsedProduct: Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(){}

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string ToString()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}