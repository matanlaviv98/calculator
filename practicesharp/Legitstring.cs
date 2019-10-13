using System;
using System.Collections.Generic;
using System.Text;

namespace practicesharp
{
    class Legitstring
    {
        public string equation_s { get; private set; }

        public Legitstring(string userinput)
        {
            try
            {
                const string allowed_letters = "1234567890+-*/";
                foreach (char letter in userinput)
                {
                    if (allowed_letters.Contains(letter))
                        continue;
                    throw new System.IO.IOException();          //if letter is not allwoed then there's an input error.
                }
                equation_s = userinput;
            }
            catch
            {
                Console.WriteLine("input is wrong.\n" +
                    "must only use : numbers(1-9), operators(+ - / *)");
                equation_s = "";
            }
        }
        public bool IsEmpty()
        {
            return (equation_s == "");
        }
    }
}
