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

            Console.WriteLine($"Integrating x^2 from 0 to 3 with 100 segments:");
            Console.WriteLine($"Analytical: 9");
            var integrators = new List<Integrator>
            {
                new Integrator(F, new RectangleStrategy(100)),
                new Integrator(F, new TrapezoidStrategy(100)),
                new Integrator(F, new SimpsonStragegy(100))
            };
            foreach (Integrator integrator in integrators)
            {
                Console.WriteLine($"{integrator}: {integrator.Integrate(0, 3)}");
            }

            Console.WriteLine();
            Console.WriteLine($"Integrating x^2 from 0 to 3 with step = 0.003:");
            Console.WriteLine($"Analytical: 9");
            integrators = new List<Integrator>
            {
                new Integrator(F, new RectangleStrategy(0.003)),
                new Integrator(F, new TrapezoidStrategy(0.003)),
                new Integrator(F, new SimpsonStragegy(0.003))
            };
            foreach (Integrator integrator in integrators)
            {
                Console.WriteLine($"{integrator}: {integrator.Integrate(0, 3)}");
            }

            var a = 1d;
            while (a > 0d) a -= 0.1d;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
