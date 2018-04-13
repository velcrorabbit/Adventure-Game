using System;
using Adventure_Game.GridLocations;
using Adventure_Game.Helpers;

namespace Adventure_Game
{
    class GF
    {
        private PlayerInfo LocalPlayerInfo;
        public GF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public GF() { squareEntered(); }
        private void squareEntered()
        {
            Console.WriteLine("The trees continue, you see a crudely painted wooden sign nailed to one, it reads: ");
            Console.WriteLine("LARGE ANGRY BEAR, DO NOT CONTINUE");
            Console.WriteLine("Where do you want to go?");
            NewDirection();
        }

         private void NewDirection()
        {
            string direction = Console.ReadLine().ToLower();

            if (DirectionsHelper.isEast(direction))
                new HF();
            else if (DirectionsHelper.isNorth(direction))
            {
                Console.WriteLine("GG");
                new Incomplete().displayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.isWest(direction))
                new FF();
            else if (DirectionsHelper.isSouth(direction))
                new GE();
            else
                new Error().displayErrorMessage();
        }
    }
}
