using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class AlphaC
    {
        public static List<(int, int)> aBound = new List<(int, int)>();
        public AlphaC(int x = 64, int y = 15)
        {
            Console.WriteLine("\t\t\t\tALPHA CENTAURI");
            AlphaMap();
            Console.SetCursorPosition(x, y);
            while(true)
            {
                Cursor.MoveCharacter(MapBound());
            }
        }


        private void AlphaMap()
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
            Fire();
            Stone();
            MissionAndObstacles();
        }
        private List<(int, int)> MapBound()
        {
            //Stone Boundaries
            for(int i = 63; i <= 120; i++)
            {
                aBound.Add((i, 10));
                aBound.Add((i, 24));
            }
            for (int i = 11; i <= 23; i++)
            {
                aBound.Add((63, i));
                aBound.Add((120, i));
            }
            for (int i = 16; i <= 18; i++)
            {
                aBound.Add((91, i));
                aBound.Add((97, i));
            }
            for (int i = 91; i <= 97; i++)
            {
                aBound.Add((i, 15));
                if (i == 91 || i == 92 || i == 93 || i == 95 || i == 96 || i == 97)
                {
                    aBound.Add((i, 19));
                }
            }
            //Fires Boundary
            aBound.Add((94, 18));
            //Mission and Obstacles Boundaries
            for (int i = 75; i <= 115; i += 4)
            {
                aBound.Add((i, 13));
                aBound.Add((i, 21));
                if (i == 95)
                {
                    //Store
                    aBound.Add((i, 13));
                    aBound.Add((i, 21));
                }
            }

            for (int i = 15; i <= 19; i += 2)
            {
                aBound.Add((75, i));
                aBound.Add((115, i));
                if (i == 17)
                {
                    //Store
                    aBound.Add((75, i));
                    aBound.Add((115, i));
                }
            }
            //Store
            aBound.Add((85, 17));
            aBound.Add((105, 17));
            //SpaceShip
            aBound.Add((64, 16));
            return aBound;
        }


        private void MissionAndObstacles()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 75; i <= 115; i += 4)
            {
                Console.SetCursorPosition(i, 13);
                Console.Write("H");
                Console.SetCursorPosition(i, 21);
                Console.Write("H");
                if (i == 95)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(i, 13);
                    Console.Write('S');
                    Console.SetCursorPosition(i, 21);
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }

            for (int i = 15; i <= 19; i += 2)
            {
                Console.SetCursorPosition(75, i);
                Console.Write("H");
                Console.SetCursorPosition(115, i);
                Console.Write("H");
                if (i == 17)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(75, i);
                    Console.Write('S');
                    Console.SetCursorPosition(115, i);
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(85, 17);
            Console.Write('S');
            Console.SetCursorPosition(105, 17);
            Console.Write('S');
            Console.ResetColor();
            //SpaceShip
            Console.SetCursorPosition(64, 16);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write((char)0x25B2);
            Console.ResetColor();
        }

        private void Stone()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (int i = 42; i <= 141; i++)
            {
                Console.SetCursorPosition(i, 10);
                Console.Write(" ");
                Console.SetCursorPosition(i, 24);
                Console.Write(" ");
            }
            for (int i = 11; i <= 23; i++)
            {
                Console.SetCursorPosition(63, i);
                Console.Write(" ");
                Console.SetCursorPosition(120, i);
                Console.Write(" ");
            }
            for (int i = 16; i <= 18; i++)
            {
                Console.SetCursorPosition(91, i);
                Console.Write(" ");
                Console.SetCursorPosition(97, i);
                Console.Write(" ");
            }
            for (int i = 91; i <= 97; i++)
            {
                Console.SetCursorPosition(i, 15);
                Console.Write(" ");
                if (i == 91 || i == 92 || i == 93)
                {
                    Console.SetCursorPosition(i, 19);
                    Console.Write(" ");
                }
            }
            for (int i = 95; i <= 97; i++)
            {
                Console.SetCursorPosition(i, 19);
                Console.Write(" ");
            }
            Console.ResetColor();
        }

        private void Fire()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            for (int i = 42; i <= 141; i++)
            {
                for (int j = 5; j <= 9; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                } 
                for (int j = 25; j <= 29; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }
            }
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 11; i <= 23; i++)
            {
                for (int j = 42; j <= 62; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                }
                for (int j = 121; j <= 141; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" "); 
                }
            }
            for (int i = 16; i <= 18; i++)
            {
                for (int j = 92; j <= 96; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                }
            }
            Console.ResetColor();
            Console.SetCursorPosition(94, 17);
            Console.Write(" ");
            
        }
    }
}
