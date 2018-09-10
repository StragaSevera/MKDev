using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Calculator.Commands
{
    internal abstract class CalculatorCommand
    {
        protected double _operand;

        protected CalculatorCommand(double operand)
        {
            _operand = operand;
        }

        public abstract double Apply(double value);
        public abstract double Unapply(double value);
    }
}
