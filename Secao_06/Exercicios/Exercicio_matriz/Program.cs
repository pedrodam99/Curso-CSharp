namespace Exercicio_matriz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num_negativos = 0;
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            // primeiro for percorre as linhas
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                // esse for percorre as colunas
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                    if (mat[i, j] < 0) {
                        num_negativos++;
                    }
                }
            }

            //IMPRIMINDO DIAGONAL PRINCIPAL
            System.Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < n; i++)
            {
                System.Console.Write($"{mat[i, i]} ");
            }
            System.Console.WriteLine();
            //IMPRIMINDO NÚMEROS NEGATIVOS
            System.Console.WriteLine($"Números Negativos: {num_negativos}");
            
        }
    }
}
