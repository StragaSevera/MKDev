using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus
{
    class Integrator
    {
        public delegate double IntegrationFunction(Func<double, double> f,
            double a, double step, double i, double segments);

        private Func<double, double> f;

        public Integrator(Func<double, double> f)
        {
            this.f = f;
        }

        public double IntegrateBy(double a, double b, IntegrationFunction integrationFunction,
            int segments = 100)
        {
            double step = (b - a) / segments;
            double sum = 0;

            for (int i = 0; i <= segments - 1; i++)
            {
                sum += integrationFunction(f, a, step, i, segments);
            }

            return sum * step;
        }


        public double IntegrateByRectangles(double a, double b, int segments = 100)
        {
            // Уродливый делегат, требует гораздо параметров, чем нужно ему, ибо другим стратегиям
            // нужно будет количество сегментов или обе координаты отрезка
            double Integration(Func<double, double> f,
                double _a, double step, double i, double _segments)
            {
                return f(_a + step * (i + 0.5));
            }

            return IntegrateBy(a, b, Integration, segments);
        }

        public double IntegrateByTrapezoid(double a, double b, int segments = 100)
        {
            double step = (b - a) / segments;
            double sum = (f(a) + f(b)) / 2;

            for (int i = 1; i <= segments - 2; i++)
            {
                sum += f(a + step * i);
            }

            return sum * step;
        }

        public double IntegrateBySimpson(double a, double b, int segments = 100)
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
    }
}
