using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class division
    {
        public static double div (double[] dividends)
        {
            double result = 0;
            int counter = 0;

            foreach (double item in dividends)
            {
                counter++;

                if (counter == 1)
                {
                    result += item;
                }

                else
                {
                    result /= item;
                }
            }

            return (result);
        }
    }
}
