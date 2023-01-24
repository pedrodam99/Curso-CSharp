using System.IO;
using System.Collections.Generic;
using System.Globalization;

using Exercicios.Entities;


namespace Exercicios
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            string path = @"\temp\exercicio\items.csv";
            string sourceFolderPath = Path.GetDirectoryName(path);
            string targetPath = sourceFolderPath + @"\out";
            Directory.CreateDirectory(targetPath);

             string targetFile = targetPath + @"\summary.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] item = sr.ReadLine().Split(",");

                        string name = item[0];
                        double price = double.Parse(item[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(item[2]);

                        list.Add(new Product(name, price, qtd));
                    }
                }

                using (StreamWriter sw = File.AppendText(targetFile))
                {
                    foreach (Product p in list)
                    {
                        string product = $"{p.Name},{p.Total().ToString("F2", CultureInfo.InvariantCulture)}";
                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error Occurred: " + e.Message);
            }
        }
    }
}