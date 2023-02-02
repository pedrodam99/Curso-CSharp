using Curso.Entities;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Notebook", 1200.0));
            list.Add(new Product("Tablet", 450.0));

            // passando o metodo como parametro
            list.Sort(CompareProduct);

            // colocando o metodo dentro de uma variável
            Comparison<Product> comp = CompareProduct;
            list.Sort(comp);

            // expressao lambda dentro de uma variavel
            Comparison<Product> compLambda = (p1, p2) => p1.Price.CompareTo(p2.Price);
            list.Sort(compLambda);
            
            //passando expressao lambda inline
            list.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));


            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // metodo que vai ser referenciado 
        static int CompareProduct(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}