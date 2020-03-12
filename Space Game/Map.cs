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

//____________________________________________INITIALIZE PLANET AND DISPLAY PLANET_____________________________________________

        public static List<List<(int, int)>> InitializePlanet(string file, List<List<(int, int)>> terrain)
        {
            // terrain: 0: boundaries | 1: Store | 2: Spaceship/Exit | 3: Gold | 4: Bandits | 5: Maze | 6: Ningja
            // Refer to Planet.cs Line 31 for creating the terrains;
            terrain[0] = Display.ScreenBoudaries();
            StreamReader reader = new StreamReader(file);

            var landing = new List<int>();

            Console.SetCursorPosition(0, 0);
            while (reader.Peek() >= 0)
            {
                char i = (char)reader.Read();
                switch (i)                   // Include all the terrain features, stored in a List<List<(int,int)>>
                {                           
                    //case 't':
                    //    terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                    //    Console.ForegroundColor = ConsoleColor.Green;
                    //    Console.Write(i);
                    //    break;
                    //case 'w':
                    //    terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                    //    Console.ForegroundColor = ConsoleColor.Blue;
                    //    Console.Write(i);
                    //    break;
                    //case 'r':
                    //    terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                    //    Console.ForegroundColor = ConsoleColor.Gray;
                    //    Console.Write(i);
                    //    break;
                    //case 'H':
                    //    terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                    //    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    //    Console.Write(i);
                    //    break;
                   //------------------------------Functional Letters begin here----------------------------------
                    case 'S':
                        terrain[1].Add((Console.CursorLeft, Console.CursorTop));
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(i);
                        Console.ResetColor();
                        break;
                    case 'X':
                        terrain[2].Add((Console.CursorLeft, Console.CursorTop));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(i);
                        Console.ResetColor();
                        landing.Add(Console.CursorLeft); landing.Add(Console.CursorTop);
                        break;
                    case 'G':
                        terrain[3].Add((Console.CursorLeft, Console.CursorTop));
                        Console.Write(" ");
                        break;
                    case 'B':
                        terrain[4].Add((Console.CursorLeft, Console.CursorTop));
                        Console.Write(" ");
                        break;
                    case 'M':
                        terrain[5].Add((Console.CursorLeft, Console.CursorTop));
                        Console.Write(" ");
                        break;
                    case 'N':
                        terrain[6].Add((Console.CursorLeft, Console.CursorTop));
                        Console.Write(" ");
                        break;
                    case ' ':
                        Console.Write(" ");
                        break;
                    default:
                        terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                        Cursor.WriteAt(i.ToString(), Console.CursorLeft, Console.CursorTop, (ConsoleColor)new Random().Next(1, 16));
                        break;
                }
            }
            reader.Close(); reader.Dispose();
            Console.ResetColor();
            Console.SetCursorPosition(landing[0], landing[1]);
            return terrain;
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
                    //case 't':
                    //    Console.ForegroundColor = ConsoleColor.Green;
                    //    Console.Write(i);
                    //    break;
                    //case 'w':
                    //    Console.ForegroundColor = ConsoleColor.Blue;
                    //    Console.Write(i);
                    //    break;
                    //case 'r':
                    //    Console.ForegroundColor = ConsoleColor.Gray;
                    //    Console.Write(i);
                    //    break;
                    //case 'H':
                    //    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    //    Console.Write(i);
                    //    break;
                    //-------------------------------------Functional letters Begin here-------------------------------------
                    case 'S':
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(i);
                        Console.ResetColor();
                        break;
                    case 'X':
                        landing.Add(Console.CursorLeft); landing.Add(Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(i);
                        break;
                    case 'G':
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(i);
                        Console.ResetColor();
                        break;                   
                    default:
                        Cursor.WriteAt(i.ToString(),Console.CursorLeft,Console.CursorTop, (ConsoleColor)new Random().Next(1, 16));
                        break;
                }
            }
            reader.Close(); reader.Dispose();
            Console.ResetColor();
            Console.SetCursorPosition(landing[0] + 1, landing[1]);
        }


        public static List<List<(int, int)>> InitializeMaze(string filepath, List<List<(int, int)>> terrain)
        {
            terrain[0] = Display.ScreenBoudaries();         //  Maze terrain ( 0: Boundaries | 1: Entrance | 2: Exit ) 
            var entrance = new List<int>();
            string maze = File.ReadAllText(filepath);
            Console.SetCursorPosition(0, 0);
            foreach (char i in maze)                
            {
                if (i == ' ')
                {
                    Console.Write(i);
                }
                else if (i == 'E')
                {
                    terrain[1].Add((Console.CursorLeft, Console.CursorTop));
                    entrance.Add(Console.CursorLeft); entrance.Add(Console.CursorTop);
                    Console.Write(' ');
                }
                else if (i == 'X')
                {
                    terrain[2].Add((Console.CursorLeft, Console.CursorTop));
                    Console.Write(i);
                }
                else
                {
                    terrain[0].Add((Console.CursorLeft, Console.CursorTop));
                    Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
                    Console.Write(i);
                }
            }
            Console.SetCursorPosition(entrance[0], entrance[1]);
            //Console.SetCursorPosition(21, 3);
            Console.ResetColor();
            return terrain;
        }

    }
}
