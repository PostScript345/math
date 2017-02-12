using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nc
{
    class calc
    {
        public void program()
        {
            string errormessage;
            long n = 0;
            // Information reguarding program

            Console.WriteLine();
            Console.WriteLine("The Collatz Conjecture Calculator");
            Console.WriteLine("The Collatz Conjuncture is one of the most famous unsolved problems in mathematics.");
            Console.WriteLine("It states that if you pick any number as a starpoint and create a calculation loop with 3n+1 if odd and n / 2 if even.");
            Console.WriteLine("No matter how many steps, the final answer is always 1.");
            Console.WriteLine("This is a program to display and calculate all the steps within the loop from a given startpoint.");

            while (true)
            {
                StreamWriter actions = File.AppendText("log.txt");
                int a = 0;
                Console.WriteLine();
                Console.WriteLine("Choose your startpoint");

                // prompts user for startpoint 

                try
                {
                    n = Int64.Parse(Console.ReadLine());
                }

                catch (OverflowException ofEx)
                {
                    errormessage = ofEx.Message;
                    Console.WriteLine(errormessage);
                    actions.WriteLine(DateTime.Now + " " + errormessage);
                    actions.Close();
                }

                catch (DivideByZeroException dEx)
                {
                    errormessage = dEx.Message;
                    Console.WriteLine(errormessage);
                    actions.WriteLine(DateTime.Now + " " + errormessage);
                    actions.Close();
                }

                catch (Exception e)
                {
                    errormessage = e.Message;
                    Console.WriteLine();
                    Console.WriteLine("The input is invalid");
                    actions.WriteLine(DateTime.Now + " " + e);
                    actions.Close();
                }

                //if user input isnt -1
                if (n > 0)
                {
                    actions.WriteLine(DateTime.Now + " Startpoint: " + n);
                    Console.WriteLine(n);
                }

                // Does Calculation

                while (n > 1)
                {
                    switch (n % 2)
                    {
                        case 1:
                            n *= 3;
                            n += 1;
                            a++;
                            Console.WriteLine(n);
                            break;
                        default:
                            n /= 2;
                            a++;
                            Console.WriteLine(n);
                            break;
                    }
                }

                if (n == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(a + " Steps");
                    actions.WriteLine(a + " Steps");
                }

                // for exiting program
                if (n == -1)
                {
                    string exit;
                    Console.WriteLine();
                    Console.WriteLine("Exit? Y/N :");
                    Console.WriteLine();
                    exit = Console.ReadLine();

                    // user confirms
                    if (exit == "y")
                    {
                        actions.WriteLine(DateTime.Now + " Specified user has exit the program");
                        actions.Close();
                        System.Environment.Exit(1);
                    }
                }
                actions.Close();
            }
        }
    }
}