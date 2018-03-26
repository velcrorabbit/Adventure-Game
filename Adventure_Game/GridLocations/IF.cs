using System;

namespace Adventure_Game
{
    class IF
    {
        public void squareEntered()
        {
            Console.WriteLine("There is a cliff, below you is the sea, to the north you can hear a waterfall.");
            string direction = Console.ReadLine();

            if (DirectionsHelper.isEast(direction))
                new CliffDeath().squareEnterered();
            else if (DirectionsHelper.isNorth(direction))
            {
                Console.WriteLine("IG");
                new Incomplete().displayIncompleteMessage();
            }
            else if (DirectionsHelper.isWest(direction))
                new HF().squareEntered();
            else if (DirectionsHelper.isSouth(direction))
            {
                Console.WriteLine("IE");
                new Incomplete().displayIncompleteMessage();
            }
            else
                new Error().displayErrorMessage();
        }
    }
}
