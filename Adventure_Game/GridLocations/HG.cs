using Adventure_Game.GridLocations;
using System;

namespace Adventure_Game
{
    internal class HG
    {
        public void squareEntered()
        {
            Console.WriteLine("A large river flows in front of you, it looks very deep.");
            NewDirection();
        }

        internal void NewDirection()
        {
            Console.WriteLine("Where do you want to go?");
            string direction = Console.ReadLine().ToLower();

            if (DirectionsHelper.isEast(direction))
            {
                Console.WriteLine("IG");
                new Incomplete().displayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.isNorth(direction))
                new RiverDeath().squareEntered();
            else if (DirectionsHelper.isWest(direction))
                new FF().squareEntered();
            else if (DirectionsHelper.isSouth(direction))
                new GE().squareEntered();
            else
                new Error().displayErrorMessage();
        }
    }
}