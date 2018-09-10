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
        private readonly Func<double, double> f;
        private readonly IntegrationStrategy strategy;

        public Integrator(Func<double, double> f, IntegrationStrategy strategy)
        {
            this.f = f;
            this.strategy = strategy;
        }
        
        public double Integrate(double a, double b, int segments = 100)
        {
            return strategy.Integrate(f, a, b, segments);
        }
    }
}
