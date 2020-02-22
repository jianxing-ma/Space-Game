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
                    Console.Read();using System;
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
        public static void NamekM()
        {
            if (Console.CursorLeft == 58 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.Write("You enter store at grid (58, 13)");
                Console.Read();
                Console.Clear();
                int x = 58;
                int y = 14;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 62 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.Write("You enter store at grid (62, 13)");
                Console.Read();
                Console.Clear();
                int x = 62;
                int y = 14;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 62 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.Write("You enter store at grid (62, 21)");
                Console.Read();
                Console.Clear();
                int x = 62;
                int y = 20;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 58 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.Write("You enter store at grid (58, 21)");
                Console.Read();
                Console.Clear();
                int x = 58;
                int y = 20;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 51 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You enter store at grid (50, 17)");
                Console.Read();
                Console.Clear();
                int x = 51;
                int y = 17;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft ==69 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You enter store at grid (70, 17)");
                Console.Read();
                Console.Clear();
                int x = 69;
                int y = 17;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 114 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You enter store at grid (113, 17)");
                Console.Read();
                Console.Clear();
                int x = 114;
                int y = 17;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 132 && Console.CursorTop == 17)
            {
                Console.Clear();
                Console.Write("You enter store at grid (133, 17)");
                Console.Read();
                Console.Clear();
                int x = 132;
                int y = 17;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 121 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.Write("You enter store at grid (121, 13)");
                Console.Read();
                Console.Clear();
                int x = 121;
                int y = 14;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 121 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.Write("You enter store at grid (121, 21)");
                Console.Read();
                Console.Clear();
                int x = 121;
                int y = 20;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 125 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.Write("You enter store at grid (125, 13)");
                Console.Read();
                Console.Clear();
                int x = 125;
                int y = 14;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 125 && Console.CursorTop == 20)
            {
                Console.Clear();
                Console.Write("You enter store at grid (125, 21)");
                Console.Read();
                Console.Clear();
                int x = 125;
                int y = 20;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 93 && Console.CursorTop == 14 || Console.CursorLeft == 92 && Console.CursorTop == 14 || Console.CursorLeft == 91 && Console.CursorTop == 14)
            {
                Console.Clear();
                Console.Write("You were caught in Frieza's ship and hit with a lazer.\n\n YOU DIED!!");
                Console.Read();
                Environment.Exit(0);
            }
            else if (Console.CursorLeft == 93 && Console.CursorTop == 15 || Console.CursorLeft == 92 && Console.CursorTop == 15 || Console.CursorLeft == 91 && Console.CursorTop == 15)
            {
                Console.Clear();
                Console.Write("You obtained a dragon ball. This item is priceless.\n\nBy the way this is Frieza's ship be careful...");
                Console.Read();
                Console.Clear();
                int x = 93;
                int y = 16;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 89 && Console.CursorTop == 20 || Console.CursorLeft == 96 && Console.CursorTop == 13)
            {
                Console.Clear();
                Console.Write("You were hit by a random Special Beam Cannon. \n\nCONGRATS BUD...");
                Console.Read();
                Environment.Exit(0);
            }
            else if (Console.CursorLeft == 60 && Console.CursorTop == 18)
            {
                Console.Clear();
                Console.Write("YOU TELEPORTED, WOAH!!!");
                Console.Read();
                Console.Clear();
                int x = 123;
                int y = 18;
                Namek namek = new Namek(x, y);
            }
            else if (Console.CursorLeft == 123 && Console.CursorTop == 18)
            {
                Console.Clear();
                Console.Write("YOU TELEPORTED, WOAH!!!");
                Console.Read();
                Console.Clear();
                int x = 60;
                int y = 18;
                Namek namek = new Namek(x, y);
            }
        }
    }
}

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
