namespace Exercicio_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quarto[] hotel = new Quarto[10];

            // ENTRADA DE DADOS
            System.Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"Aluguel #{i + 1}");

                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Quarto: ");
                int num_quarto = int.Parse(Console.ReadLine());

                hotel[num_quarto] = new Quarto(nome, email);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < hotel.Length; i++)
            {
                if (hotel[i] != null)
                {
                    System.Console.WriteLine($"{i}: {hotel[i].Nome}, {hotel[i].Email}");
                }
            }
        }
    }
}