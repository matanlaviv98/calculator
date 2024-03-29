﻿using System;
using System.Collections.Generic;
using System.Text;

namespace basic_calculator
{
    public interface Numeric_Base
    {
        public static string field { get; private set; }
        public static short weight { get; private set; }
        public bool Validate(string number);
        public double To_Decimal(string number);
        public void print(double number);
    }


    class Binary : Numeric_Base
    {
        public static string field { get; private set; } = "01";
        public static short weight { get; private set; } = 2;
        public bool Validate(string number)
        {
            foreach (char letter in number)
                if (!field.Contains(letter)) return false;
            return true;
        }
        public double To_Decimal(string number)
        {
            double value = 0;
            foreach (char letter in number)
            {
                value *= weight;
                value += (letter - '0');
            }
            return value;
        }
        public void print(double number)
        {
            Console.Write(number.ToString("B") + "  (in binary)");
        }

    }
    class Octal : Numeric_Base
    {
        public static string field { get; private set; } = "01234567";
        public static short weight { get; private set; } = 8;
        public bool Validate(string number)
        {
            foreach (char letter in number)
                if (!field.Contains(letter)) return false;
            return true;
        }
        public double To_Decimal(string number)
        {
            double value = 0;
            foreach (char letter in number)
            {
                value *= weight;
                value += (letter - '0');
            }
            return value;
        }
        public void print(double number)
        {
            Console.Write(number.ToString("O") + "  (in ocatl)");
        }
    }
    class Decimal: Numeric_Base
    {
        public static string field { get; private set; } = "0123456789";
        public static short weight { get; private set; } = 10;
        public bool Validate(string number)
        {
            foreach (char letter in number)
                if (!field.Contains(letter)) return false;
            return true;
        }
        public double To_Decimal(string number)
        {
            double value = 0;
            foreach (char letter in number)
            {
                value *= weight;
                value += (letter - '0');
            }
            return value;
        }
        public void print(double number)
        {
            Console.Write(number + "  (in decimal)");
        }
    }
    class Hexadecimal : Numeric_Base
    {
        public static string field { get; private set; } = "0123456789ABCDEF";
        public static short weight { get; private set; } = 16;
        public bool Validate(string number)
        {
            foreach (char letter in number)
                if (!field.Contains(letter)) return false;
            return true;
        }
        public double To_Decimal(string number)
        {
            double value = 0;
            foreach (char letter in number)
            {
                value *= weight;
                if (letter<'A')value += (letter - '0');
                else value += (letter + 10 - 'A');
            }
            return value;
        }
        public void print(double number)
        {
            Console.Write(number.ToString("X") + "  (in hex)");
        }
    }



    class Numeric_Decoder
    {
        public static Numeric_Base Decode(char choise)
        {
            Numeric_Base numeric_Base;
            switch(choise)
            {
                case 'b': numeric_Base = new Binary();
                    break;
                case 'o':
                    numeric_Base = new Octal();
                    break;
                case 'd':
                    numeric_Base = new Decimal();
                    break;
                case 'x':
                    numeric_Base = new Hexadecimal();
                    break;
                default:
                    numeric_Base = null;
                    break;
            }
            return numeric_Base;
        }

    }

}
