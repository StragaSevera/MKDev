using System.Reflection.Emit;

namespace _04_Calculator.Commands
{
    internal class SubtractCommand : CalculatorCommand
    {
        public SubtractCommand(double operand) : base(operand)
        {
        }

        public override double Apply(double value)
        {
            return value - _operand;
        }

        public override double Unapply(double value)
        {
            return value + _operand;
        }
    }
}
