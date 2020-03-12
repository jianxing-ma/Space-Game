using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;


namespace Space_Game
{
    class Cursor
    {
        public static void WriteAt(string s, int x, int y, 
            ConsoleColor foreground = ConsoleColor.Gray, ConsoleColor background = ConsoleColor.Black)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = foreground;
                Console.BackgroundColor = background;
                Console.Write(s);
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteListAt<T>(List<T> ls, int x, int y, int align = 10,
        ConsoleColor foreground = ConsoleColor.Gray, ConsoleColor background = ConsoleColor.Black)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = foreground;
                Console.BackgroundColor = background;
                //Console.WriteLine($"{ls[0]}\t{ls[1]}") ; 
                for (int i = 0; i < ls.Count; i++)
                {
                    WriteAt(ls[i].ToString(), x + align * i, y);
                }
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        // Color list:   Black, Blue, Cyan, DarkBlue, DarkCyan, Gray, Green, Magenta, Red, White, Yellow, 
        //               DarkGray, DarkGreen, DarkMagenta, DarkRed, DarkYellow
        public static void WriteColorListAt<T>(List<T> ls, int x, int y,
            List<string> foreground,
            // Color list: Black, Blue, Cyan, DarkBlue, DarkCyan, DarkGray, DarkGreen, 
            int align = 10)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                //Console.WriteLine($"{ls[0]}\t{ls[1]}") ; 
                for (int i = 0; i < ls.Count; i++)
                {
                    WriteAt(ls[i].ToString(), x + align * i, y, (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreground[i]));
                }
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteTextAt(string filepath, int x = 0, int y = 0, ConsoleColor foreground = ConsoleColor.Gray)
        {
            //Display.ClearMapScreen();
            string[] text = File.ReadAllLines(filepath);
            for (int i = 0; i < text.Length; i++)
            {
                WriteAt(text[i], x, y + i, foreground);
            }
        }

        public static void WriteColorfulTextAt(string filepath, int x = 0, int y = 0)
        {
            //Display.ClearMapScreen();
            string[] text = File.ReadAllLines(filepath);
            for (int i = 0; i < text.Length; i++)
            {
                WriteAt(text[i], x, y + i, (ConsoleColor)new Random().Next(0, 16));
            }
        }

        public static void WriteLineAt(string s, int range, int x, int y)
        {
            try
            {
                for (int i = 0; i < range; i++)
                {
                    Console.SetCursorPosition(x + i, y);
                    Console.Write(s);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteColumnAt(string s, int range, int x, int y)
        {
            try
            {
                for (int i = 0; i < range; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(s);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        public static void WriteSquare(string s, int length, int width, int x, int y)
        {
            try
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.SetCursorPosition(x + i, y + j);
                        Console.Write(s);
                    }
                }
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



        public static void MoveCharacter(List<(int, int)> Boundaries = default, string s = "x")
        {
            Boundaries = Boundaries ?? new List<(int, int)>();
            Console.Write(s);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            try
            {
                Console.CursorVisible = false;
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Boundaries.Contains((Console.CursorLeft, Console.CursorTop - 1)))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(" ");
                            WriteAt(s, Console.CursorLeft -1, Console.CursorTop -1);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        if (Boundaries.Contains((Console.CursorLeft, Console.CursorTop + 1))) 
                        { 
                            break;
                        }
                        else
                        {
                            Console.Write(" ");
                            WriteAt(s, Console.CursorLeft - 1, Console.CursorTop + 1);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        if (Boundaries.Contains((Console.CursorLeft - 1, Console.CursorTop)))
                        {
                            break;
                        }
                        else 
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(s + " ");
                            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                            break; 
                        }
                    case ConsoleKey.RightArrow:
                        if (Boundaries.Contains((Console.CursorLeft + 1, Console.CursorTop)))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(" " + s);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            break;
                        }
                    // To be Modified - Jump to the next line
                    case ConsoleKey.Enter:
                        // if near Store cooridnate, call Store Method, recognize different stores, different store list
                        break;
                }
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Write("\b" + s);
            }
        }



        //public static void MoveCharacter(string s = "x")
        //{
        //    try
        //    {
        //        Console.CursorVisible = false;
        //        switch (Console.ReadKey(false).Key)
        //        {
        //            case ConsoleKey.UpArrow:
        //                WriteAt(s, Console.CursorLeft - 1, Console.CursorTop - 1);
        //                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        //                break;
        //            case ConsoleKey.DownArrow:
        //                WriteAt(s, Console.CursorLeft - 1, Console.CursorTop + 1);
        //                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        //                break;
        //            case ConsoleKey.LeftArrow:
        //                WriteAt(s, Console.CursorLeft - 2, Console.CursorTop);
        //                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        //                break;
        //            case ConsoleKey.RightArrow:
        //                Console.Write(s);
        //                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        //                break;
        //            case ConsoleKey.X:
        //                Console.Write(s);
        //                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        //                break;
        //            // To be Modified - Jump to the next line
        //            case ConsoleKey.Enter:
        //                Console.Write("\b");
        //                break;
        //        }
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        Console.Write("\b" + s);
        //    }
        //}

    }
}
