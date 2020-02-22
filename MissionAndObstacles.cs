using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class MissionAndObstacles
    {

        public static void EarthM()
        {
            if (Console.CursorLeft == 139 && Console.CursorTop == 17)
            {
                Vegeta planet = new Vegeta();
            }
            else if (Console.CursorLeft == 47 && Console.CursorTop == 24)
            {
                Console.Clear();
                    Console.WriteLine("\n\n\nCollected treasure...");
                    Console.Read();
                    Console.Clear();
                    int x = 47;
                    int y = 24;
                Earth earth = new Earth(x, y);

            }
            else if (Console.CursorLeft == 122 && Console.CursorTop == 27)
            {
                Console.Clear();
                    Console.WriteLine("\n\n\nCollected treasure...");
                    Console.Read();
                    //Earth.moa.Remove((122, 27));
                    Console.Clear();
                    int x = 122;
                    int y = 27;
                Earth earth = new Earth(x, y);
            

            }
            else if (Console.CursorLeft == 103 && Console.CursorTop == 18)
            {
                Console.Clear();
                Console.WriteLine(Earth.moa.Count);
                Console.WriteLine("This store 1 at grid (103, 18)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();

                int x = 103;
                int y = 18;
                Earth earth = new Earth(x, y);

            }
            else if (Console.CursorLeft == 97 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.WriteLine("This store 2 at grid (97, 20)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();

                int x = 97;
                int y = 20;
                Earth earth = new Earth(x, y);

            }
            else if (Console.CursorLeft == 96 && Console.CursorTop == 18)
            {
                Console.Clear();
                Console.WriteLine("This store 3 at grid (96, 18)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();

                int x = 96;
                int y = 18;
                Earth earth = new Earth(x, y);

            }
            else if (Console.CursorLeft == 112 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.WriteLine("This store 4 at grid (112, 20)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();
                int x = 112;
                int y = 20;
                Earth earth = new Earth(x, y);

            }
        }
        public static void VegetaM()
        {
            if (Console.CursorLeft == 88 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.WriteLine("Store at grid (88, 13)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();
                int x = 88;
                int y = 14;
                Vegeta vegeta = new Vegeta(x, y);

            }
            else if (Console.CursorLeft == 108 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.WriteLine("Store at grid (108, 13)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();
                int x = 108;
                int y = 14;
                Vegeta vegeta = new Vegeta(x, y);
            }
            else if (Console.CursorLeft == 88 && Console.CursorTop == 21)
            {
                Console.Clear();
                Console.WriteLine("Store at grid (88, 22)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear(); 
                int x = 88;
                int y = 21;
                Vegeta vegeta = new Vegeta(x, y);
            }
            else if (Console.CursorLeft == 108 && Console.CursorTop == 21)
            {
                Console.Clear();
                Console.WriteLine("Store at grid (108, 22)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();
                int x = 108;
                int y = 21;
                Vegeta vegeta = new Vegeta(x, y);
            }
            else if (Console.CursorLeft == 69 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.WriteLine("Store at grid (68, 17)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();
                int x = 69;
                int y = 17;
                Vegeta vegeta = new Vegeta(x, y);
            }
            else if (Console.CursorLeft == 117 && Console.CursorTop == 21)
            {
                Console.Clear();
                Console.WriteLine("Store at grid (118, 21)");
                Console.WriteLine("Press enter..");
                Console.Read();
                Console.Clear();
                int x = 117;
                int y = 21;
                Vegeta vegeta = new Vegeta(x, y);
            }
        }
        public static void AlphaM()
        {
            if (Console.CursorLeft == 94 && Console.CursorTop == 19)
            {
                Console.Clear();
                Console.Write("You found blah blah blah");
                Console.Read();
                Console.Clear();
                int x = 94;
                int y = 19;
                AlphaC alpha = new AlphaC(x, y);
            }else if (Console.CursorLeft == 76 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You enter store at grid (75, 17)");
                Console.Read();
                Console.Clear();
                int x = 76;
                int y = 17;
                AlphaC alpha = new AlphaC(x, y);
            }
            else if (Console.CursorLeft == 114 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You enter store at grid (115, 17)");
                Console.Read();
                Console.Clear();
                int x = 114;
                int y = 17;
                AlphaC alpha = new AlphaC(x, y);
            }
            else if (Console.CursorLeft == 95 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.Write("You enter store at grid (95, 13)");
                Console.Read();
                Console.Clear();
                int x = 95;
                int y = 14;
                AlphaC alpha = new AlphaC(x, y);
            }
            else if (Console.CursorLeft == 95 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.Write("You enter store at grid (95, 21)");
                Console.Read();
                Console.Clear();
                int x = 95;
                int y = 20;
                AlphaC alpha = new AlphaC(x, y);
            }
            else if (Console.CursorLeft == 86 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You enter store at grid (85, 17)");
                Console.Read();
                Console.Clear();
                int x = 84;
                int y = 17;
                AlphaC alpha = new AlphaC(x, y);
            }
            else if (Console.CursorLeft == 104 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You enter store at grid (105, 17)");
                Console.Read();
                Console.Clear();
                int x = 104;
                int y = 17;
                AlphaC alpha = new AlphaC(x, y);
            }
        }
    }
}
