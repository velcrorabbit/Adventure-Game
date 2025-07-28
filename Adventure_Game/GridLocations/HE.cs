using System;
using Adventure_Game.Helpers;

namespace Adventure_Game
{
    class HE
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public HE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("You come across a small cottage, the door is open and no one seems to be home, do you want to go in? y/n");
            string input = Console.ReadLine();

            if (input == "y")
                new House(LocalPlayerInfo);
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
            if (DirectionsHelper.IsEast(direction))
            {
                Console.WriteLine("IE");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.IsNorth(direction))
                new HF(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
            {
                Console.WriteLine("HD");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();

            }
            else if (DirectionsHelper.IsWest(direction))
                new GE(LocalPlayerInfo);
            else
                new Error().displayErrorMessage();
        }
    }
}