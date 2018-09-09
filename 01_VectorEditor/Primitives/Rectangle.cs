using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using _01_VectorEditor.Drawing;
using _01_VectorEditor.Utils;

namespace _01_VectorEditor.Primitives
{
    public class Rectangle : Shape
    {
        public Vector2 Point1 { get; }
        public Vector2 Point2 { get; }
        private readonly RectangleDrawingStrategy drawingStrategy;

        public Rectangle(Vector2 point1, Vector2 point2)
        {
            Point1 = point1;
            Point2 = point2;

            drawingStrategy = new RectangleDrawingStrategy();
        }

        public override void Draw()
        {
            drawingStrategy.Draw(Point1, Point2);
        }

        public override float GetDistanceFrom(Vector2 point)
        {
            var lineSegments = new List<ValueTuple<Vector2, Vector2>>
            {
                (Point1, new Vector2(Point1.X, Point2.Y)),
                (Point1, new Vector2(Point2.X, Point1.Y)),
                (new Vector2(Point1.X, Point2.Y), Point2),
                (new Vector2(Point2.X, Point1.Y), Point2)
            };

            return lineSegments.Select(
                l => GeometricUtils.DistanceFromLineSegment(point, l.Item1, l.Item2)
            ).Min();
        }
    }
}
