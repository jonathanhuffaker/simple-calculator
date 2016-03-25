using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Stack
    {
        Interface userInt = new Interface();
        public int last { get; set; }
        public string lastQ { get; set; }

        //Dictionary to catch a variable if equal is declared

        public Dictionary<char, int> constantDictionary = new Dictionary<char, int>();

        public void ContstantSet(object[] userInput)
        {
            if (userInput.Contains('='))
            {

                constantDictionary.Add((char)userInput[0], (int)userInput[2]);
            }
            else
            {
                throw new Exception("is variable declared correctly?");
            }
        }

        public int ConstantGetter(char theKey)
        {
            int valueOfConstant;
            if (constantDictionary.ContainsKey(theKey))
            {
                constantDictionary.TryGetValue(theKey, out valueOfConstant);

            }
            else
            {
                throw new Exception();
            }
            return valueOfConstant;
        }
                    //changing Constant set and commenting out the below for the time being
                //constantDictionary.Add((char)userInput[0], (int)userInput[2])

            




            //string strToLower = userInput.ToLower();
            //string thaEquals = userInput.IndexOfAny('=');


            //commenting out for now - refactored with expression for clarity
            //   char[] lowerCons = new char[] {'a', 'b',
            //'c', 'd', 'e', 'f', 'g',
            //'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            //'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'});


        

    }
}
