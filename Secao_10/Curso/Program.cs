using Curso.Entities;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            System.Console.WriteLine(acc1.Balance);
            System.Console.WriteLine(acc2.Balance);
        }
    }
}
