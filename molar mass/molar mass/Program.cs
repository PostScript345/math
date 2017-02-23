using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace molar_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Molar Mass Calculator";

            while (true)
            {
                Dictionary<string, float> elements = new Dictionary<string, float>();
                elements["H"] = 1.0079f;
                elements["He"] = 4.0026f;
                elements["Li"] = 6.941f;
                elements["Be"] = 9.0122f;
                elements["B"] = 10.811f;
                elements["C"] = 12.0107f;
                elements["N"] = 14.0067f;
                elements["O"] = 15.9994f;
                elements["F"] = 18.9984f;
                elements["Ne"] = 20.1797f;
                elements["Na"] = 22.9897f;
                elements["Mg"] = 24.305f;
                elements["Al"] = 26.9815f;
                elements["Si"] = 28.0855f;
                elements["P"] = 30.9738f;
                elements["S"] = 32.065f;
                elements["Cl"] = 35.453f;
                elements["Ar"] = 39.948f;
                elements["Ca"] = 40.078f;
                elements["Sc"] = 44.9559f;
                elements["Ti"] = 47.867f;
                elements["V"] = 50.9415f;
                elements["Cr"] = 51.9961f;
                elements["Mn"] = 54.938f;
                elements["Fe"] = 55.845f;
                elements["Ni"] = 58.6934f;
                elements["Co"] = 58.9332f;
                elements["Cu"] = 63.546f;
                elements["Zn"] = 65.39f;
                elements["Ga"] = 69.723f;
                elements["Ge"] = 72.64f;
                elements["As"] = 74.9216f;
                elements["Se"] = 78.96f;
                elements["Br"] = 79.94f;
                elements["Kr"] = 83.8f;
                elements["Rb"] = 85.4678f;
                elements["Sr"] = 87.62f;
                elements["Y"] = 88.9059f;
                elements["Zr"] = 91.224f;
                elements["Nb"] = 92.9064f;
                elements["Mo"] = 95.94f;
                elements["Tc"] = 98.0f;
                elements["Ru"] = 101.07f;
                elements["Rh"] = 102.9055f;
                elements["Pd"] = 106.42f;
                elements["Ag"] = 107.8682f;
                elements["Cd"] = 112.411f;
                elements["Sn"] = 118.7100f;
                elements["Sb"] = 121.76f;
                elements["I"] = 126.9045f;
                elements["Te"] = 127.6f;
                elements["Xe"] = 131.293f;
                elements["Cs"] = 132.9055f;
                elements["Ba"] = 137.327f;
                elements["La"] = 138.9055f;
                elements["Ce"] = 140.116f;
                elements["Pr"] = 140.9077f;
                elements["Nd"] = 144.24f;
                elements["Pm"] = 145.0f;
                elements["Sm"] = 150.36f;
                elements["Eu"] = 151.964f;
                elements["Gd"] = 157.25f;
                elements["Tb"] = 138.9253f;
                elements["Dy"] = 162.5f;
                elements["Ho"] = 164.9303f;
                elements["Er"] = 167.259f;
                elements["Tm"] = 168.9342f;
                elements["Yb"] = 173.04f;
                elements["Lu"] = 174.967f;
                elements["Hf"] = 178.49f;
                elements["Ta"] = 180.9479f;
                elements["W"] = 183.84f;
                elements["Re"] = 186.207f;
                elements["Os"] = 190.23f;
                elements["Ir"] = 192.217f;
                elements["Pt"] = 195.078f;
                elements["Au"] = 196.9665f;
                elements["Hg"] = 200.59f;
                elements["Tl"] = 204.3833f;
                elements["Pb"] = 207.2f;
                elements["Bi"] = 208.9804f;
                elements["Po"] = 209.0f;
                elements["At"] = 210f;
                elements["Rn"] = 222f;
                elements["Fr"] = 223f;
                elements["Ra"] = 226f;
                elements["Ac"] = 227f;
                elements["Pa"] = 231.0359f;
                elements["Th"] = 232.0381f;
                elements["Np"] = 237f;
                elements["U"] = 238.0289f;
                elements["Am"] = 243f;
                elements["Pu"] = 244f;
                elements["Cm"] = 247f;
                elements["Bk"] = 247f;
                elements["Cf"] = 251f;
                elements["Es"] = 252f;
                elements["Fm"] = 257f;
                elements["Md"] = 258f;
                elements["No"] = 259f;
                elements["Rf"] = 261f;
                elements["Lr"] = 262f;
                elements["Db"] = 262f;
                elements["Bh"] = 264f;
                elements["Sg"] = 266f;
                elements["Mt"] = 268f;
                elements["Rg"] = 272f;
                elements["Hs"] = 277f;

                string input = Console.ReadLine();
                char[] split = input.ToCharArray();
                string[] values = new string[split.Length];
                int[] multiples = new int[values.Length];
                float result = 0.000f;
                int counter = 0;
                int newmultiple = 0;
                int counterf = 0;
                int resize = 0;


                // split[] --> values[]
                // if values[i] == int --> multiples[]
                // if values[i] == string

                for (int i = 0; i < split.Length; i++)
                {
                    values[i] = split[i].ToString();
                }

                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i].Any(char.IsLower))
                    {
                        resize++;
                    }
                }

                string[] symbols = new string[values.Length - resize];

                for (int i = 0; i < values.Length; i++)
                {
                    try
                    {
                        multiples[i - counter] = Convert.ToInt32(values[i]);
                    }

                    catch (FormatException)
                    {
                        if (values[i].Any(char.IsLower))
                        {
                            counter++;
                            symbols[i - counter] = Convert.ToString(values[i - 1] + values[i]);
                        }

                        if (values[i].Any(char.IsUpper))
                        {
                            symbols[i - counter] = Convert.ToString(values[i]);
                        }
                    }
                }

                counter = 0;

                for (int i = 0; i < symbols.Length; i++)
                {
                    try
                    {
                        if (elements.ContainsKey(symbols[i]))
                        {
                            result = result + elements[symbols[i]];
                            counter = 0;
                            counterf = 0;
                        }
                    }

                    catch (ArgumentNullException)
                    {
                        counter++;

                        if (counter > 1)
                        {
                            if (counterf == 1)
                            {
                                result = result - (elements[symbols[i - 2]] * multiples[i - 1]);
                                counterf = 0;
                            }

                            result = result - (elements[symbols[i - counter]] * newmultiple);
                            newmultiple = 0;

                            for (int a = counter; a > 0; a--)
                            {
                                if (newmultiple == 0)
                                {
                                    newmultiple = multiples[i - (a - 1)];
                                }

                                else
                                {
                                    newmultiple = int.Parse(newmultiple.ToString() + multiples[i - (a - 1)].ToString());
                                }
                            }

                            result = result + (elements[symbols[i - counter]] * newmultiple);
                        }

                        else
                        {
                            counterf++;
                            result = result - elements[symbols[i - 1]];
                            result = result + (elements[symbols[i - 1]] * multiples[i]);
                        }
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}