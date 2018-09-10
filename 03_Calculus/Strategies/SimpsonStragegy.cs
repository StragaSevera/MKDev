using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus.Strategies
{
    class SimpsonStragegy : IntegrationStrategy
    {
        public override double Integrate(Func<double, double> f, double a, double b, int segments)
        {
            if (segments % 2 == 1)
            {
                throw new ArgumentException("The segments count must be even!");
            }

            double step = (b - a) / segments;
            double sum = f(a) + f(b);

            for (int i = 2; i <= segments - 2; i += 2)
            {
                sum += f(a + step * i) * 2;
            }

            for (int i = 1; i <= segments - 1; i += 2)
            {
                sum += f(a + step * i) * 4;
            }

            return sum * step / 3;
        }

        public override string ToString()
        {
            return "Simpson strategy";
        }
    }
}
