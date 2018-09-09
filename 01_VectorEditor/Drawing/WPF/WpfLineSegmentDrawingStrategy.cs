using System;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing.WPF
{
    public class WpfLineSegmentDrawingStrategy : AbstractDrawingStrategy
    {
        public override void Draw(Shape shape)
        {
            // Уродливое приведение к типу, но как лучше, не знаю
            var lineSegment = (LineSegment)shape;
            Console.WriteLine($"WPF lineSegment: {lineSegment.Point1}, {lineSegment.Point2}");
        }
    }
}