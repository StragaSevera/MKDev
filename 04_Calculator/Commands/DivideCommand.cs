using System;
using System.Reflection.Emit;

namespace _04_Calculator.Commands
{
    internal class DivideCommand : CalculatorCommand
    {
        public DivideCommand(double operand) : base(operand)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (operand == 0d)
            {
                throw new ArgumentException("Calculator cannot divide by 0!");
            }
        }

        public override double Apply(double value)
        {
            return value / _operand;
        }

        public override double Unapply(double value)
        {
            return value * _operand;
        }
    }
}
