using System;
using System.Numerics;

namespace _08_PendulumEngine
{
    public class Pendulum
    {
        public int Length { get; }
        public double StartingAngle { get; }
        public Vector2 Pivot { get; }
        public double Angle { get; private set; }

        public Vector2 Point => Pivot + new Vector2(
                                    (float) (Length * Math.Sin(Angle)),
                                    (float) (Length * Math.Cos(Angle))
                                );

        private int _timeFromStart = 0;
        private readonly float _dpi;
        
        public Pendulum(int length, double startingAngle, Vector2 pivot, float dpi)
        {
            Length = length;
            Angle = StartingAngle = startingAngle;
            Pivot = pivot;
            _dpi = dpi;
        }


        public void Tick(int timeElapsed)
        {
            _timeFromStart += timeElapsed;
            Angle = StartingAngle * Math.Cos(Omega() * _timeFromStart / 1000);
        }

        private double Omega()
        {
            return Math.Sqrt(9.8 / LengthMetric());
        }

        private double LengthMetric()
        {
            return Length / (_dpi * 2.54);
        }
    }
}
