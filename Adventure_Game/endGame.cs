using Adventure_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    internal class EndGame
    {
        private PlayerInfo LocalPlayerInfo;
        public EndGame(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            Restart();
        }
        public void Restart()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You have reached the end of the game. You travelled {0} tiles!", LocalPlayerInfo.TilesEntered);
            Console.WriteLine("Would you like to play again? y/n");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.Clear();
                new HF(LocalPlayerInfo);
            }
            else if (input == "n")
            {
                Console.WriteLine("That's enough adventuring for one day.");
                Console.WriteLine("Goodbye.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
