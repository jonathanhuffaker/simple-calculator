using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Evaluate
    {
       public int EvaluateResult(object[] entries)
        {
        
            int entry1 = (int) entries[0];
            int entry2 = (int)entries[2];
            char op = (char) entries[1];

            if (op == '+')
            {
                Addition addEnts = new Addition();
                return addEnts.addEntries(entry1, entry2);
            }
            if (op == '-')
            {
                Subtraction subtractEnts = new Subtraction();
                return subtractEnts.subtractEntries(entry1, entry2);
            }
            if (op == '*')
            {
                Multiplication multEnts = new Multiplication();
                return multEnts.multiplyEntries(entry1, entry2);
            }
            if (op == '/')
            {
                Division divideEnts = new Division();
                return divideEnts.divideEntries(entry1, entry2);
            }
            if (op == '%')
            {
                Modulus modulusEnts = new Modulus();
                return modulusEnts.modulusEntries(entry1, entry2);
            }
            throw new Exception("Please enter a valid expression");


        }

    }
}
//Chunk 2 - Evaluting Simple Expressions

//Goal

//Using Test Driven Development, create another class (the name is up to you, but must be separate from the class int he first Chuch) that can evaluate a simple 2-term calculator expression, returning the appropriate answer.

//Prove your class can execute the correct operation of a GOOD expression. (If you already have classes for the various math operations, this is easy).
//Prove your class can handle a BAD expression.
//FAQs/Hints

//Should my Evaluate class print something to the Console? No