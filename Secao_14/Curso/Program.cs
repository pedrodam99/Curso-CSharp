using System.Globalization;
using Curso.Model.Entities;
using Curso.Model.Entities.Enums;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IShape s1 = new Retangle(){Width = 10.0, Height = 3.0, Color = Color.Black};
            IShape s2 = new Circle(){Radius = 4.0, Color = Color.Black};
            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
        }
    }
}