using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Space_Game
{
    class Display
    {
        public static int Sx1 = 9, Sx2 = 150, Sy1 = 4, Sy2 = 35, Sy3 = 41;

        public static void Screen()
        {          
            Console.BackgroundColor = ConsoleColor.DarkGray;
            
            for (int i = Sx1; i < Sx2+1; i++)
            {
                Cursor.WriteAt(" ", i, Sy1);
                Cursor.WriteAt(" ", i, Sy2);
                Cursor.WriteAt(" ", i, Sy3);
            }
            for (int j = Sy1; j < Sy3 + 1; j++)
            {
                Cursor.WriteAt(" ", Sx1, j);
                Cursor.WriteAt(" ", Sx2, j);
            }
            Console.ResetColor();
        }

        public static void ClearMapScreen()
        {
            Cursor.ClearArea(Sx1 + 1, Sx2 - 1, Sy1 + 1, Sy2 - 1);
        }
        public static void ClearMenuScreen()
        {
            Cursor.ClearArea(Sx1 + 1, Sx2 - 1, Sy2 + 1, Sy3 - 1);
        }
        public static List<(int, int)> ScreenBoudaries()
        {
            List<(int, int)> Boundaries = new List<(int, int)>();

            for (int i = Sx1; i < Sx2 + 1; i++)
            {
                Boundaries.Add((i, Sy1));
                Boundaries.Add((i, Sy2));
            }
            for (int i = Sy1; i < Sy2 + 1; i++)
            {
                Boundaries.Add((Sx1, i));
                Boundaries.Add((Sx2, i));

            }
            return Boundaries;
        }

        public static void UniverseMap()
        {  
            // Print random stars as background
            Random rnd = new Random();
            for (int i = Sx1+1; i < Sx2; i += 5)
            {
                for (int j = Sy1+1; j < Sy2; j += 5)
                {
                    Cursor.WriteAt("*", rnd.Next(i, i+5), rnd.Next(j, j+5));
                }
            }

            // Print Planets
            var PlanetLocation = new List<(string color, (int x, int y)coord)> { ("Blue", (80, 20)), ("Red",(40,10)),
                ("Cyan",(50,28)),("Green",(120,10)),("Magenta",(110,25))}; 

            foreach (var item in PlanetLocation)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), item.color);
                Cursor.WriteAt("*", item.coord.x, item.coord.y);
            }
            Console.ResetColor();

            // Print Spaceship
            Console.SetCursorPosition(81, 20);
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine((char)0x25B2);
            Console.ResetColor();
        }


        //public static void SpaceTravelAnime()
        //{
        //    ClearMapScreen();
        //    Random rd = new Random();
        //    //for 
        //}

        public static void EarthMap()
        {
            for (int i = 20; i < 25; i++)
            {
                for (int j = 20; j < 25; j++)
                {
                    Cursor.WriteAt("#", i, j);
                }
            }
        }
        public static List<(int,int)> EarthMapBoundaries()
        {
            List<(int, int)> Boundaries = ScreenBoudaries();
            for (int i = 20; i <25; i++)
            {
                Boundaries.Add((20, i));
                Boundaries.Add((24, i));
                Boundaries.Add((i, 20));
                Boundaries.Add((i, 24));
            }
            return Boundaries;
        }


    }
}
