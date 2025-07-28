using Adventure_Game.Helpers;
using System;

namespace Adventure_Game
{
    internal class GE
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public GE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered() { 

            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("The forest continues. Choose a direction");
            NewDirection();
            
        }

        private void NewDirection()
        {
           
            string direction = Console.ReadLine();

            if (DirectionsHelper.IsEast(direction))
                new HE(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
                new GF(LocalPlayerInfo);
            else if (DirectionsHelper.IsWest(direction))
                new FE(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
            {
                Console.WriteLine("GD");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else
                new Error().displayErrorMessage();
                NewDirection();

        }
    }
}
