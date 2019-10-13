using System;
using System.Collections.Generic;
using System.Text;

namespace practicesharp
{
    class Equation_Validator
    {
        public string equation_s { get; private set; }

        public Equation_Validator(string userinput)
        {
            equation_s = "";
            if (Validate(userinput)) equation_s= userinput;
        }
        public bool Validate(string word)
        {
            try
            {
                const string allowed_letters = "1234567890+-*/";
                foreach (char letter in word)
                {
                    if (allowed_letters.Contains(letter))
                        continue;
                    throw new System.IO.IOException();          //if letter is not allwoed then there's an input error.
                }
                return true ;
            }
            catch
            {
                Console.WriteLine("input is wrong.\n" +
                    "must only use : numbers(1-9), operators(+ - / *)");
                return false;
            }
        }
        public bool IsEmpty()
        {
            return (equation_s == "");
        }
    }
}
