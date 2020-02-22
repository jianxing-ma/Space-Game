using System;
using System.Collections.Generic;

namespace Space_Game
{
    class Menu
    {
        public Menu()
        {
            ClearMenu();
            Console.SetCursorPosition(0, Display.Sy2 + 1);
        }
        //The player will either be in itself or in the spaceship
        //Player: Age, currency, items, 
        //Spaceship: fuel, parts condition,speed

        public static void ClearMenu()
        {
            Cursor.ClearArea(0, Display.Sx2 - 1, Display.Sy2 + 1, Display.Sy3 - 1);
        }

        public static void Intro()
        {
            Console.SetCursorPosition(0, Display.Sy2 + 2);
            Console.WriteLine("\t\t\t\t     Welcome to the game, SPACE COWBOY!");
            Console.WriteLine("\t\tYou make your own adventure. You decide the life you want to live as a space cowboy.");
            Console.WriteLine("\t\tYou are an 18 year old cowboy on planet earth, ready to take on the universe!");
            Console.WriteLine("\t\tKeep in mind that your decisions can lead to death, wealth, or even maybe an immortal Space Cowboy God..");
            Console.Write("\t\tContinue(Enter)....");

            Console.ReadLine();
        }


        public static void Stat(List<double> stat)
        {
            var currentcoord = (Console.CursorLeft, Console.CursorTop);
            Console.SetCursorPosition(0, Display.Sy2 + 1);

            Console.WriteLine("\t\t\t" + $"Age: {stat[0]} | Money: {stat[1]} | Granite: {stat[2]} | " +
                $"Crystal: {stat[3]} | Jade: {stat[4]} | Ruby: {stat[5]} | Diamond: {stat[6]}");

            Console.SetCursorPosition(currentcoord.Item1, currentcoord.Item2);
        }

        public static void Spaceship()
        {
            Console.WriteLine("Choose Destination: C | Stat: S | Back: B");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.C:
                    Console.WriteLine("Earth: 0 | Planet 1: 1");
                    Console.Write("\tChoose Planet you would like to go: ");
                    break;
                case ConsoleKey.S:
                    PlayerStat();
                    break;
            }           
        }

        public void GotoPlanet()
        {

            Console.WriteLine("Earth: 0 | Planet 1: 1");
            Console.WriteLine("Choose Planet you would like to go: ");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    //Display the space travel animation
                    //Display the destinatioan planet
                    break;
                case ConsoleKey.D2:
                    break;
            }
        }

        public static void PlayerStat()
        {
            Console.SetCursorPosition(0, Display.Sy2 + 1);
            Console.Write($"\tTime: \tMoney: 5000\tGranite: 50\tCrystal: 15\tJade: 10\tRuby: 8\t\tDiamond: 5");
        }

        public static void MarketPrice()
        {
            Random rd = new Random();
            int Granite = rd.Next(1, 10);

        }

        

    }
}
