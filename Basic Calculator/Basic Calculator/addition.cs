using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class addition
    {
        public static double add(double[] subjects)
        {
            double result = 0;

            foreach (double item in subjects)
            {
                result += item;
            }

            return (result);
        }
    }
}
