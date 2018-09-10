using System;
using System.Collections.Generic;
using _04_Calculator.Commands;

namespace _04_Calculator
{
    internal class Calculator
    {
        public double Value { get; private set; }
        private readonly Stack<CalculatorCommand> _commands;
        private readonly Stack<CalculatorCommand> _undoneCommands;


        public Calculator(double value = 0d)
        {
            Value = value;
            _commands = new Stack<CalculatorCommand>();
            _undoneCommands = new Stack<CalculatorCommand>();
        }

        public double ApplyCommand(CalculatorCommand command)
        {
            _undoneCommands.Clear();
            _commands.Push(command);
            return Value = command.Apply(Value);
        }

        public double Undo()
        {
            CalculatorCommand command = _commands.Pop();
            _undoneCommands.Push(command);
            return Value = command.Unapply(Value);
        }

        public double Redo()
        {
            if (_undoneCommands.Count == 0)
            {
                throw new InvalidOperationException("You cannot redo when you have no undid commands!");
            }
            CalculatorCommand command = _undoneCommands.Pop();
            
            // Можно вырефакторить в отдельный метод:
            _commands.Push(command);
            return Value = command.Apply(Value);
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
