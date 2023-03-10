using System.Globalization;

namespace Curso.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }

        public override string ToString()
        {
            return $"Circle area: {Area().ToString("F2", CultureInfo.InvariantCulture)}, Color: {Color}";
        }
    }
}