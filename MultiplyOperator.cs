﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class MultiplyOperator : Operator
    {
        public override int DoOperation(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }

        public override string ToString()
        {
            return "*";
        }
    }
}