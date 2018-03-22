using System;

namespace Adventure_Game
{
    internal class CliffDeath
    {

        internal void squareEnterered()
        {
            Console.WriteLine("With a mournfull look to the forest behind you, " +
                            "you decide death is preferable to playing this god awfull game. " +
                            "You jump into the void and die.");
            Console.WriteLine("");
            new HF().squareEntered();
        }
    }
}
