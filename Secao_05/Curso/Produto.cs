using System.Globalization;

namespace Secao_05
{
    class Produto
    {
        private string _nome;
        public double Preco {get ; private set;}
        public int Quantidade {get; private set;}

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome;}
            set {
             if (value.Length > 1 && value != null){
            _nome = value;
            }
            }
        } 

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }
        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return $"{_nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}" +
            $" {Quantidade} unidades. Total: ${ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}