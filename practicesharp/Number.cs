using System;
using System.Collections.Generic;
using System.Text;

namespace basic_calculator
{
    class Number
    {
        
        public string number { get; private set; }
        public Number(ref string s)
        {
            number = "";
            string operators_field = "+-*/";
            foreach (char letter in s)
            {
                if (operators_field.Contains(letter))
                    break;
                number += letter;
                s=s.Remove(0,1);
            }
        }
    }
}
