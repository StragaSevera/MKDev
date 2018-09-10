using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Example.Infrastructure.Abstract;

namespace _02_Example.Infrastructure.Shapes
{
    public class Rectangle : Shape
    {

        private double _a;
        private double _b;

        public double A
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Длина стороны не может быть отрицательной.");
                }

                _a = value;
            }

            get => _a;
        }

        public double B
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Длина стороны не может быть отрицательной.");
                }

                _b = value;
            }

            get => _b;
        }

        public Rectangle()
        {

        }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override void Render(AbstractRenderer renderer)
        {
            renderer.Render(this);
        }
    }
}
