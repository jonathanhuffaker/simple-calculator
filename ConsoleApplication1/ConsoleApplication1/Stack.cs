using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Stack
    {
        public int last { get; set; }
        public string lastQ { get; set; }

   }

    public object[] ContstantSet (string userInput, string [] terms)
    {
     int constantIndex = userInput.IndexOfAny(new Char[] { 'a', 'b',
         'c', 'd', 'e', 'f', 'g',
         'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
         'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });
        if(constantIndex == -1)
        {
            throw new Exception("Enter a valid character to be used as a constant.");
        }
        
        int termVar;
        bool success = int.TryParse(terms[1], out termVar);
    }
}
