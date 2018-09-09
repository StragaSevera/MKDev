using System;
using System.Numerics;

namespace _01_VectorEditor.Drawing
{
    public class RectangleDrawingStrategy
    {
        public void Draw(Vector2 point1, Vector2 point2)
        {
            Console.WriteLine($"Rectangle: {point1}, {point2}");
        }
    }
}