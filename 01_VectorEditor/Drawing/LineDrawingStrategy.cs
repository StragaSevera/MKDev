using System;
using System.Numerics;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing
{
    public class LineDrawingStrategy : AbstractDrawingStrategy
    {
        public override void Draw(Shape shape)
        {
            // Уродливое приведение к типу, но как лучше, не знаю
            var lineSegment = (LineSegment)shape;
            Console.WriteLine($"LineSegment: {lineSegment.Point1}, {lineSegment.Point2}");
        }
    }
}