using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Space_Game
{
    class Map
    {


        public string filepath;        
        public Map(string filepath)
        {
            this.filepath = filepath;
        }


        public static void Planet(string file)
        {
            StreamReader reader = new StreamReader(file);

            var landing = new List<int>();

            Console.SetCursorPosition(0, 0);
            while (reader.Peek() >= 0)
            {
                char i = (char)reader.Read();
                switch (i)
                {
                    case 't':
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(i);
                        break;
                    case 'w':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(i);
                        break;
                    case 'r':
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(i);
                        break;
                    case 'H':
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(i);
                        break;
                    case 'S':
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(i);
                        Console.ResetColor();
                        break;
                    case 'G':
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(i);
                        Console.ResetColor();
                        break;
                    case 'X':
                        landing.Add(Console.CursorLeft); landing.Add(Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(i);
                        break;
                    default:
                        Console.ResetColor();
                        Console.Write(i);
                        break;
                }
            }
            reader.Close(); reader.Dispose();
            Console.ResetColor();
            Console.SetCursorPosition(landing[0] + 1, landing[1]);
        }


        public static List<List<(int, int)>> InitializePlanet(string file, List<List<(int, int)>> terrain)
        {
            terrain[0] = Display.ScreenBoudaries();
            StreamReader reader = new StreamReader(file);

            var landing = new List<int>();

            Console.SetCursorPosition(0, 0);
            while (reader.Peek() >= 0)
            {
                char i = (char)reader.Read();
                switch (i)
                {
                    case 't':
                        terrain[0].Add((Console.CursorLeft,Console.CursorTop));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(i);
                        break;
                    case 'w':
                        terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(i);
                        break;
                    case 'r':
                        terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(i);
                        break;
                    case 'H':
                        terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(i);
                        break;
                    case 'S':
                        terrain[1].Add((Console.CursorLeft, Console.CursorTop));
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(i);
                        Console.ResetColor();
                        break;
                    case 'G':
                        terrain[3].Add((Console.CursorLeft, Console.CursorTop));
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(i);
                        Console.ResetColor();
                        break;
                    case 'X':
                        terrain[2].Add((Console.CursorLeft, Console.CursorTop));                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(i);
                        landing.Add(Console.CursorLeft); landing.Add(Console.CursorTop);
                        break;
                    default:
                        Console.ResetColor();
                        Console.Write(i);
                        break;
                }
            }
            reader.Close(); reader.Dispose();
            Console.ResetColor();
            Console.SetCursorPosition(landing[0], landing[1]);
            return terrain;
        }


    }
}
