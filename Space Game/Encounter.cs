using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Space_Game
{
    class Encounter
    {

        //_____________________________________________________STORE__________________________________________________________
        public static void Store(List<int> marketprice, List<double> stat)
        {
            Display.ClearMapScreen();
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("\t\t\t\tWelcome to the Store!\n");
            Console.WriteLine("\t\t\t\tHere is the products' prices:\n");
            List<string> items = new List<string>() { "Granite(G)", "Crystal(C)", "Jade(J)", "Ruby(R)", "Diamond(D)" };
            List<string> itemcolors = new List<string>() { "White", "Yellow", "Green", "Red", "Blue"};
            Cursor.WriteColorListAt(items, 40, 10, itemcolors, 15);
            Cursor.WriteListAt(new List<int> { marketprice[0], marketprice[1], marketprice[2], marketprice[3], marketprice[4] }, 
                40, 11, 15);           
            Console.WriteLine("\n\n\t\t\t\tChoose item to trade(Leave: Esc): "); // Granite(G) | Cystal(C) | Jade(J) | Ruby(R) | Diamond(D)
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
                        //Cursor.ClearArea(0, Display.Sx2 - 1, 15, 17);
                        Cursor.WriteAt($"{items[i]}", 32, 15, (ConsoleColor)Enum.Parse(typeof(ConsoleColor), itemcolors[i]));
                        Console.Write("\n\t\t\t\tQuantity (Buy: + | Sell: -): ");
                        int qg = int.Parse(Console.ReadLine());
                        int cost = qg * marketprice[i];
                        if (cost > stat[1])
                        {
                            Cursor.WriteAt("Not enough money", 32, 17, ConsoleColor.Red);
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Cursor.ClearArea(0, Display.Sx2 - 1, 15, 17);
                        }
                        else if (-qg > stat[i + 2])
                        {
                            Cursor.WriteAt("Selling more than you have", 32, 17, ConsoleColor.Red);
                            Console.ResetColor();
                            Thread.Sleep(1500);
                            Cursor.ClearArea(0, Display.Sx2 - 1, 15, 17);
                        }
                        else
                        {
                            stat[1] -= cost;
                            stat[i + 6] += qg;
                            Console.WriteLine("\n\t\t\t\t" + $"Your money and items stat: Money {stat[1]} | " +
                                $"Granite {stat[6]} | Crystal {stat[7]} | Jade {stat[8]} | Ruby {stat[9]} | Diamond {stat[10]}");
                            Cursor.ClearArea(0, Display.Sx2 - 1, 15, 17);
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

        //______________________________________________________GOLD_____________________________________________________________
        public static void Gold(List<double> stat)
        {
            Cursor.WriteTextAt(@"Text\Gold.txt", 10, 10, ConsoleColor.Yellow);
            int gold = new Random().Next(50,500);
            stat[1] += gold;
            Console.WriteLine($"\n\n\t\t\t\t\t\t\tYou gained {gold}!");
            Thread.Sleep(2000);
            Display.ClearMapScreen();
        }


        //______________________________________________________BANDITS__________________________________________________________
        public static void Bandits(List<double> stat)
        {
            Display.ScreenArt(@"Text\Bandits.txt", ConsoleColor.Red);
            int money = new Random().Next(50, 500);
            stat[1] -= money;
            Console.WriteLine($"\n\t\t\t\t\t\t\tYou lost {money}!");
            Thread.Sleep(2000);
            Display.ClearMapScreen();
        }


        // _______________________________________________________MAZE____________________________________________________________

        public static List<string> MazeList = new List<string>() 
        {
            @"Text\Maze1.txt",
            @"Text\Maze2.txt",
            @"Text\Maze3.txt",
            @"Text\Maze4.txt",
            @"Text\Maze5.txt",
        };
        public static void Maze(int stage) // Set up a list of strings of mappath, use in stage as parameter 
        {

            Display.ClearMapScreen();
            
            List<List<(int, int)>> terrain = new List<List<(int, int)>>();
            for (int i = 0; i < 3; i++)               //  Maze terrain ( 0: Boundaries | 1: Entrance | 2: Exit ) 
            {
                terrain.Add(new List<(int, int)>());
            }
            
            Cursor.WriteTextAt(@"Text\MazeEnter.txt", 0, 2, ConsoleColor.Red);
            Thread.Sleep(2000);
            Display.ClearMapScreen();
            
            Map.InitializeMaze(MazeList[stage- 1], terrain);
            do
            {
                Cursor.MoveCharacter(terrain[0]);

                if (terrain[2].Contains((Console.CursorLeft, Console.CursorTop)))
                {
                    break;
                }
            } while (true);

            Display.ClearMapScreen();
            Cursor.WriteTextAt(@"Text\MazeExit.txt", 0, 2, ConsoleColor.Green);
            Thread.Sleep(2000);
        }


        // _______________________________________________________NINJA____________________________________________________________


        public static List<string> NinjaList = new List<string>()
        {
            @"Text\Ninja1.txt",
            @"Text\Ninja2.txt",
            @"Text\Maze3.txt",
            @"Text\Maze4.txt",
            @"Text\Maze5.txt",
        };

        public static void Ninja(int stage)
        {

            Display.ClearMapScreen();

            List<List<(int, int)>> terrain = new List<List<(int, int)>>();
            for (int i = 0; i < 3; i++)               
                //  Ninja terrain ( 0: Boundaries | 1: Player Initial Position | 2: Blinker Initial Position ) 
            {
                terrain.Add(new List<(int, int)>());
            }

            // Create Anime that a ninja stole from you, catch him
            //Display.ClearMapScreen();

            Map.InitializeMaze(NinjaList[stage - 1], terrain);

            //_______________   Map Established ___________________


            int ninjax = terrain[2][0].Item1; int ninjay = terrain[2][0].Item2;    // Blinker's starting postion
            Cursor.WriteAt("*", ninjax, ninjay);                      // If shadow positions, maybe no initial needed

            Console.SetCursorPosition(terrain[1][0].Item1, terrain[1][0].Item2);       // Player's starting postion
            
            //-------------------- Initiate meeting the ninja-----------------------
            List<(int, int)> shadows = new List<(int, int)>();
            do
            {
                Cursor.MoveCharacter(terrain[0]);
            } while ((Console.CursorLeft, Console.CursorTop) != (ninjax, ninjay));

            for (int i = 0; i < 5; i++)
            {
                int x = new Random().Next(50, 90); int y = new Random().Next(7, 23);    // scale to be modified 
                if (!terrain[0].Contains((x, y)))
                {
                    Cursor.WriteAt("*", x, y, (ConsoleColor)new Random().Next(1, 16));
                    shadows.Add((Console.CursorLeft - 1, Console.CursorTop));
                    //Thread.Sleep(1000);
                }
            }
            ninjax = shadows[0].Item1; ninjay = shadows[0].Item2;              // Ninja's real position is the first one
            shadows.RemoveAt(0);                                                   // Exclude real position from shadows list
            Console.SetCursorPosition(terrain[2][0].Item1, terrain[2][0].Item2);   // Player is at where he met ninja
            
                   
            //-----------------------Met the Ninja, first shadows created, chasing begins--------------------
            do
            {               
                var player = (x: Console.CursorLeft, y: Console.CursorTop);   // Always track player's position
                
                // Scenario: Caught the shadow, not the real blinker
                if ((player.x, player.y) != (ninjax, ninjay) && shadows.Contains(player)) 
                {
                    // Create mist before clearing screen, create points throughout screen.
                    Cursor.ClearArea(50,90,7,23);
                    //Map.Planet(NinjaList[stage - 1]);
  
                    shadows.Clear();    // Shadows list defaults
                    for (int i = 0; i < 5; i++)
                    {
                        int x = new Random().Next(50, 90); int y = new Random().Next(7, 23);    // scale to be modified 
                        if (!terrain[0].Contains((x, y)))
                        {                                                       
                            Cursor.WriteAt("*", x, y, (ConsoleColor)new Random().Next(1, 16));
                            shadows.Add((Console.CursorLeft - 1, Console.CursorTop));
                            //Thread.Sleep(1000);
                        }
                    }
                    ninjax = shadows[0].Item1; ninjay = shadows[0].Item2;              // Blinker's real position is the first one
                    shadows.RemoveAt(0);                                                   // Exclude real position from shadows list
                }

                //Scenario: Caught the real Ninja
                else if (player == (ninjax, ninjay))
                {
                    break;
                }

                Console.SetCursorPosition(player.x, player.y);
                Cursor.MoveCharacter(terrain[0]);

            } while (true);

        }



        public static void BlinkerGame()
        {
            int x = new Random().Next(0, Console.WindowWidth - 1); int y = new Random().Next(0, 30);
            Cursor.WriteAt("*", x, y);
            Console.SetCursorPosition(20, 20);
            do
            {
                Tuple<int, int> current = new Tuple<int, int>(Console.CursorLeft, Console.CursorTop);

                if (current.Item1 == x && current.Item2 == y)
                {
                    int coorx = new Random().Next(0, Console.WindowWidth - 1); int coory = new Random().Next(0, 30);
                    Cursor.WriteAt("*", coorx, coory);
                    x = coorx; y = coory;
                }

                Console.SetCursorPosition(current.Item1, current.Item2);
                Cursor.MoveCharacter(Display.ScreenBoudaries());

            } while (true);
        }

        //________________________________________________________FIGHT_____________________________________________________________

        public static void Fight(List<double> stat, List<double> enemy)
        {
            Display.ClearMapScreen();
            Cursor.WriteAt("You encountered !", 32, 10);
            double enemyhealth = 100; double enemyattack = 5;
            bool fightstatus = true;
            do
            {
                Cursor.WriteAt("The enemy attacks with    move!", 32, 12); // Random Move List
                stat[2] -= enemyattack;
                Cursor.WriteAt("You move   ", 32, 15);
                enemyhealth -= stat[2];
                if (stat[2] <= 0) { fightstatus = false; }
                else if (enemyhealth <= 0)
                {
                    stat[5] += enemy[3];
                    // if experience levels up, do level up
                    fightstatus = false; 
                }
                //else if (escape = true) { fightstatus = false; }

            } while (fightstatus);

        }


        //___________________________________________________________________________________________________________________________

    }
}
