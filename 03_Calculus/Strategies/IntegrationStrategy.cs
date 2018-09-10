using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus.Strategies
{
    abstract class IntegrationStrategy
    {
        private readonly int? _segments;
        private readonly double? _step;

        protected IntegrationStrategy(int segments)
        {
            _segments = segments;
        }

        protected IntegrationStrategy(double step)
        {
            _step = step;
        }

        public double Integrate(Func<double, double> f, double a, double b)
        {
            int segments;
            if(_segments.HasValue)
            {
                segments = _segments.Value;
            }
            else if (_step.HasValue)
            {
                segments = (int) Math.Round((b - a) / _step.Value);
            }
            else
            {
                // Без этой ветви решарпер ругается
                throw new Exception("Integration strategy has no segments and no step!");
            }
            double step = (b - a) / segments;
            
            return ExecuteAlgorythm(f, a, b, segments, step);
        }

        protected abstract double ExecuteAlgorythm(Func<double, double> f, double a, double b, 
            int segments, double step);
    }
}
