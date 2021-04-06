using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class Calculator
    {
        private Func<double, double, double> func = Add;
        public enum Type : byte { Plus, Minus, Mnozenna, Dilenna };
        public static double Add(double first, double second) { return first + second; }
        public static double Subtraction(double first, double second) { return first - second; }
        public static double Multiplication(double first, double second) { return first * second; }
        public static double Division(double first, double second)
        {
            if (first != 0)
            {
                return first / second;
            }
            else
            {
                throw new ArgumentException("Invalid value of variable.");
            }
        }
        public void SetOperation(Type operation)
        {
            if (Type.Plus == operation)
            {
                func = Add;
            }
            else if (Type.Minus == operation)
            {
                func = Subtraction;
            }
            else if (Type.Mnozenna == operation)
            {
                func = Multiplication;
            }
            else if (Type.Dilenna == operation)
            {
                func = Division;
            }
        }
        public double Calculate(double first, double second)
        {
            return func.Invoke(first, second);
        }
    }
}
