using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Space_Game
{
    class Encounter
    {

        public static void Store(List<int> marketprice, List<double> stat)
        {
            Display.ClearMapScreen();
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("\n\t\t\t\tWelcome to the Store!\n");
            Console.WriteLine("\t\t\t\tHere is the products' prices:\n");
            Console.WriteLine("\t\t\t\t\t" + "{0,10}{1,10}{2,10}{3,10}{4,10}", "Granite", "Crystal", "Jade", "Ruby", "Diamond");
            Console.WriteLine("\t\t\t\t\t" + "{0,10}{1,10}{2,10}{3,10}{4,10}", 
                marketprice[0], marketprice[1], marketprice[2], marketprice[3], marketprice[4]);
            Console.WriteLine("\n\t\t\t\tchoose item to trade (Leave: Esc): Granite(G) | Cystal(C) | Jade(J) | Ruby(R) | Diamond(D)\n");
            bool run = true;
            do
            {
                Menu.Stat(stat);

                List<ConsoleKey> keys = new List<ConsoleKey>() { ConsoleKey.G, ConsoleKey.C, ConsoleKey.J, ConsoleKey.R, ConsoleKey.D };
                ConsoleKey input = Console.ReadKey(true).Key;
                for (int i = 0; i < keys.Count; i++)
                {
                    if (input == keys[i])
                    {
                        Cursor.ClearArea(0, Display.Sx2 - 1, 15, 16);
                        Console.SetCursorPosition(0, 15);
                        Console.Write("\t\t\t\tQuantity (Buy: + | Sell: -): ");
                        int qg = int.Parse(Console.ReadLine());
                        int cost = qg * marketprice[i];
                        if (cost > stat[1])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t\t\tNot enough money");
                            Console.ResetColor();
                        }
                        else if (-qg > stat[i + 2])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\t\t\tSelling more than you have");
                            Console.ResetColor();
                        }
                        else
                        {
                            stat[1] -= cost;
                            stat[i + 2] += qg;
                            Console.WriteLine("\n\t\t\t\t" + $"Your money and items stat: Money {stat[1]} | " +
                                $"Granite {stat[2]} | Crystal {stat[3]} | Jade {stat[4]} | Ruby {stat[5]} | Diamond {stat[6]}");
                        }
                        break;
                    }
                    else if (input == ConsoleKey.Escape)
                    {
                        Display.ClearMapScreen();
                        Console.SetCursorPosition(Display.Sx2 / 2 - 20, Display.Sy2 / 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thank you for trading, come back!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        run = false;
                        break;
                    }
                }

            } while (run);
            Display.ClearMapScreen();           
        }

        public static List<int> MarketPrice()
        {
            Random rd = new Random();
            var price = new List<int>() { rd.Next(5, 10), rd.Next(10, 30), rd.Next(20, 60), rd.Next(50, 100), rd.Next(100, 250) };
            return price;
        }

    }
}
