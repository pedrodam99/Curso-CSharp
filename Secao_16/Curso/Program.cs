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
            // Define the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define query expression
            IEnumerable<int> result = numbers
                .Where(e => e % 2 == 0)
                .Select(e => e * 10);

            // Execute the query
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }

        }
    }
}