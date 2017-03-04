using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Change: First-Fit Decreasing Bin Packing";

            while (true)
            { 
            Dictionary<string, int> money = new Dictionary<string, int>();
            money["Pennies:"] = 0;
            money["Nickels:"] = 0;
            money["Dimes:"] = 0;
            money["Quarters:"] = 0;
            money["Half-dollars:"] = 0;
            money["Dollar Notes:"] = 0;
            money["2 Dollar Notes:"] = 0;
            money["5 Dollar Notes:"] = 0;
            money["10 Dollar Notes:"] = 0;
            money["20 Dollar Notes:"] = 0;
            money["50 Dollar Notes:"] = 0;
            money["100 Dollar Notes:"] = 0;

                Console.WriteLine("Price:");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Cash:");
                decimal cash = decimal.Parse(Console.ReadLine());
                decimal change = cash - price;
                Console.WriteLine("Your change is " + change);
                Console.WriteLine();

                while (change > 0)
                {
                    if (change - 100.00m >= 0.00m)
                    {
                        change -= 100.00m;
                        money["100 Dollar Notes:"]++;
                        continue;
                    }

                    if (change - 50.00m >= 0.00m)
                    {
                        change -= 50.00m;
                        money["50 Dollar Notes:"]++;
                        continue;
                    }

                    if (change - 20.00m >= 0.00m)
                    {
                        change -= 20.00m;
                        money["20 Dollar Notes:"]++;
                        continue;
                    }

                    if (change - 10.00m >= 0.00m)
                    {
                        change -= 10.00m;
                        money["10 Dollar Notes:"]++;
                        continue;
                    }

                    if (change - 5.00m >= 0.00m)
                    {
                        change -= 5.00m;
                        money["5 Dollar Notes:"]++;
                        continue;
                    }

                    if (change - 2.00m >= 0.00m)
                    {
                        change -= 2.00m;
                        money["2 Dollar Notes:"]++;
                        continue;
                    }

                    if (change - 1.00m >= 0.00m)
                    {
                        change -= 1.00m;
                        money["Dollar Notes:"]++;
                        continue;
                    }

                    if (change - 0.50m >= 0.00m)
                    {
                        change -= 0.50m;
                        money["Half-dollars:"]++;
                        continue;
                    }

                    if (change - 0.25m >= 0.00m)
                    {
                        change -= 0.25m;
                        money["Quarters:"]++;
                        continue;
                    }

                    if (change - 0.10m >= 0.00m)
                    {
                        change -= 0.10m;
                        money["Dimes:"]++;
                        continue;
                    }

                    if (change - 0.05m >= 0.00m)
                    {
                        change -= 0.05m;
                        money["Nickels:"]++;
                        continue;
                    }

                    if (change - 0.01m >= 0.00m)
                    {
                        change -= 0.01m;
                        money["Pennies:"]++;
                        continue;
                    }
                }

                foreach (KeyValuePair<string, int> entry in money)
                {
                    if (entry.Value != 0)
                    {
                        Console.WriteLine(entry.Key + " " + entry.Value);
                    }
                }
            }
        }
    }
}
