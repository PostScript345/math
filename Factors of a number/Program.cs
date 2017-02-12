using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Factors_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // int r;
            long n = 0;
            string message;
            Console.WriteLine("Factor Calculator");
            Console.WriteLine("------------------");

            //Code
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose a Number");

                try
                {
                    StreamWriter sr = File.AppendText("log.txt");
                    n = Int64.Parse(Console.ReadLine());
                    sr.WriteLine(DateTime.Now + " " + n);
                    sr.Close();
                }

                catch (OverflowException ofEx)
                {
                    Console.WriteLine("Value too large for an Int64");
                    message = ofEx.Message;
                    Console.WriteLine(message);
                }

                catch (FormatException aEx)
                {
                    message = aEx.Message;
                    Console.WriteLine(message);

                }

                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input");
                    message = e.Message;
                    Console.WriteLine(message);
                }

                if (n > 0)
                {
                    Logic execute = new Logic();
                    Console.WriteLine();
                    var watch = Stopwatch.StartNew();
                    execute.calc(n);
                    watch.Stop();
                    Console.WriteLine();
                    var eM = watch.ElapsedMilliseconds;
                    Console.WriteLine("Execution time: " + eM + " Milliseconds");
                    Console.WriteLine();
                }
            }
        }
    }
}
