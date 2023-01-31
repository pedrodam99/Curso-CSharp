using Curso.Services;
using Curso.Entities;

using System.Globalization;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Client c1 = new Client(){Name = "Maria", Email = "maria@gmail.com"};
            Client c2 = new Client(){Name = "Alex", Email = "alex@gmail.com"};

            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
        }
    }
}