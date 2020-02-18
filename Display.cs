using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Display
    {
        private static int Sx1 = 9, Sx2 = 150, Sy1 = 4, Sy2 = 35, Sy3 = 41;

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





    }
}
