using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceAdventure
{
    public class Vegeta
    {
        public Vegeta()
        {
            Console.WriteLine("\t\t\t\t WELCOME TO VEGETA");
            VegetaMap();

        }

        private void VegetaMap()
        {
            char b = ' ';
            char s = ' ';
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

            Grass();

            Water();

            MissionObstacles();
            Console.Read();
        }

        private void MissionObstacles()
        {
            char hut = 'H';

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 68; i <= 118; i += 4)
            {
                Console.SetCursorPosition(i, 13);
                Console.Write(hut);

                Console.SetCursorPosition(i, 22);
                Console.Write(hut);
            }
            for (int i = 15; i <= 21; i += 2)
            {
                Console.SetCursorPosition(68, i);
                Console.Write(hut);

                Console.SetCursorPosition(118, i);
                Console.Write(hut);
            }
            Console.ResetColor();

            Console.SetCursorPosition(122, 23);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write((char)0x25B2);
            Console.ResetColor();

        }

        private void Water()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int j = 70; j <= 115; j++)
            {
                for (int i = 15; i <= 20; i++)
                {

                    Console.SetCursorPosition(j, i);
                    Console.Write(' ');
                }
            }
            Console.ResetColor();
        }
        private void Grass()
        {
            char grass = 'g';
            Console.ForegroundColor = ConsoleColor.Green;
            for (int j = 42; j <= 141; j++)
            {
                for (int i = 5; i <= 9; i++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(grass);
                }
                for (int i = 25; i <= 29; i++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(grass);
                }
            }
            for (int j = 9; j <= 25; j++)
            {
                for (int i = 42; i <= 57; i++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(grass);
                }
                for (int i = 126; i <= 141; i++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(grass);
                }
            }
            Console.ResetColor();
        }
    }
}
