using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class SqrtOperator : Operator
    {
        public SqrtOperator()
        {
            m_SingleOperand = true;
        }

        public override double DoOperation(double firstOperand, double secondOperand)
        {
            return Math.Sqrt(firstOperand);
        }

        public override string ToString()
        {
            return "sqrt";
        }
    }
}
