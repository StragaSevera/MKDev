using System;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing.WPF
{
    class WpfRenderer : AbstractRenderer
    {
        public override void Render(Shape shape)
        {
            Console.WriteLine($"Cannot render {shape.GetType()} from WPF!");
        }

        public override void Render(LineSegment segment)
        {
            Console.WriteLine($"WPF lineSegment: {segment.Point1}, {segment.Point2}");
        }

        public override void Render(Rectangle rectangle)
        {
            Console.WriteLine($"WPF rectangle: {rectangle.Point1}, {rectangle.Point2}");
        }
    }
}
