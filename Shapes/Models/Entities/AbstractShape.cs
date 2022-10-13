using Shapes.Models.Enums;

namespace Shapes.Models.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
