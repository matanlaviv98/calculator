using System;

namespace basic_calculator
{
    
    class Program
    {
        enum days { sat = 0, mond, thus };
        static void Main(string[] args)
        {
             while(true)
             {
                Console.WriteLine("please chose a numeric_base:\n" +
                    "for binary enter \'b\'\n" +
                    "for octal enter \'o\'\n" +
                    "for decimal enter \'d\'\n" +
                    "for hex enter \'x\'\n");
                char choise = char.Parse(Console.ReadLine());
                Numeric_Base numeric_Base = Numeric_Decoder.Decode(choise);
                if (numeric_Base == null) continue;
                Console.WriteLine("please enter an equeation.\n" +
                                   "to exit please enter \"exit\"\n\n");
                string word = Console.ReadLine();
                if (word == "exit") break;
                Equation_Validator legitstring = new Equation_Validator(word);
                //if its empty then the user should try again.
                if (legitstring.IsEmpty()) continue;
                Calculator calulator = new Calculator(ref numeric_Base);
                double result = calulator.Calculate(legitstring.equation_s);
                Console.WriteLine("your result is: {0} (in decimal)\n" +
                    "\nyour result is: ", result);
                numeric_Base.print(result);
                Console.WriteLine("\n\n");
                Console.Write("your result is: ");
             }
        }
    }


    
}



