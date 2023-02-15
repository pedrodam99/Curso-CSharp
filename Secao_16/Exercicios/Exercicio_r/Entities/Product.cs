namespace Exercicio_r.Entities
{
    class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}