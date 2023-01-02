using System.Collections.Generic;

namespace Exercicio_matriz2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // entrada de numeros de linhas e de colunas
            System.Console.Write("Digite o numero de linhas: ");
            int m = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o numero de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            // entrada dos dados das matriz
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            // numero que vai ser procurado
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine($"Position {i},{j}:");

                        if (j > 0)
                        {
                            System.Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j < n - 1)
                        {
                            System.Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i > 0)
                        {
                            System.Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i < n - 1)
                        {
                            System.Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}