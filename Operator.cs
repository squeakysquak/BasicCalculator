using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal abstract class Operator
    {
        public bool m_SingleOperand = false;
        public static Operator CreateOperatorFromString(string input)
        {
            if (input == "+")
            {
                return new PlusOperator();
            } 
            else if (input == "-")
            {
                return new MinusOperator();
            }
            else if (input == "/")
            {
                return new DivideOperator();
            }
            else if (input == "*")
            {
                return new MultiplyOperator();
            }
            else if (input == "^")
            {
                return new ExponentOperator();
            }
            else if (input == "sqrt")
            {
                return new SqrtOperator();
            }
            else
            {
                throw new ArgumentException("Error: Invalid operator");
            }
        }

        public abstract double DoOperation(double firstOperand, double secondOperand);
    }
}
