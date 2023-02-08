using Curso.Services;
using Curso.Entities;

namespace Curso
{

    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Mouse", 50.0));
            list.Add(new Product("Tablet", 350.0));
            list.Add(new Product("HD Case", 80.0));

            list.RemoveAll(ProductTest);
            foreach (var p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        } 
    }
}