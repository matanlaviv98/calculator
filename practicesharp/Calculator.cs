using System;
using System.Collections.Generic;
using System.Text;

namespace practicesharp
{

    


    class Calculator
    {

        public double Calculate(Legitstring Legit_equation)
        {
            return Calculate(Legit_equation.equation_s);
        }
        private double Calculate(string equation)
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