using System;

namespace Adventure_Game
{
    internal class GE
    {
        public void squareEntered()
        {
            Console.WriteLine("The forest continues. Choose a direction");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
                new HE().squareEntered();
            else if (DirectionsHelper.isNorth(direction))
                new GF().squareEntered();
            else if (DirectionsHelper.isWest(direction))
                new FE().squareEntered();
            else if (DirectionsHelper.isSouth(direction))
            {
                Console.WriteLine("GD");
                new Incomplete().displayIncompleteMessage();
            }
            else
                new Error().displayErrorMessage();
        }
    }
}
