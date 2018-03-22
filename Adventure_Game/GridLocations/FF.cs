using System;

namespace Adventure_Game
{
    internal class FF
    {

        internal void squareEntered()
        {
            Console.WriteLine("There is a large angry bear in front of you, you try and defend yourself, but it's a bear. You are quickly torn to shreds. Sorry, but I did try to warn you.");
            Console.WriteLine("");
            new HF().squareEntered();
        }
    }
}
