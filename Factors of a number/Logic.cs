using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Factors_of_a_number
{
    class Logic
    {
        public void calc(long number)
        {
            StreamWriter sw = File.AppendText("log.txt");
            long i = 1;
            int a = 0;
            Console.WriteLine("Factors:");
            Console.WriteLine("1");
            while (i < (number / 2))
            {
                i++;

                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    a++;
                }
            }
            a = a + 2;
            Console.WriteLine(number);
            sw.WriteLine(DateTime.Now + " Finished");
            sw.Close();
            Console.WriteLine();
            Console.WriteLine(number + " has " + a + " Factors");

            //is the number prime
            if (a == 2)
            {
                Console.WriteLine(number + " is a prime number");
            }
        }
    }
}
