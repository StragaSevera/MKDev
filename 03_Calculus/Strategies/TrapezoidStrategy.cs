using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus.Strategies
{
    class TrapezoidStrategy : IntegrationStrategy
    {
        public override double Integrate(Func<double, double> f, double a, double b, int segments)
        {
            double step = (b - a) / segments;
            double sum = (f(a) + f(b)) / 2;

            for (int i = 1; i <= segments - 2; i++)
            {
                sum += f(a + step * i);
            }

            return sum * step;
        }

        public override string ToString()
        {
            return "Trapezoid strategy";
        }
    }
}
