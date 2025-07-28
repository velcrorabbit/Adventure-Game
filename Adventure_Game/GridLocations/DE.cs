using Adventure_Game.Helpers;
using System;


namespace Adventure_Game.GridLocations
{
    class DE
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public DE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }

        private void squareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;

            Console.WriteLine("The cave continues.");
            newDirection();
        }

        private void newDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.IsEast(direction))
                new EE(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
                new DF(LocalPlayerInfo);
            else if (DirectionsHelper.IsWest(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                newDirection();
            }
            else if (DirectionsHelper.IsSouth(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                newDirection();
            }
            else
            {
                new Error().displayErrorMessage();
                newDirection();
            }
        }
    }
}
