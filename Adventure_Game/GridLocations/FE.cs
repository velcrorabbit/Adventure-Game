using System;

namespace Adventure_Game
{
    internal class FE
    {
        internal void SquareEntered()
        {
            Console.WriteLine("Infront of you is the entrance to a dark cave, do you want to go in? y/n");
            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.WriteLine("You bravely walk into the gloom.");
                new EE().squareEntered();
            }
            else if (input == "n")
            {
                Console.WriteLine("You decide to turn back. Choose a direction.");
                NewDirection();
            }
            else
                new Error().displayErrorMessage();
        }
        internal void NewDirection()
        {
                string direction = Console.ReadLine();
                if (DirectionsHelper.isEast(direction)) 
                    new GE().squareEntered();
                else if (DirectionsHelper.isNorth(direction))
                    new FF().squareEntered();
                else if (DirectionsHelper.isSouth(direction))
                {
                    Console.WriteLine("FD");
                    new Incomplete().displayIncompleteMessageWithoutExit();
                    NewDirection();
                }
        }
    }
}
