using Curso.Services;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }

            CalculationService calcService = new CalculationService();
            
            int max = calcService.Max(list);

            Console.Write("Max: " + max);
        }
    }
}