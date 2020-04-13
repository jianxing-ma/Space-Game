using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Space_Game
{
    class StoryLine
    {
        public StoryLine()
        {

        }

        

        
        public static void RunGame()
        {
            Console.SetWindowSize(140, 40);

            string statpath = @"Stat\Stat.txt";
            string stagepath = @"Stat\Stage.txt";
            List<double> stat = File.ReadAllLines(statpath).ToList().ConvertAll(double.Parse);
            int Stage = int.Parse(File.ReadAllText(stagepath));
            int defaultstage = 0;
            List<double> defaultstat = new List<double> { 18, 5000, 100, 100, 1, 0}; 
            for (int i = 0; i < 5; i++) { defaultstat.Add(0); }

            Display.Screen();
            //Display.Intro();
            Console.SetCursorPosition(2, 36);
            Menu.Intro();
            Display.ClearMenuScreen();
            int currentplanet = 0;
            do
            {                
                switch (Stage)
                {
                    case 0:
                        Display.ClearMapScreen();
                        Display.UniverseMap();                        
                        Cursor.WriteAt("Choose Destination (Earth: 1 | Alpha Centauri I: 2 | Planet 3: 3 | Planet 4: 4 | Planet 5: 5)", 24, 33);  
                        ConsoleKey x = Console.ReadKey(true).Key;
                        for (int i = 0; i < Planet.List.Count; i++)
                        {
                            if (Planet.List[i] == x)
                            {
                                Stage = i + 1;
                                File.WriteAllText(stagepath, Stage.ToString());
                                double distance = Planet.Distance(currentplanet, Stage - 1);   stat[0] += distance;
                                double travelcost = Math.Round(980*distance, 3);               stat[1] -= travelcost;
                                Cursor.WriteAt($"\t\t\tDistance is {distance}.", 0, 35);
                                Cursor.WriteAt($"\t\t\tTravel cost is {travelcost}.", 0, 36);
                                Thread.Sleep(1000);
                                Console.Clear();
                                if (currentplanet != Stage - 1)
                                {
                                    Anime.SpaceTravel();
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                                        
                            }
                            else if (x == ConsoleKey.S)
                            {
                                File.WriteAllLines(statpath, stat.Select(x => x.ToString()).ToArray());
                                Cursor.WriteAt("Progress saved!", 55, 32, ConsoleColor.Green);
                                Thread.Sleep(500);
                            }
                        }                        
                        Display.ClearMenuScreen();
                        break;
                    case 1:
                        Display.ClearMapScreen();
                        Planet earth = new Planet(@"Map\Earth.txt", stat);
                        earth.Run(Stage);
                        currentplanet = Stage - 1;
                        Stage = 0;                       
                        break;

                    case 2:
                        Display.ClearMapScreen();
                        Planet planet2 = new Planet(@"Map\Centauri.txt", stat);
                        planet2.Run(Stage);
                        currentplanet = Stage - 1;
                        Stage = 0;
                        break;
                    case 3:
                        Display.ClearMapScreen();
                        Planet yinyang = new Planet(@"Map\Yinyang.txt", stat);
                        yinyang.Run(Stage);
                        currentplanet = Stage - 1;
                        Stage = 0;
                        break;
                    case 4:
                        Display.ClearMapScreen();
                        Planet jibber = new Planet(@"Map\Jibber.txt", stat);
                        jibber.Run(Stage);
                        currentplanet = Stage - 1;
                        Stage = 0;
                        break;
                    case 5:
                        Display.ClearMapScreen();
                        Planet vegita = new Planet(@"Map\Vegita.txt", stat);
                        vegita.Run(Stage);
                        currentplanet = Stage - 1;
                        Stage = 0;
                        break;

                }


            } while (stat[0] < 65 && stat[1] > 0 && stat[1] < Math.Pow(10,5));

            if (stat[0] >= 65)
            {
                Display.ScreenArt(@"Text\OutOfTime.txt", ConsoleColor.Red);
                Cursor.WriteAt("TRY HARDER NEXT TIME", 55, 20, ConsoleColor.Green);

                File.WriteAllText(stagepath, defaultstage.ToString());
                File.WriteAllLines(statpath, defaultstat.Select(x => x.ToString()).ToArray());
                // give option to restart game.
            }
            else if (stat[1] <= 0)
            {
                Display.ScreenArt(@"Text\OutOfMoney.txt", ConsoleColor.Red);
                Cursor.WriteAt("TRY HARDER NEXT TIME", 55, 20, ConsoleColor.Green);

                File.WriteAllText(stagepath, defaultstage.ToString());
                File.WriteAllLines(statpath, defaultstat.Select(x => x.ToString()).ToArray());
                // give option to restart game                
            }
            else if (stat[1] >= Math.Pow(10, 5))
            {
                Display.ScreenArt(@"Text\Congratulations.txt");
                Cursor.WriteAt("You traveled back in time", 53, 20, ConsoleColor.Green);
                Cursor.WriteAt("Julia was saved", 58, 21, ConsoleColor.Green);

                File.WriteAllText(stagepath, defaultstage.ToString());
                File.WriteAllLines(statpath, defaultstat.Select(x => x.ToString()).ToArray());
            }
            // 通关 else
        }

    }
}
