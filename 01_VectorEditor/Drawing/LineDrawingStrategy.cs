using System;
using System.Numerics;

namespace _01_VectorEditor
{
    public class LineDrawingStrategy : AbstractDrawingStrategy
    {
        public override void Draw(Vector2 point1, Vector2 point2)
        {
            Console.WriteLine($"LineSegment: {point1}, {point2}");
        }
    }
}