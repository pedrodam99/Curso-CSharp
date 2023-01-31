using Curso.Services;
using Curso.Entities;

using System.Globalization;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Tv");
            set.Add("Iphone X");
            set.Add("PS5");

            Console.WriteLine(set.Contains("Tv"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}