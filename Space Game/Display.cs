using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace Space_Game
{
    class Display
    {
        public static int Sx1 = 0, Sx2 = Console.WindowWidth, Sy1 = 0, Sy2 = 30, Sy3 = 39;    // 9 , 150, | 4, 35, 41

        public static void Screen()
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {               
                Cursor.WriteAt(" ", i, Sy2, ConsoleColor.Gray, ConsoleColor.DarkGray);               
            }
        }

        public static void ClearMapScreen()
        {
            Cursor.ClearArea(0, Sx2 - 1, 0, Sy2 - 1);
            Console.SetCursorPosition(0, 0);
        }
        public static void ClearMenuScreen()
        {
            Cursor.ClearArea(0, Sx2 - 1, Sy2 + 1, Sy3);
        }
        public static void ClearMenu()
        {
            Cursor.ClearArea(0, Display.Sx2 - 1, Display.Sy2 + 1, Display.Sy3 - 1);
        }

        public static List<(int, int)> ScreenBoudaries()
        {
            List<(int, int)> Boundaries = new List<(int, int)>();

            for (int i = -1; i < Sx2 + 1; i++)
            {
                Boundaries.Add((i, -1));
                Boundaries.Add((i, Sy2));
            }
            for (int i = 0; i < Sy2; i++)
            {
                Boundaries.Add((-1, i));
                Boundaries.Add((Sx2, i));

            }
            return Boundaries;
        }

        public static void Intro()
        {
            // Welcome
            string[] welcome = File.ReadAllLines(@"Text\Welcome.txt");
            Console.SetCursorPosition(0, 3);
            foreach (string line in welcome)
            {
                Console.CursorVisible = false;              
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(line);
                Thread.Sleep(150);
            }

            // Ask for name and gender?

            // Intro  
            Console.SetCursorPosition(0, 12);
            string intro = File.ReadAllText(@"Text\Intro.txt");
            foreach (char i in intro)
            {                               
                Console.ForegroundColor = ConsoleColor.DarkMagenta;  //(ConsoleColor)new Random().Next(7, 16)
                Console.Write(i);
                //Thread.Sleep(50);
            }
            // Bonus 1
            Thread.Sleep(3000);
            ClearMapScreen();
            Console.SetCursorPosition(0, 12);
            string[] bonus1 = File.ReadAllLines(@"Text\bonus1.txt");
            foreach (string line in bonus1)
            {
                Console.ForegroundColor = (ConsoleColor)new Random().Next(7, 16);
                Console.WriteLine(line);
                Thread.Sleep(150);
            }
            // Bonus 2
            Thread.Sleep(3000);
            ClearMapScreen();
            Console.SetCursorPosition(0, 12);
            string[] bonus2 = File.ReadAllLines(@"Text\bonus2.txt");
            foreach (string line in bonus2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(line);
                Thread.Sleep(150);
            }
            // Bonus 3
            Thread.Sleep(3000);
            ClearMapScreen();
            Console.SetCursorPosition(0, 12);
            string[] bonus3 = File.ReadAllLines(@"Text\bonus3.txt");
            foreach (string line in bonus3)
            {
                Console.ForegroundColor = (ConsoleColor)new Random().Next(7, 16);
                Console.WriteLine(line);
                Thread.Sleep(150);
            }

            Console.ResetColor();
        }

        public static void ScreenArt(string filepath, ConsoleColor color, int x = 0, int y = 10)
        {
            ClearMapScreen();
            Console.SetCursorPosition(x, y);
            string[] text = File.ReadAllLines(filepath);
            foreach (string line in text)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(line);
                Thread.Sleep(150);
            }
            Console.ResetColor();
        }
        public static void ScreenArt(string filepath, int x = 0, int y = 10)
        {
            ClearMapScreen();
            Console.SetCursorPosition(x, y);
            string[] text = File.ReadAllLines(filepath);
            foreach (string line in text)
            {
                Console.ForegroundColor = (ConsoleColor)new Random().Next(7, 16);
                Console.WriteLine(line);
                Thread.Sleep(150);
            }
            Console.ResetColor();
        }

        
        public static void UniverseMap()
        {
            // Print random stars as background
            Random rnd = new Random();
            for (int i = 0; i < Sx2; i += 5)
            {
                for (int j = 0; j < Sy2; j += 5)
                {
                    Cursor.WriteAt("*", rnd.Next(i, i + 5), rnd.Next(j, j + 5));
                }
            }

            // Print Planets
            var PlanetLocation = new List<(string color, (int x, int y) coord)> { ("Blue", (70, 15)), ("Red",(40,10)),
                ("Cyan",(50,28)),("Green",(120,10)),("Magenta",(110,25))};

            foreach (var item in PlanetLocation)
            {
                //Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), item.color);
                Cursor.WriteAt("*", item.coord.x, item.coord.y, (ConsoleColor)Enum.Parse(typeof(ConsoleColor), item.color));
            }

            // Print Spaceship
            Console.SetCursorPosition(71, 15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine((char)0x25B2);
            Console.ResetColor();
        }

 



    }
}
