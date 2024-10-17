using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class PlusOperator : Operator
    {
        public override double DoOperation(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }

        public override string ToString()
        {
            return "+";
        }
    }
}
