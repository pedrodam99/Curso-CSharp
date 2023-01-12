using Curso.Entities;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BuninessAccount account = new BuninessAccount(123, "Pedro", 2000, 3000);

            Console.WriteLine(account.Balance);

            // account.Balance = 200.00;
        }
    }
}
