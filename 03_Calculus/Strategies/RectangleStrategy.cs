﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus.Strategies
{
    class RectangleStrategy : IntegrationStrategy
    {
        public RectangleStrategy(int segments) : base(segments)
        {
        }

        public RectangleStrategy(double step) : base(step)
        {
        }

        protected override double ExecuteAlgorythm(Func<double, double> f, double a, double b,
            int segments, double step)
        {
            double sum = 0;

            for (int i = 0; i <= segments - 1; i++)
            {
                double x = a + step * (i + 0.5);
                Debug.Assert(x <= b);
                sum += f(x);
            }

            return sum * step;
        }

        public override string ToString()
        {
            return "Rectangle strategy";
        }
    }
}
