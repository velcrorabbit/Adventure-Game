using System;
using Adventure_Game.Helpers;

namespace Adventure_Game
{
    class GF
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public GF(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        private void SquareEntered()
        {
            LocalPlayerInfo.TilesEntered += 1;
            Console.WriteLine("The trees continue, you see a crudely painted wooden sign nailed to one, it reads: ");
            Console.WriteLine("LARGE ANGRY BEAR, DO NOT CONTINUE");
            Console.WriteLine("Where do you want to go?");
            NewDirection();
        }

         private void NewDirection()
        {
            string direction = Console.ReadLine().ToLower();

            if (DirectionsHelper.IsEast(direction))
                new HF(LocalPlayerInfo);
            else if (DirectionsHelper.IsNorth(direction))
            {
                Console.WriteLine("GG");
                new Incomplete().DisplayIncompleteMessageWithoutExit();
                NewDirection();
            }
            else if (DirectionsHelper.IsWest(direction))
                new FF(LocalPlayerInfo);
            else if (DirectionsHelper.IsSouth(direction))
                new GE(LocalPlayerInfo);
            else
                new Error().displayErrorMessage();
        }
    }
}
