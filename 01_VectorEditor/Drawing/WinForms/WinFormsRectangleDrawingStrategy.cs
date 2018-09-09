using System;
using _01_VectorEditor.Primitives;

namespace _01_VectorEditor.Drawing.WinForms
{
    public class WinFormsRectangleDrawingStrategy : AbstractDrawingStrategy
    {
        public override void Draw(Shape shape)
        {
            // Уродливое приведение к типу, но как лучше, не знаю
            var rect = (Rectangle)shape;
            Console.WriteLine($"WinForms rectangle: {rect.Point1}, {rect.Point2}");
        }
    }
}