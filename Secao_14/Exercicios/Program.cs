using System.Globalization;
using System.Collections;
using System;

using Exercicio.Entities;

namespace Exercicio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

        }
    }
}