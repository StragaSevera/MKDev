using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus.Strategies
{
    class RectangleStrategy : IntegrationStrategy
    {
        public override double Integrate(Func<double, double> f, double a, double b, int segments)
        {
            double step = (b - a) / segments;
            double sum = 0;

            for (int i = 0; i <= segments - 1; i++)
            {
                sum += f(a + step * (i + 0.5));
            }

            return sum * step;
        }
    }
}
