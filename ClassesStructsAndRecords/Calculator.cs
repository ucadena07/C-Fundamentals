﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
{
    internal class Calculator
    {
        internal ResultDT ComputeDoubleAndTriple(int value)
        {
            var result = new ResultDT();    

            result.Value = value;
            result.Doubled = value * 2;
            result.Tripled = value * 3;

            return result;
        }
    }
}
