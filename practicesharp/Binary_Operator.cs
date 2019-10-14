using System;
using System.Collections.Generic;
using System.Text;

namespace basic_calculator
{
    public interface Binary_Operator
    {
        public double Activate(double first, double second);
    }


    public class Add_operator : Binary_Operator
    {
        public double Activate(double first, double second)
        {
            return first + second;
        }
    }
    public class Sub_operator : Binary_Operator
    {
        public double Activate(double first, double second)
        {
            return first - second;
        }
    }
    public class Mul_operator : Binary_Operator
    {
        public double Activate(double first, double second)
        {
            return first * second;
        }
    }
    public class Div_operator : Binary_Operator
    {
        public double Activate(double first, double second)
        {
            return first / second;
        }
    }

    public class Operator_Decoder
    {
        static public Binary_Operator Decode(char input)
        {
            Binary_Operator binary_Operator = null;
            switch (input)
            {
                case '+':
                    binary_Operator = new Add_operator();
                    break;
                case '-':
                    binary_Operator = new Sub_operator();
                    break;
                case '*':
                    binary_Operator = new Mul_operator();
                    break;
                case '/':
                    binary_Operator = new Div_operator();
                    break;
            }
            return binary_Operator;
        }
    }
}
