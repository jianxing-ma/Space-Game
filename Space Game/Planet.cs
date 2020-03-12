using System;
using System.Collections.Generic;
using System.Text;


namespace Space_Game
{
    class Planet
    {

        public string mapfilepath;
        public List<double> stat;
        // stat = {0: age, 1: money, 2: health, 3: amunition, 4: level, 5: experience, 
        //         6: item 1, 7: item 2, 8: item 3, 9: item 4, 10: item 5}
        public Planet(string mapfilepath, List<double> stat)
        {
            this.mapfilepath = mapfilepath;
            this.stat = stat;
        }

        // Planet Hotkeys & Coordinates!!!
        public static List<ConsoleKey> List = new List<ConsoleKey>() { ConsoleKey.D1,ConsoleKey.D2,ConsoleKey.D3,ConsoleKey.D4,ConsoleKey.D5}; 
        public static List<(double x, double y)> Coordiantes = new List<(double, double)>() { (0, 0),(6,6),(-7,9),( -3,-5),(8,-2) };
        public static double Distance(int i1, int i2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(Coordiantes[i1].x - Coordiantes[i2].x, 2) 
                + Math.Pow(Coordiantes[i1].y - Coordiantes[i2].y, 2)) / 10, 1);
        }
        public void Run(int stage)  // to be modified
        {
            Display.Screen();

            List<List<(int, int)>> terrain = new List<List<(int, int)>>();
            // terrain list( 0: boundaries | 1: Store | 2: Exit | 3: Gold | 4: Bandits | 5: Maze | 6: Ninja)
            for (int i = 0; i < 7; i++)         
            {
                terrain.Add(new List<(int, int)>());
            }
            Map.InitializePlanet(mapfilepath, terrain);  

            var marketprice = Encounter.MarketPrice();

            do
            {                 
                Menu.Stat(stat);

                Cursor.MoveCharacter(terrain[0]);
                
                if (terrain[1].Contains((Console.CursorLeft, Console.CursorTop)))
                {
                    var currentcoor = (Console.CursorLeft, Console.CursorTop);
                    Encounter.Store(marketprice, stat);
                    Map.Planet(mapfilepath);
                    Console.SetCursorPosition(currentcoor.Item1 + 1, currentcoor.Item2);
                }
                else if (terrain[3].Contains((Console.CursorLeft, Console.CursorTop)))
                {
                    var currentcoor = (Console.CursorLeft, Console.CursorTop);
                    Encounter.Gold(stat);  
                    Map.Planet(mapfilepath);
                    terrain[3].Remove(currentcoor);
                    Console.SetCursorPosition(currentcoor.Item1, currentcoor.Item2);        
                }
                else if (terrain[4].Contains((Console.CursorLeft, Console.CursorTop)))
                {
                    var currentcoor = (Console.CursorLeft, Console.CursorTop);
                    Encounter.Bandits(stat);
                    Map.Planet(mapfilepath);
                    terrain[4].Remove(currentcoor);
                    Console.SetCursorPosition(currentcoor.Item1, currentcoor.Item2);
                }
                else if (terrain[5].Contains((Console.CursorLeft, Console.CursorTop)))
                {
                    var currentcoor = (Console.CursorLeft, Console.CursorTop);
                    Encounter.Maze(stage);
                    Display.ClearMapScreen(); // Can add in some animation for successfully exit
                    Map.Planet(mapfilepath);
                    terrain[5].Remove(currentcoor);
                    Console.SetCursorPosition(currentcoor.Item1, currentcoor.Item2);
                }
                else if (terrain[6].Contains((Console.CursorLeft, Console.CursorTop)))
                {
                    var currentcoor = (Console.CursorLeft, Console.CursorTop);
                    Encounter.Ninja(stage);
                    Display.ClearMapScreen(); // Can add in some animation for successfully exit
                    Map.Planet(mapfilepath);
                    terrain[6].Remove(currentcoor);
                    Console.SetCursorPosition(currentcoor.Item1, currentcoor.Item2);
                }
            } while (!terrain[2].Contains((Console.CursorLeft, Console.CursorTop)));
            Display.ClearMapScreen();
        }

        

    }
}
