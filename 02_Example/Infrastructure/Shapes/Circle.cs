using System;
using _02_Example.Infrastructure.Abstract;

namespace _02_Example.Infrastructure.Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Радиус не может быть отрицательным.");
                }

                _radius = value;
            }

            get => _radius;
        }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void Render(AbstractRenderer renderer)
        {
            renderer.Render(this);
        }
    }
}
