using System;
using System.Collections.Generic;
using _04_Calculator.Commands;

namespace _04_Calculator
{
    internal class Calculator
    {
        public double Value { get; private set; }
        private readonly Stack<CalculatorCommand> _commands;

        public Calculator(double value = 0d)
        {
            Value = value;
            _commands = new Stack<CalculatorCommand>();
        }

        public double ApplyCommand(CalculatorCommand command)
        {
            _commands.Push(command);
            return Value = command.Apply(Value);
        }

        public double Undo()
        {
            CalculatorCommand command = _commands.Pop();
            return Value = command.Unapply(Value);
        }

        public double Add(double operand)
        {
            return ApplyCommand(new AddCommand(operand));
        }

        public double Subtract(double operand)
        {
            return ApplyCommand(new SubtractCommand(operand));
        }

        public double Multiply(double operand)
        {
            return ApplyCommand(new MultiplyCommand(operand));
        }
        public double Divide(double operand)
        {

            return ApplyCommand(new DivideCommand(operand));
        }
    }
}
