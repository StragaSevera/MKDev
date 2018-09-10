using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus
{
    class Integrator
    {
        private Func<double, double> f;

        public Integrator(Func<double, double> f)
        {
            this.f = f;
        }

        public double IntegrateByRectangles(double a, double b, int segments = 100)
        {
            double step = (b - a) / segments;
            double sum = 0;

            for (int i = 0; i < segments; i++)
            {
                sum += f(a + step * (i + 0.5));
            }

            return sum * step;
        }
    }
}
