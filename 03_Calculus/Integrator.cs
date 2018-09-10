using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Calculus.Strategies;

namespace _03_Calculus
{
    class Integrator
    {
        private readonly Func<double, double> _f;
        private readonly IntegrationStrategy _strategy;

        public Integrator(Func<double, double> f, IntegrationStrategy strategy)
        {
            _f = f;
            _strategy = strategy;
        }
        
        public double Integrate(double a, double b, int segments = 100)
        {
            return _strategy.Integrate(_f, a, b, segments);
        }

        public override string ToString()
        {
            return _strategy.ToString();
        }
    }
}
