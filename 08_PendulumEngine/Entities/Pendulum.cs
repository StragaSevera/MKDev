using System;
using System.Numerics;
using _08_PendulumEngine.Events;

namespace _08_PendulumEngine.Entities
{
    public class Pendulum : IEntity
    {
        public int Length { get; private set; }
        public double StartingAngle { get; private set; }
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

        public void HandleInputEvent(InputEvent inputEvent)
        {
            inputEvent.VisitEntity(this);
        }

        public void HandleInputEvent(MoveInputEvent inputEvent)
        {
            InitFromPoint(inputEvent.Position);
        }

        private double Omega()
        {
            return Math.Sqrt(9.8 / LengthMetric());
        }

        private double LengthMetric()
        {
            return Length / (_dpi * 2.54);
        }

        private void InitFromPoint(Vector2 point)
        {
            Length = (int) Math.Round(Vector2.Distance(point, Pivot));
            Angle = StartingAngle = Math.Atan2(point.X - Pivot.X, point.Y - Pivot.Y);
            _timeFromStart = 0;
        }
    }
}
