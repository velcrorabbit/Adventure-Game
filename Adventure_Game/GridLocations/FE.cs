using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    internal class FE
    {
        private PlayerInfo LocalPlayerInfo;
        public FE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public FE() { squareEntered(); }
        private void squareEntered()
        {
            Console.WriteLine("Infront of you is the entrance to a dark cave, do you want to go in? y/n");
            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.WriteLine("You bravely walk into the gloom.");
                new EE();
            }
            else if (input == "n")
            {
                Console.WriteLine("You decide to turn back. Choose a direction.");
                NewDirection();
            }
            else
                new Error().displayErrorMessage();
        }
        private void NewDirection()
        {
                string direction = Console.ReadLine();
                if (DirectionsHelper.isEast(direction)) 
                    new GE();
                else if (DirectionsHelper.isNorth(direction))
                    new FF();
                else if (DirectionsHelper.isSouth(direction))
                {
                    Console.WriteLine("FD");
                    new Incomplete().displayIncompleteMessageWithoutExit();
                    NewDirection();
                }
        }
    }
}
