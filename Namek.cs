using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class Namek
    {
        public static List<(int, int)> nBound = new List<(int, int)>();
        public Namek(int x = 93, int y = 20)
        {
            Console.WriteLine("\t\t\t\tNAMEK");
            NamekMap();
            Console.SetCursorPosition(x, y);
            while(true)
            {
                Cursor.MoveCharacter(MapBound());
            }
        }


        private void NamekMap()
        {
            char b = ' ';
            char s = ' ';
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(41, 4);
            for (int i = 0; i <= 100; i++)
            {
                Console.Write(b);
            }

            for (int j = 4; j <= 30; j++)
            {

                Console.SetCursorPosition(41, j);
                Console.Write(s);
            }

            for (int a = 4; a <= 30; a++)
            {
                Console.SetCursorPosition(142, a);

                Console.WriteLine(s);
            }

            Console.SetCursorPosition(42, 30);
            for (int j = 0; j <= 99; j++)
            {

                Console.Write(b);
            }
            Console.ResetColor();
            Grass();
            Water();
            Sand();
            MissionAndObstacles();
        }
        private List<(int, int)> MapBound()
        {
            //Sand
            for (int i = 48; i <= 135; i++)
            {
                nBound.Add((i, 11));
                nBound.Add((i, 23));
            }
            for (int i = 12; i <= 22; i++)
            {
                nBound.Add((48, i));
                nBound.Add((135, i));
            }
            //Mission And Obstacles
            for (int i = 50; i <= 70; i += 2)
            {
                nBound.Add((i, 13));
                nBound.Add((i, 21));
                if (i == 58 || i == 62)
                {
                    nBound.Add((i, 13));
                    nBound.Add((i, 21));
                }
            }
            for (int i = 15; i <= 19; i += 2)
            {
                nBound.Add((50, i));
                nBound.Add((70, i));
                if (i == 17)
                {
                    nBound.Add((50, i));
                    nBound.Add((70, i));
                }
            }
            for (int i = 113; i <= 133; i += 2)
            {
                nBound.Add((i, 13));
                nBound.Add((i, 21));
                if (i == 121 || i == 125)
                {
                    nBound.Add((i, 13));
                    nBound.Add((i, 21));
                }
            }
            for (int i = 15; i <= 19; i += 2)
            {
                nBound.Add((113, i));
                nBound.Add((133, i));
                if (i == 17)
                {
                    nBound.Add((113, i));
                    nBound.Add((133, i));
                }
            }
            for (int i = 90; i <= 94; i++)
            {
                nBound.Add((i, 13));
            }
            for (int i = 14; i <= 15; i++)
            {
                nBound.Add((90, i));
                nBound.Add((94, i));
            }
            //SpaceShip
            nBound.Add((93, 19));
            //Namekians
            nBound.Add((89, 21));
            nBound.Add((96, 12));
            //Teleport
            nBound.Add((60, 17));
            nBound.Add((123, 17));
            return nBound;
        }

        private void MissionAndObstacles()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 50; i <= 70; i += 2)
            {
                Console.SetCursorPosition(i, 13);
                Console.Write('H');
                Console.SetCursorPosition(i, 21);
                Console.Write('H');
                if (i == 58 || i == 62)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(i, 13);
                    Console.Write('S');
                    Console.SetCursorPosition(i, 21);
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            for (int i = 15; i <= 19; i += 2)
            {
                Console.SetCursorPosition(50, i);
                Console.Write('H');
                Console.SetCursorPosition(70, i);
                Console.Write('H');
                Console.SetCursorPosition(113, i);
                Console.Write('H');
                Console.SetCursorPosition(133, i);
                Console.Write('H');
                if (i == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(50, i);
                    Console.Write('S');
                    Console.SetCursorPosition(70, i);
                    Console.Write('S');
                    Console.SetCursorPosition(113, i);
                    Console.Write('S');
                    Console.SetCursorPosition(133, i);
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            for (int i = 113; i <= 133; i += 2)
            {
                Console.SetCursorPosition(i, 13);
                Console.Write('H');
                Console.SetCursorPosition(i, 21);
                Console.Write('H');
                if (i == 121 || i == 125)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(i, 13);
                    Console.Write('S');
                    Console.SetCursorPosition(i, 21);
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }

            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (int i = 90; i <= 94; i++)
            {
                Console.SetCursorPosition(i, 13);
                Console.Write(' ');
            }
            for (int i = 14; i <= 15; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.Write(' ');
                Console.SetCursorPosition(94, i);
                Console.Write(' ');
            }
            Console.ResetColor();
            //Namekians
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(89, 21);
            Console.Write(' ');
            Console.SetCursorPosition(96, 12);
            Console.Write(' ');
            //TelePort
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(60, 17);
            Console.Write(' ');
            Console.SetCursorPosition(123, 17);
            Console.Write(' ');
            Console.ResetColor();
            //SpaceShip
            Console.SetCursorPosition(93, 19);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write((char)0x25B2);
            Console.ResetColor();
        }

        private void Sand()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            for (int i = 48; i <= 135; i++)
            {
                Console.SetCursorPosition(i, 11);
                Console.Write(' ');
                Console.SetCursorPosition(i, 23);
                Console.Write(' ');
            }
            for (int i = 12; i <= 22; i++)
            {
                Console.SetCursorPosition(48, i);
                Console.Write(' ');
                Console.SetCursorPosition(135, i);
                Console.Write(' ');
            }
            Console.ResetColor();
        }

        private void Water()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 46; i <= 137; i += 2)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write(' ');
                Console.SetCursorPosition(i, 26);
                Console.Write(' ');
            }
            for (int i = 9; i <= 26; i += 2)
            {
                Console.SetCursorPosition(45, i);
                Console.Write(' ');
                Console.SetCursorPosition(138, i);
                Console.Write(' ');
            }
            for (int i = 45; i <= 138; i += 2)
            {
                Console.SetCursorPosition(i, 9);
                Console.Write(' ');
                Console.SetCursorPosition(i, 25);
                Console.Write(' ');
            }
            for (int i = 8; i <= 26; i += 2)
            {
                Console.SetCursorPosition(46, i);
                Console.Write(' ');
                Console.SetCursorPosition(137, i);
                Console.Write(' ');
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int i = 45; i <= 138; i += 2)
            {
                Console.SetCursorPosition(i, 8);
                Console.Write(' ');
                Console.SetCursorPosition(i, 26);
                Console.Write(' ');
            }
            for (int i = 8; i <= 26; i += 2)
            {
                Console.SetCursorPosition(45, i);
                Console.Write(' ');
                Console.SetCursorPosition(138, i);
                Console.Write(' ');
            }
            for (int i = 46; i <= 137; i += 2)
            {
                Console.SetCursorPosition(i, 9);
                Console.Write(' ');
                Console.SetCursorPosition(i, 25);
                Console.Write(' ');
            }
            for (int i = 9; i <= 26; i += 2)
            {
                Console.SetCursorPosition(46, i);
                Console.Write(' ');
                Console.SetCursorPosition(137, i);
                Console.Write(' ');
            }
            Console.ResetColor();
        }

        private void Grass()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            for (int i = 42; i <= 141; i++)
            {
                for (int j = 5; j <= 7; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(' ');
                }
                Console.SetCursorPosition(i, 10);
                Console.Write(' ');
                for (int a = 27; a <= 29; a++)
                {
                    Console.SetCursorPosition(i, a);
                    Console.Write(' ');
                }
                Console.SetCursorPosition(i, 24);
                Console.Write(' ');
            }
            for (int i = 5; i <= 29; i++)
            {
                for (int j = 42; j <= 44; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(' ');
                }
                Console.SetCursorPosition(47, i);
                Console.Write(' ');
                for (int a = 139; a <= 141; a++)
                {
                    Console.SetCursorPosition(a, i);
                    Console.Write(' ');
                }
                Console.SetCursorPosition(136, i);
                Console.Write(' ');
            }
            Console.ResetColor();
        }
    }
}
