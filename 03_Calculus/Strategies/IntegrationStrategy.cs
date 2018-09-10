using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus.Strategies
{
    abstract class IntegrationStrategy
    {
        public abstract double Integrate(Func<double, double> f, double a, double b, int segments);
    }
}
