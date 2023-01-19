﻿using MetodosAbstratos2.Entities;

using System.Collections.Generic;
using System.Globalization;

namespace MetodosAbstratos2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, healthExp));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numEmployees));
                }
            }

            double sum = 0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer e in list)
            {
                double tax = e.Tax();
                sum += tax;
                Console.WriteLine($"{e.Name}: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
