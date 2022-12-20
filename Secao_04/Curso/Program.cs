using System;
using System.Globalization;

namespace Secao_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o RAIO: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circuferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("CIRCUFERENCIA: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("VOLUME: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}