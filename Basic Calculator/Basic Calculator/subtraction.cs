using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class subtraction
    {
        public static double sub(double[] subjects)
        {
            double result = 0;
            int counter = 0;


            foreach (double item in subjects)
            {
                counter++;

                if (counter == 1)
                {
                    result += item;
                }

                else
                {
                    result -= item;
                }
            }

            return (result);
        }
    }
}
