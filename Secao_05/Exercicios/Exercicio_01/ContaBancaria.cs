using System.Globalization;

namespace Exercicio_01
{
    class ContaBancaria
    {
        public string Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(string numero, string titular, double depositoInical): this(numero, titular)
        {
            Deposito(depositoInical);

        }
        public void Deposito(double valor) {
             Saldo += valor;
        }

        public void Saque(double valor) {
             Saldo = (Saldo - valor) - 5;
        }

        public override string ToString()
        {
            return $"Titular: {Titular}, Numero da conta: {Numero} " + 
            $"Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}