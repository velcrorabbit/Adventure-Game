using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    internal class GE
    {
        private PlayerInfo LocalPlayerInfo;

        public GE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }

        public GE() { squareEntered(); }

        private void squareEntered() { 

            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("The forest continues. Choose a direction");
            newDirection();
            
        }

        private void newDirection()
        {
           
            string direction = Console.ReadLine();

            if (DirectionsHelper.isEast(direction))
                new HE();
            else if (DirectionsHelper.isNorth(direction))
                new GF();
            else if (DirectionsHelper.isWest(direction))
                new FE();
            else if (DirectionsHelper.isSouth(direction))
            {
                Console.WriteLine("GD");
                new Incomplete().displayIncompleteMessageWithoutExit();
                newDirection();
            }
            else
                new Error().displayErrorMessage();
                newDirection();

        }
    }
}
