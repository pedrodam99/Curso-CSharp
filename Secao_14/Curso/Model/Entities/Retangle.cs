using System.Globalization;

namespace Curso.Model.Entities
{
    class Retangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Retangle area: {Area().ToString("F2", CultureInfo.InvariantCulture)}, Color: {Color}";
        }
    }
}