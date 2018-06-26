using Adventure_Game;
using System;

namespace Adventure_Game
{
    internal class CliffDeath
    {

        internal void squareEntered()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("With a mournfull look to the forest behind you, " +
                            "you decide death is preferable to playing this god awfull game. " +
                            "You jump into the void and die.");
            new EndGame().Restart();
        }
    }
}
