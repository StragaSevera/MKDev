using System.Reflection.Emit;

namespace _04_Calculator.Commands
{
    internal class MultiplyCommand : CalculatorCommand
    {
        private double _previousValue; // Для предотвращения деления на ноль при отмене

        public MultiplyCommand(double operand) : base(operand)
        {
        }

        public override double Apply(double value)
        {
            _previousValue = value;
            return value * _operand;
        }

        public override double Unapply(double value)
        {
            return _previousValue;
        }
    }
}
