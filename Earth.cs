using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class Earth
    {
        public static List<(int, int)> eBound = new List<(int, int)>();
        public static List<(int, int)> moa = new List<(int, int)>();
        public Earth(int x = 42, int y = 5)
        {

            Console.WriteLine("\t\t\t\t\t\tEARTH");
            EarthMap();
            Console.SetCursorPosition(x, y);
            do
            {
                Cursor.MoveCharacter(MapBound());
            } while(true);
        }


        public static void EarthMap()
        {

            char b = ' ';
            char s = ' ';
            char t = 't';
            char w = 'w';
            char r = 'r';
            char H = 'H';
            Console.BackgroundColor = ConsoleColor.Red;
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
            //Stats will go here in a different class

            Console.WriteLine("\n\ndone");

            Trees(t);

            Water(w);

            Rock(r);

            MissionAndObstaclesEarth(H);

           // Console.Read();
        }

        private List<(int, int)> MOA()
        {
            moa.Add((139, 17));
            moa.Add((47, 24));
            moa.Add((122, 27));
            return moa;
        }

        private List<(int, int)> MapBound()
        {
            //Screen Boundaries
            for (int i = 41; i <= 141; i++)
            {
                eBound.Add((i, 4));
                eBound.Add((i, 30));
            }
            for (int i = 4; i <= 30; i++)
            {
                eBound.Add((41, i));
                eBound.Add((142, i));
            }
            //Rock Boundaries
            for (int i = 5; i <= 10; i++)
            {
                eBound.Add((103, i));
            }
            for (int i = 11; i <= 12; i++)
            {
                eBound.Add((115, i));
            }
            for (int i = 13; i <= 16; i++)
            {
                eBound.Add((123, i));
            }
            for (int i = 104; i <= 114; i++)
            {
                eBound.Add((i, 10));
            }
            for (int i = 116; i <= 122; i++)
            {
                eBound.Add((i, 12));
            }
            for (int i = 124; i <= 141; i++)
            {
                eBound.Add((i, 16));
            }
            for (int i = 124; i <= 141; i++)
            {
                eBound.Add((i, 18));
            }
            for (int i = 19; i <= 29; i++)
            {
                eBound.Add((124, i));
            }
            //Trees Boundary
            for (int i = 5; i <= 8; i++)
            {
                eBound.Add((44, i));
                eBound.Add((100, i));
                if (i == 8)
                {
                    for (int j = 45; j <= 100; j++)
                    {
                        eBound.Add((j, 8));
                    }
                }
            }
            for (int i = 16; i <= 29; i++)
            {
                if (i >= 16 && i <= 20)
                {
                    for (int j = 42; j <= 90; j++)
                    {
                        eBound.Add((j, i));
                    }
                }
                else if (i >= 21 && i <= 22)
                {
                    for (int j = 42; j <= 45; j++)
                    {
                        eBound.Add((j, i));
                    }
                }
                else if (i >= 23 && i <= 25)
                {
                    for (int j = 42; j <= 45; j++)
                    {
                        eBound.Add((j, i));

                    }
                    for (int j = 49; j <= 121; j++)
                    {
                        eBound.Add((j, i));

                    }
                }
                else if (i <= 29)
                {
                    for (int j = 42; j <= 120; j++)
                    {
                        eBound.Add((j, i));
                    }
                }
            }
            //Water Boundary
            for (int i = 42; i <= 80; i++)
            {
                eBound.Add((i, 10));
                eBound.Add((i + 15, 11));
                eBound.Add((i + 20, 12));
                eBound.Add((i + 25, 13));
                eBound.Add((i + 20, 14));
                eBound.Add((i + 15, 15));
                eBound.Add((i, 16));
            }
            //Mission and Obstacles
            for (int i = 95; i <= 107; i += 2)
            {
                eBound.Add((i, 17));
            }
            for (int i = 95; i <= 112; i += 2)
            {
                eBound.Add((i, 21));
            }
            for(int i = 17; i <= 21; i++)
            {
                eBound.Add((95, i));
                eBound.Add((113, i));
            }
            //Space Ship
            eBound.Add((140, 17));
            //Treasure
            eBound.Add((47, 25));
            eBound.Add((122, 28));

            return eBound;
        }

        private static void MissionAndObstaclesEarth(char H)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(47, 25);
            Console.Write(" "); 
            Console.SetCursorPosition(122, 28);
            Console.Write(" ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int j = 95; j <= 107; j += 2)
            {
                Console.SetCursorPosition(j, 17);
                Console.Write(H);
                 if (j == 103)
                 {
                 Console.SetCursorPosition(j, 17);
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.Write('S');
                 Console.ForegroundColor = ConsoleColor.DarkCyan;

                }
            }
            for (int j = 95; j <= 112; j += 2)
            {
                Console.SetCursorPosition(j, 21);
                Console.Write(H);
                if (j == 97)
                {
                    Console.SetCursorPosition(j, 21);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            for (int j = 17; j <= 21; j ++)
            {
                Console.SetCursorPosition(95, j);
                Console.Write(H);
                if (j == 18)
                {
                    Console.SetCursorPosition(95, j);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            for (int j = 17; j <= 21; j ++)
            {
                Console.SetCursorPosition(113, j);
                Console.Write(H);
                if (j == 20)
                {
                    Console.SetCursorPosition(113, j);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write('S');
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            Console.ResetColor();

            Console.SetCursorPosition(140, 17);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write((char)0x25B2);
            Console.ResetColor();

        }

        private static void Rock(char r)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 5; i <= 16; i++)
            {
                
                if (i <= 10)
                {
                    for (int j = 103; j <= 141; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(r);

                    }
                }
                else if (i <= 12)
                {
                    for (int j = 115; j <= 141; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(r);
                    }
                }
                else if (i <= 16)
                {
                    for (int j = 123; j <= 141; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(r);
                    }
                }
                if (i == 16)
                {
                    for (int j = 42; j <= 80; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(r);
                    }
                }
            }
            for (int j = 125; j <= 141; j++)
            {
                Console.SetCursorPosition(j, 18);
                Console.Write(r);
            }
            for (int i = 18; i <= 29; i++)
            {
                Console.SetCursorPosition(124, i);
                Console.Write(r);
            }
            Console.ResetColor();
        }

        private static void Trees(char t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 5; i <= 8; i++)
            {
                for (int a = 44; a <= 100; a++)
                {
                    Console.SetCursorPosition(a, i);
                    Console.Write(t);
                }

            }
            for (int i = 16; i <= 29; i++)
            {
                if (i >= 16 && i <= 20)
                {
                    for (int j = 42; j <= 90; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(t);
                    }
                }else if (i >= 21 && i<= 22)
                {
                    for (int j = 42; j <= 45; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(t);
                    }
                }else if (i >= 23 && i <= 25)
                {
                    for (int j = 42; j <= 45; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(t);

                    }for (int j = 49; j <= 121; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(t);

                    }
                }else if (i <= 29)
                {
                    for (int j = 42; j <= 120; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(t);
                    }
                }

            }
            Console.ResetColor();
        }

        private static void Water(char w)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 10; i <= 16; i++)
            {
                for (int c = 42; c <= 80; c++)
                {
                    Console.SetCursorPosition(c, i);
                    Console.Write(w);
                    if (i == 11)
                    {
                        Console.SetCursorPosition(c + 15, i);
                        Console.Write(w);
                    }
                    else if (i == 12)
                    {
                        Console.SetCursorPosition(c + 20, i);
                        Console.Write(w);
                    }
                    else if (i == 13)
                    {
                        Console.SetCursorPosition(c + 25, i);
                        Console.Write(w);
                    }
                    else if (i == 14)
                    {
                        Console.SetCursorPosition(c + 20, i);
                        Console.Write(w);
                    }
                    else if (i == 15)
                    {
                        Console.SetCursorPosition(c + 15, i);
                        Console.Write(w);
                    }
                }
            }
            for (int i = 19; i <= 29; i++)
            {
                for (int j = 125; j <= 141; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(w);
                }
            }
            Console.ResetColor();
        }
    }
}
