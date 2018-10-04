using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08_PendulumEngine
{
    public class Spiral
    {
        public int Length { get; }
        public double StartingAngle { get; }
        public Vector2 Pivot { get; }

        public double Angle { get; private set; }
        public List<Vector2> Points { get; private set; }
        private readonly List<Vector2> _newPoints;

        public Spiral(int length, double startingAngle, Vector2 pivot)
        {
            Length = length;
            Angle = StartingAngle = startingAngle;
            Pivot = pivot;
            Points = new List<Vector2>();
            _newPoints = new List<Vector2>();
            ComputePoints();
        }

        public void Tick(int timeElapsed)
        {
            double timeCoefficient = 1000d / timeElapsed;
            Angle += timeCoefficient * Math.PI / (180 * 4);
            ComputePoints();
            Points = _newPoints.ToList();
        }

        private void ComputePoints()
        {
            _newPoints.Clear();
            for (double phi = 0; phi <= 32 * Math.PI + 0; phi += Math.PI / 180)
            {
                double r = PhiCoefficient() * phi;
                Vector2 point = new Vector2(
                    (float) (r * Math.Sin(phi + Angle)),
                    (float) (r * Math.Cos(phi + Angle))
                ) + Pivot;
                _newPoints.Add(point);
            }
        }

        private double PhiCoefficient()
        {
            return Length / (2d * Math.PI);
        }
    }
}
