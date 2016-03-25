using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Expression
    {
        public Stack stackOnStack { get; set; }
        public Expression()
        {
            
            this.stackOnStack = new Stack();
        }

        public void handleInput(string input)
        {

            int lastAnswer = 0;
            string usersEntry = input;
            if (input == "lastq")
            {
                //print out the last question
                string lastQ = stackOnStack.lastQ;
                Console.WriteLine(usersEntry);
            }


            else if (input == "last")
            {
                //print out last result
                lastAnswer = stackOnStack.last;
                Console.WriteLine(lastAnswer);
            }
        
            else
            {
                ParseExpression(input);
            }
        }

        public object[] ParseExpression(string equation)
        {

            string expression = equation.Replace(" ", "");
            char[] operators = new char[] { '+', '-', '*', '/', '%', '='};

            char[] lowerCons = new char[] {'a', 'b',
         'c', 'd', 'e', 'f', 'g',
         'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
         'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};


            int opsIndex = expression.IndexOfAny(operators);
            string expressionToLower = expression.ToLower();
            int constantIndex = expressionToLower.IndexOfAny(lowerCons);

            if (constantIndex == -1)
            {
                throw new Exception("Enter a valid character to be used as a constant.");
            }

            if (opsIndex == -1)
            {
                Console.WriteLine("Enter a valid operator. (Ex. +,-,*,/)");
            }
            char opchar = expression[opsIndex];
            char constantChar = expression[constantIndex];
            char[] thisoperator = new char[] { opchar };

            string[] formula = equation.Split(thisoperator);
            if (formula.Length !=2)
            {
                throw new ArgumentException("Please enter a valid expression.");
            }

            int entry1;//= Convert.ToInt32(formula[0]);
            int entry2;//= Convert.ToInt32(formula[1]);


            try
            {
                entry1 = Convert.ToInt32(formula[0]);
            }
            catch (Exception e)
            {
                throw new FormatException("Your first character needs to be an integer or variable (ex A = 2, 1+1).");
            }

            try
            {
                entry2 = Convert.ToInt32(formula[1]);

            }

            catch (Exception)
            {
                throw new FormatException("The second character needs to be in integer");
            }

            if (constantIndex == -1) {
                object[] parsedExpression = { entry1, opchar, entry2 };
                stackOnStack.lastQ = equation;
                return parsedExpression;
            }
            else
            {
                object[] parsedExpression = { entry1, constantChar, entry2 };
                stackOnStack.lastQ = equation;
                return parsedExpression;

            }

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
