using System;

namespace BridgeLabzApp.Calculators
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public int Calculate(int a, char ch, int b)
        {
            switch (ch)
            {
                case '+':
                    return a + b;

                case '-':
                    return a - b;

                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return a / b;

                case '*':
                    return a * b;

                default:
                    throw new ArgumentException($"Invalid operator: {ch}");
            }
        }
    }
}