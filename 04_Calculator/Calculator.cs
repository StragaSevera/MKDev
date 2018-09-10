using System;

namespace _04_Calculator
{
    internal class Calculator
    {
        public double Value { get; private set; }

        public Calculator(double value = 0d)
        {
            Value = value;
        }

        public double Add(double operand)
        {
            return Value += operand;
        }

        public double Subtract(double operand)
        {
            return Value -= operand;
        }

        public double Multiply(double operand)
        {
            return Value *= operand;
        }
        public double Divide(double operand)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (operand == 0d)
            {
                throw new ArgumentException("Calculator cannot divide by 0!");
            }
            return Value /= operand;
        }
    }
}
