using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Calculus.Strategies;

namespace _03_Calculus
{
    class Program
    {
        private static void Main(string[] args)
        {
            double F(double x) => x * x;

            // Не очень красиво кортежами, но два параллельных массива еще менее красиво
            var integrators = new List<(Integrator, string)>
            {
                (new Integrator(F, new RectangleStrategy()), "Rectangle strategy"),
                (new Integrator(F, new TrapezoidStrategy()), "Trapezoid strategy"),
                (new Integrator(F, new SimpsonStragegy()), "Simpson strategy")
            };

            Console.WriteLine($"Integrating x^2 from 0 to 3 with 100 steps:");
            Console.WriteLine($"Analytical: 9");
            foreach (var tuple in integrators)
            {
                Console.WriteLine($"{tuple.Item2}: {tuple.Item1.Integrate(0, 3)}");
            }
            Console.ReadLine();
        }
    }
}
