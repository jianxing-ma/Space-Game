using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Cursor
    {
        public void WriteAt(string s, int x, int y)
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


        public void WriteLineAt(string s, int range, int x, int y)
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

        public void MoveCharacter()
        {
            try
            {
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

                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Write("\bx");
            }
        }



    }
}
