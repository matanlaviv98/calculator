using System;
using System.Collections.Generic;
using System.Text;

namespace practicesharp
{

    


    class Calculator
    {
        public double Calculate(string equation)
        {
            Number number= new Number(ref equation);
            if (equation == "")
                return number.value;
            char op = equation[0];
            equation=equation.Remove(0,1);
            return Operator_Decoder.Decode(op).Activate(number.value, Calculate(equation));
        }
    }
}