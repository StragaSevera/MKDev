using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01_VectorEditor
{
    public class Rectangle : Shape
    {
        public Vector2 Point1 { get; }
        public Vector2 Point2 { get; }

        private readonly List<Shape> lines;

        public Rectangle(Vector2 point1, Vector2 point2)
        {
            Point1 = point1;
            Point2 = point2;

            lines = GetLines();
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle: {Point1}, {Point2}. Contains lines:");
            lines.ForEach(line => line.Draw());
        }

        public override float GetDistanceFrom(Vector2 point)
        {
            return lines.Min(line => line.GetDistanceFrom(point));
        }

        private List<Shape> GetLines()
        {
            return new List<Shape> 
            {
                new Line(Point1, new Vector2(Point1.X, Point2.Y)),
                new Line(Point1, new Vector2(Point2.X, Point1.Y)),
                new Line(new Vector2(Point1.X, Point2.Y), Point2),
                new Line(new Vector2(Point2.X, Point1.Y), Point2)
            };
        }
    }
}
