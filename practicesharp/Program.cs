using System;

namespace practicesharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("please enter an equeation.\n" +
                                  "to exit please enter \"exit\"\n\n");
                string word = Console.ReadLine();
                if (word == "exit") break;
                Equation_Validator legitstring = new Equation_Validator(word);
                //if its empty then the user should try again.
                if (legitstring.IsEmpty()) continue;
                Calculator cal = new Calculator();
                double result = cal.Calculate(legitstring.equation_s);
                Console.WriteLine("your result is: \"{0}\"\n\n" , result);
            }
        }
    }


    
}



