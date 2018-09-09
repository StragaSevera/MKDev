using System.Numerics;
using _01_VectorEditor.Drawing;
using _01_VectorEditor.Utils;

namespace _01_VectorEditor.Primitives
{
    public class LineSegment : Shape
    {
        public Vector2 Point1 { get; }
        public Vector2 Point2 { get; }

        public LineSegment(Vector2 point1, Vector2 point2,
            AbstractDrawingStrategy drawingStrategy) : base(drawingStrategy)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public override float GetDistanceFrom(Vector2 point)
        {
            return GeometricUtils.DistanceFromLineSegment(point, Point1, Point2);
        }
    }
}
