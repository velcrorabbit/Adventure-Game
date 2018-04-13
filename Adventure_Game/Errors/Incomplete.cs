using Adventure_Game;
using System;

namespace Adventure_Game
{
    class Incomplete
    {
        public void displayIncompleteMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You fall into a dark empty void, you notice a sign in the sky 'New map! Coming soon to an adventure near you'.");
            Console.WriteLine("");
            new EndGame().restart();
        }

        public void displayIncompleteMessageWithoutExit()
        {
            Console.WriteLine("You hit an invisable wall, a sign above reads: 'New map! Coming soon to an adventure near you'.");
        }
    }
}
