using System;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing.WPF
{
    public class WpfRectangleDrawingStrategy : AbstractDrawingStrategy
    {
        public override void Draw(Shape shape)
        {
            // Уродливое приведение к типу, но как лучше, не знаю
            var rect = (Rectangle)shape;
            Console.WriteLine($"WPF rectangle: {rect.Point1}, {rect.Point2}");
        }
    }
}