using Exercicio_r.Entities;

using System.Globalization;

namespace Exercicio_r
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter full file path: "); // \temp\in.txt
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] product = sr.ReadLine().Split(',');
                        string name = product[0];
                        double price = double.Parse(product[1], CultureInfo.InvariantCulture);

                        products.Add(new Product(name, price));
                    }
                }

                var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

                var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("IO Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " +  e.Message);
            }
        }
    }
}
