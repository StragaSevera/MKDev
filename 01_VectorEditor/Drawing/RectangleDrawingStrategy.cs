using System;
using System.Numerics;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing
{
    public class RectangleDrawingStrategy : AbstractDrawingStrategy
    {
        public override void Draw(Shape shape)
        {
            // Уродливое приведение к типу, но как лучше, не знаю
            var rect = (Rectangle)shape;
            Console.WriteLine($"Rectangle: {rect.Point1}, {rect.Point2}");
        }
    }
}