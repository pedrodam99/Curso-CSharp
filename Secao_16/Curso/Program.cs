using Curso.Entities;
using Curso.Services;

namespace Curso
{

    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        public static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}