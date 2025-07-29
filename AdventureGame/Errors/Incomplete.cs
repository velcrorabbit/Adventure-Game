using AdventureGame;
using AdventureGame.Helpers;
using System;

namespace AdventureGame
{
    class Incomplete
    {

        public void DisplayIncompleteMessage(PlayerInfo LocalPlayerInfo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You fall into a dark empty void, you notice a sign in the sky 'New map! Coming soon to an adventure near you'.");
            Console.WriteLine("");
            new EndGame(LocalPlayerInfo).Restart();
        }

        public void DisplayIncompleteMessageWithoutExit()
        {
            Console.WriteLine("You hit an invisable wall, a sign above reads: 'New map! Coming soon to an adventure near you'.");
        }
    }
}
