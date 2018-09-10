using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calc = new Calculator(5d);
            Console.WriteLine($"Initial value: {calc.Value}");
            calc.Add(5d);
            Console.WriteLine($"Value + 5: {calc.Value}");
            calc.Subtract(3d);
            Console.WriteLine($"Value - 3: {calc.Value}");
            calc.Multiply(6d);
            Console.WriteLine($"Value * 6: {calc.Value}");
            calc.Divide(4d);
            Console.WriteLine($"Value / 4: {calc.Value}");
            Console.ReadLine();
        }
    }
}
