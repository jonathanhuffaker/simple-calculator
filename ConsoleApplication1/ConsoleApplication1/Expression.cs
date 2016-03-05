﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Expression
    {
        public string ParseExpression(string equation)
        {

            string expression = equation.Replace(" ", "");
            char[] operators = new char[] { '+', '-', '*', '/'};
            int opsIndex = expression.IndexOfAny(operators);

            if (opsIndex == -1)
            {
                Console.WriteLine("Enter a valid operator. (Ex. +,-,*,/)");
            }

            return expression;
            //ParseExpression 
            //int entry1= (expression);
            //int entry2;




        }
        // Prove you can extract the terms of the expression.

        // Prove you can extract the operation embedded in the expression.
        // Ensure you have examples of GOOD and BAD input and have your Expression class throw an exception when there's an error.
        //Hints

        //Your expression should work with and without spaces. (i.e.both 2+1 and 2 + 1 should work)
        //The use of Regular Expressions is not required.
        //GOOD input example: 1+2
        //BAD input example +2
        //You do not need to handle the cases of usage of parenthesis or expressions with more than 2 terms.

    }
}
