using System;
using System.Numerics;

namespace _01_VectorEditor
{
    public class Line : Shape
    {
        public Vector2 Point1 { get; }
        public Vector2 Point2 { get; }

        public Line(Vector2 point1, Vector2 point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Line: {Point1}, {Point2}");
        }

        public override float GetDistanceFrom(Vector2 point)
        {
            // Не помню, как это делать по-векторному
            float lineLength = Vector2.Distance(Point1, Point2);
            return Math.Abs((Point2.Y - Point1.Y) * point.X - (Point2.X - Point1.X) * 
                            point.Y + Point2.X * Point1.Y - Point2.Y * Point1.X) 
                   / lineLength;
        }
    }
}
