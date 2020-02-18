﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Cursor
    {
        public static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void ClearArea(int x1, int x2, int y1, int y2)
        {
            Console.SetCursorPosition(x1, y1);
            for (int i = x1; i < x2 + 1; i++)
            {
                for (int j =y1; j < y2 + 1; j++)
                {
                    WriteAt(" ",i,j);
                }
            }
        }


        public static void WriteLineAt(string s, int range, int x, int y)
        {
            try
            {
                for (int i = 0; i <range; i++)
                {
                    Console.SetCursorPosition(x+i, y);
                    Console.Write(s);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void MoveCharacter()
        {
            try
            {
                Console.CursorVisible = false;
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                        Console.Write("x");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                        Console.Write("x");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                        Console.Write("x");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Write("x");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    case ConsoleKey.X:
                        Console.Write("x");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    // To be Modified - Jump to the next line
                    case ConsoleKey.Enter:
                        Console.Write("\b");
                        break;
                }
                //var xy = Tuple.Create(Console.CursorLeft, Console.CursorTop);
                //return xy;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Write("\bx");
            }
        }

        public static void MoveCharacterInMaps(List<(int,int)> Boundaries)
        {
            try
            {
                //Console.CursorVisible = false;
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Boundaries.Contains((Console.CursorLeft, Console.CursorTop - 1)))
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                            Console.Write("x");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        if (Boundaries.Contains((Console.CursorLeft, Console.CursorTop + 1)))
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop + 1);
                            Console.Write("x");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        if (Boundaries.Contains((Console.CursorLeft - 2, Console.CursorTop)))
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                        else 
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                            Console.Write("x");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break; 
                        }
                    case ConsoleKey.RightArrow:
                        if (Boundaries.Contains((Console.CursorLeft + 1, Console.CursorTop)))
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                        else
                        {
                            Console.Write("x");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.X:
                        Console.Write("x");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        break;
                    // To be Modified - Jump to the next line
                    case ConsoleKey.Enter:
                        Console.Write("\b");
                        break;
                }
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Write("\bx");
            }
        }


    }
}
