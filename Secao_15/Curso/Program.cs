using Curso.Services;
using Curso.Entities;

using System.Globalization;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "9971233344";
            cookies["phone"] = "9342343223";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);
         
            cookies.Remove("email");
            Console.WriteLine(cookies["email"]);
        }
    }
}