using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Space_Game
{
    class Anime
    {
        public static void SpaceTravel(int timer = 200)
        {
            int alignx = 50; int aligny = 25;
            Console.SetWindowSize(140, 40);
            Console.CursorVisible = false;
            Cursor.WriteTextAt(@"Text\SpaceshipAnimeStart.txt", alignx, 10, ConsoleColor.Red);
            Thread.Sleep(1500);
            Console.Clear();
            Cursor.WriteTextAt(@"Text\SpaceshipAnimeBase.txt", alignx, aligny, ConsoleColor.DarkCyan);
            for (int i = aligny + 5; i > 0; i--)
            {
                Cursor.WriteTextAt(@"Text\SpaceshipAnime.txt", alignx, i, ConsoleColor.White);
                Thread.Sleep(timer);
                Cursor.ClearArea(alignx + 18, alignx + 23, i, i + 8);
            }
            Console.Clear();
            Cursor.WriteTextAt(@"Text\SpaceshipAnimeLanding.txt", alignx - 10, 10, ConsoleColor.DarkGreen);
            Thread.Sleep(2000);
        }

    }
}
