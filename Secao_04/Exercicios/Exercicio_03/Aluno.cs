using System.Globalization;

namespace Exercicio_03 {
    class Aluno {
        public string? Nome;
        public double Nota1, Nota2, Nota3;
        public double NotaFinal;


        public double CalcularNotaFinal(){
            NotaFinal =  Nota1 + Nota2 + Nota3;
            return NotaFinal;
        }

        public string DefinirSituacao(){
            NotaFinal = CalcularNotaFinal();
            if (NotaFinal >= 60.0) {
                return "APROVADO";
            } else {
                double NotaFaltante = 60 - NotaFinal; 

                return (
                    $"REPROVADO \n" +
                    "Faltaram " + NotaFaltante.ToString("F2", CultureInfo.InvariantCulture ) + " pontos"
                );
            

            }
        }
    }
}