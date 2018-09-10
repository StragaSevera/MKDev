using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Calculus
{
    class Program
    {
        static void Main(string[] args)
        {
            double f(double x) => x * x;

            var integrator = new Integrator(f);
            Console.WriteLine($"Integrating x^2 from 0 to 3 with 100 steps:");
            Console.WriteLine($"Analytical: 9");
            Console.WriteLine($"Using rectangles: {integrator.IntegrateByRectangles(0, 3)}");
            Console.ReadLine();
        }
    }
}
