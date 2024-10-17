using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class ExponentOperator : Operator
    {
        public override double DoOperation(double firstOperand, double secondOperand)
        {
            return Math.Pow(firstOperand, secondOperand);
        }

        public override string ToString()
        {
            return "^";
        }
    }
}
