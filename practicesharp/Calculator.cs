using System;
using System.Collections.Generic;
using System.Text;

namespace basic_calculator
{

    


    class Calculator
    {
        public double Calculate(string equation)
        {
            Number number= new Number(ref equation);
            if (equation == "")
                return number.decimal_value;
            char op = equation[0];
            equation=equation.Remove(0,1);
            return Operator_Decoder.Decode(op).Activate(number.decimal_value, Calculate(equation));
        }
    }
}