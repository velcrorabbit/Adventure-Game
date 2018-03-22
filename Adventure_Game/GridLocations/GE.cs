using System;

namespace Adventure_Game
{
    internal class GE
    {
        internal void squareEntered()
        {
            Console.WriteLine("The forest continues. Choose a direction");
            string direction = Console.ReadLine();

            if (direction == "east")
                new HE().squareEntered();
            else if (direction == "north")
            {
                Console.WriteLine("GF");
                new Incomplete().displayIncompleteMessage();
            }
            else if (direction == "west")
                new FE().squareEntered();
            else if (direction == "south")
            {
                Console.WriteLine("GD");
                new Incomplete().displayIncompleteMessage();
            }
            else
                new Error().displayErrorMessage();
        }
    }
}
