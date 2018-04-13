using System;
using Adventure_Game.GridLocations;
using Adventure_Game.Helpers;

namespace Adventure_Game
{
    class HE
    {
        private PlayerInfo LocalPlayerInfo;
        public HE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public HE() { squareEntered(); }
        private void squareEntered()
        {
            Console.WriteLine("You come across a small cottage, the door is open and no one seems to be home, do you want to go in? y/n");
            string input = Console.ReadLine();

            if (input == "y")
                new House();
            else if (input == "n")
            {
                Console.WriteLine("Good choice, probably a trap anyway.");
                NewDirection();
            }
        }

        private void NewDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
            {
                Console.WriteLine("IE");
                new Incomplete().displayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.isNorth(direction))
                new HF();
            else if (DirectionsHelper.isSouth(direction))
            {
                Console.WriteLine("HD");
                new Incomplete().displayIncompleteMessageWithoutExit();
                NewDirection();

            }
            else if (DirectionsHelper.isWest(direction))
                new GE();
            else
                new Error().displayErrorMessage();
        }
    }
}