using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class multiplication
    {
        public static double mult(double[] multiplicants)
        {
            int counter = 0;
            double result = 0;

            foreach (double item in multiplicants)
            {
                counter++;

                if (counter == 1)
                {
                    result += item;
                }

                else
                {
                    result *= item;
                }
            }

            return (result);
        } 
    }
}
