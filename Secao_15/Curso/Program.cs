using Curso.Services;
using Curso.Entities;

using System.Globalization;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calcService = new CalculationService();
            
            Product max = calcService.Max(list);

            Console.Write("Max: " + max);
        }
    }
}