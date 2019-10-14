using System;
using System.Collections.Generic;
using System.Text;

namespace basic_calculator
{

    


    class Calculator
    {
        Numeric_Base numeric_Base;
        public Calculator(ref Numeric_Base numeric1)
        {
            numeric_Base = numeric1;
        }
        public double Calculate(string equation)
        {
            
            Number number= new Number(ref equation);
            number.deciaml_value = numeric_Base.To_Decimal(number.number);
            if (equation == "")
                return number.deciaml_value;
            char op = equation[0];
            equation=equation.Remove(0,1);
            return Operator_Decoder.Decode(op).Activate(number.deciaml_value, Calculate(equation));
        }
    }
}