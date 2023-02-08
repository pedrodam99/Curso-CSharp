using Curso.Services;
using Curso.Entities;

using System.Linq;

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

            
            Func<Product, string> func = NameUpper;

            List<string> newList = list.Select(func).ToList();

            foreach (string s in newList)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}