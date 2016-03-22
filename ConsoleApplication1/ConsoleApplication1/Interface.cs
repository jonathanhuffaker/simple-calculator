using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Interface
    {
        public int counter {get; set;}

        public Interface()
        {
            counter = 0;
        }

        public string FirstCalInput()
        {
            return String.Format("[{0}]>", counter);
        }

        public string AnsExpression(double answer)
        {
            string ansString = String.Format("  = {0}", answer);
            counter++;
            return ansString;
        }

        //do my last and lasq need to fit in here?
    }


}
