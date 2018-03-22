using System;

namespace Adventure_Game
{
    class IF
    {
        public void squareEntered()
        {
            Console.WriteLine("There is a cliff, below you is the sea, to the north you can hear a waterfall.");
            string direction = Console.ReadLine();

            if (direction == "east")
                new CliffDeath().squareEnterered();
            else if (direction == "north")
            {
                Console.WriteLine("IG");
                new Incomplete().displayIncompleteMessage();
            }
            else if (direction == "west")
                new HF().squareEntered();
            else if (direction == "south")
            {
                Console.WriteLine("IE");
                new Incomplete().displayIncompleteMessage();
            }
            else
                new Error().displayErrorMessage();
        }
    }
}
