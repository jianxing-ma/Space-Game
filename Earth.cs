using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class Earth
    {

        public Earth()
        {
            Console.WriteLine("\t\t\t\t\t\tEARTH");
            EarthMap();
        }


        private void EarthMap()
        {
            char b = '=';
            char s = '|';
            char t = 't';
            char w = 'w';
            char r = 'r';
            Console.ForegroundColor = ConsoleColor.Red;
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

            Trees(t);

            Water(w);

            Dirt(r);

            Console.Read();
            Console.WriteLine("\ndone");
        }

        private static void Dirt(char r)
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