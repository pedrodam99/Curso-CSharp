using System;
using System.Globalization;

namespace Exercicio_03 {
    internal class Program {
        static void Main(string[] args){
            Aluno al = new Aluno();

            Console.Write("Nome do Aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Console.WriteLine("NOTA FINAL: " + al.CalcularNotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(al.DefinirSituacao());
        }
    }
}
