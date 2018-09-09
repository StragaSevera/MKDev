using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01_VectorEditor
{
    public class RectangleDrawingStrategy
    {
        public void Draw(Vector2 point1, Vector2 point2)
        {
            Console.WriteLine($"Rectangle: {point1}, {point2}");
        }
    }
}