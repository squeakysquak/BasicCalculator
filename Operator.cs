using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal abstract class Operator
    {
        public static Operator CreateOperatorFromString(string input)
        {
            if (input == "+")
            {
                return new PlusOperator();
            }
            else
            {
                throw new ArgumentException("Error: Invalid operator");
            }
        }

        public abstract int DoOperation(int firstOperand, int secondOperand);
    }
}
