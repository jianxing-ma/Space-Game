using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet
    {

        public string mapfilepath;
        public List<double> stat; // stat = {age, money, item 1, item 2, item 3, item 4, item 5}
        public Planet(string mapfilepath, List<double> stat)
        {
            this.mapfilepath = mapfilepath;
            this.stat = stat;
        }

        public void Run()
        {
            Display.Screen();

            List<List<(int, int)>> terrain = new List<List<(int, int)>>();
            for (int i = 0; i < 4; i++)
            {
                terrain.Add(new List<(int, int)>());
            }
            Map.InitializePlanet(mapfilepath, terrain);

            var marketprice = Encounter.MarketPrice();

            do
            {                
                Cursor.MoveCharacter(terrain[0]);

                Menu.Stat(stat);

                if (terrain[1].Contains((Console.CursorLeft, Console.CursorTop)))
                {
                    Encounter.Store(marketprice, stat);
                    Map.Planet(mapfilepath);
                }
                else if (terrain[3].Contains((Console.CursorLeft, Console.CursorTop)))
                {
                    //Encounter.Gold(stat);  
                    Map.Planet(mapfilepath); // 如果只是这个的话可以当做传送门到spaceship;
                }
            } while (!terrain[2].Contains((Console.CursorLeft, Console.CursorTop)));
            Display.ClearMapScreen();
        }

        

    }
}
