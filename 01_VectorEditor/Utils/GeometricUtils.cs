using System;
using System.Numerics;

namespace _01_VectorEditor.Utils
{
    public static class GeometricUtils
    {
        public static float DistanceFromLineSegment(Vector2 targetPoint, Vector2 point1,
            Vector2 point2)
        {
            Vector2 lineVector = point2 - point1;
            Vector2 angleVector1 = point1 - targetPoint;
            Vector2 angleVector2 = point2 - targetPoint;

            float distance;

            if (Vector2.Dot(angleVector1, lineVector) <= 0)
            {
                // Проекция точки не попадает на отрезок и находится ближе к первой точке
                distance = Vector2.Distance(targetPoint, point1);
            }
            else if (Vector2.Dot(angleVector2, lineVector) >= 0)
            {
                // Проекция точки не попадает на отрезок и находится ближе ко второй точке
                distance = Vector2.Distance(targetPoint, point2);
            }
            else
            {
                distance = DistanceFromLine(targetPoint, point1, point2);
            }

            return distance;
        }

        public static float DistanceFromLine(Vector2 targetPoint, Vector2 point1,
            Vector2 point2)
        {
            float lineLength = Vector2.Distance(point1, point2);
            return Math.Abs((point2.Y - point1.Y) * targetPoint.X - (point2.X - point1.X) *
                            targetPoint.Y + point2.X * point1.Y - point2.Y * point1.X)
                   / lineLength;
        }
    }
}
