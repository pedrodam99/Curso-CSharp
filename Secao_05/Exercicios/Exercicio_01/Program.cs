using System;
using System.Globalization;

namespace Exercicio_01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            string numeroConta = Console.ReadLine();

            Console.Write("Entre o titular da conta: ");
            string nomeConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            string resp = Console.ReadLine();
            if (resp == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInical = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, nomeConta, depositoInical);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeConta);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            System.Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            System.Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
        }
    }
}