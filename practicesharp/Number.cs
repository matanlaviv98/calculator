using System;
using System.Collections.Generic;
using System.Text;

namespace practicesharp
{
    class Number
    {
        public int value { get; private set; }
        public Number(ref string s)
        {
            value = 0;
            string field = "1234567890";
            foreach (char letter in s)
            {
                if (!field.Contains(letter))
                    break;
                value *= 10;
                value += letter - '0';
                s=s.Remove(0,1);
            }
        }
    }
}
