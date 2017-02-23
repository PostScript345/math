using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Basic_Calculator
{
    class factorial
    {
        public static BigInteger fact(BigInteger startpoint)
        {
            BigInteger result = startpoint;

            for (BigInteger i = startpoint - 1; i > 0; i--)
            {
                result *= i;
            }

            return (result);
        }
    }
}
