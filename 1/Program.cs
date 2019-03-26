using System;

namespace _1
{
    /*
    Program checks whether the parentheses
    are placed correctly in an arithmetic expression.
    Example of expression with correctly placed brackets: ((a+b)/5-d).
    Example of an incorrect expression: )(a+b)).
    */
    class Program
    {
        static void Main(string[] args)
        {
            // string expression = "((a+b)/5-d)";
            // string expression = "(((4+6)/8)*(9/7))";
            string expression = ")(a+b))";

            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                    counter++;
                else if (expression[i] == ')')
                    counter--;
            }

            Console.WriteLine(counter == 0 ? "Expression is correct" : "Expression is incorrect");

        }
    }
}
