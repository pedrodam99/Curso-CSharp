namespace Exercicio_01 {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double CalcArea(){
            return Altura * Largura;
        }

        public double CalcPerimetro(){
            return 2 * (Altura + Largura);
        }

        public double CalcDiagonal(){
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}