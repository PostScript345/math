using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Basic Console Personal Calculator";
            Console.WriteLine("TYPE ~help FOR LIST OF POSSIBLE COMMANDS");
            Console.WriteLine("-------------------------------------------");

            while (true)
            {
                string input = Console.ReadLine();
                string[] general = input.Split('*', '+', '/', '^', '-', '!');
                string[] mult = input.Split('*');
                string[] add = input.Split('+');
                string[] div = input.Split('/');
                string[] exp = input.Split('^');
                string[] sub = input.Split('-');
                string[] fact = input.Split('!');
                double[] numbers = new double[general.Length];

                if (fact.Length == 2)
                {
                    BigInteger facts = Convert.ToUInt64(fact[0]);

                    BigInteger result = factorial.fact(facts);

                    Console.WriteLine(result);
                    continue;
                }

                if (mult.Length > 1)
                {
                    for (int i = 0; i < mult.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(mult[i]);
                    }

                    double result = multiplication.mult(numbers.ToArray());

                    Console.WriteLine(result);
                    continue;
                }

                if (div.Length > 1)
                {
                    for (int i = 0; i < div.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(div[i]);
                    }

                    double result = division.div(numbers.ToArray());

                    Console.WriteLine(result);
                    continue;
                }

                if (add.Length > 1)
                {
                    for (int i = 0; i < add.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(add[i]);
                    }

                    double result = addition.add(numbers.ToArray());

                    Console.WriteLine(result);
                    continue;
                }

                if (exp.Length > 1)
                {
                    for (int i = 0; i < exp.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(exp[i]);
                    }

                    double result = exponents.exp(numbers.ToArray());

                    Console.WriteLine(result);
                    continue;
                }

                if (sub.Length > 1)
                {
                    for (int i = 0; i < sub.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(sub[i]);
                    }

                    double result = subtraction.sub(numbers.ToArray());

                    Console.WriteLine(result);
                    continue;
                }

                if (input == "~help")
                {
                    Console.WriteLine("Possible Operators");
                    Console.WriteLine("-------------------");
                    Console.WriteLine();
                    Console.WriteLine("+: Addition");
                    Console.WriteLine("-: Subtraction");
                    Console.WriteLine("*: Multiplication");
                    Console.WriteLine("/: Division");
                    Console.WriteLine("^: Exponent");
                    Console.WriteLine("!: Factorial");
                    continue;
                }

                Console.WriteLine(input);
            }
        }
    }
}