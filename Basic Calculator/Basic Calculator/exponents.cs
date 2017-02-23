using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class exponents
    {
        public static double exp(double[] exponent)
        {
            double result = 0;
            int counter = 0;

            foreach (double item in exponent)
            {
                counter++;

                if (counter == 1)
                {
                    result += item;
                }

                else
                {
                    result = Math.Pow(result, item);
                }
            }

            return (result);
        }
    }
}
