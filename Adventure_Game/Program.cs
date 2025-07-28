using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            var player = new PlayerInfo();
            Console.WriteLine("Welcome to Adventure Land, what is your name?");
            string playerName = "";
            playerName = Console.ReadLine();

            Console.WriteLine("Welcome, {0}" , playerName);
            player.PlayerName = playerName;
            new HF();
        }
    }
}
