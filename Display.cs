using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Display
    {

        public void UniverseMap()
        {
            Cursor cursor = new Cursor();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (int i = 8; i < 151; i++)
            {
                cursor.WriteAt(" ", i, 4);
                cursor.WriteAt(" ", i, 35);
                cursor.WriteAt(" ", i, 41);
            }
            for (int j = 4; j < 42; j++)
            {
                cursor.WriteAt(" ", 8, j);
                cursor.WriteAt(" ", 150, j);
            }
            Console.ResetColor();

            Random rnd = new Random();
            for (int i = 10; i < 150; i += 5)
            {
                for (int j = 5; j < 35; j += 5)
                {
                    cursor.WriteAt("*", rnd.Next(i, i+5), rnd.Next(j, j+5));
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            cursor.WriteAt("*", 80, 20);           

            Console.ForegroundColor = ConsoleColor.Red;
            cursor.WriteAt("*", 40, 10);

            Console.ForegroundColor = ConsoleColor.Cyan;
            cursor.WriteAt("*", 50, 28);

            Console.ForegroundColor = ConsoleColor.Green;
            cursor.WriteAt("*", 120, 10);

            Console.ForegroundColor = ConsoleColor.Magenta;
            cursor.WriteAt("*", 110, 25);

            Console.ResetColor();

            Console.SetCursorPosition(78, 21);
        }





    }
}
