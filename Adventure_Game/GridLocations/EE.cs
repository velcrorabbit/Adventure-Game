using Adventure_Game.GridLocations;
using Adventure_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class EE
    {
        private PlayerInfo LocalPlayerInfo;
        public EE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public EE() { squareEntered(); }
        private void squareEntered()
        {
            Console.WriteLine("The cave continues.");
            NewDirection();
        }

        private void NewDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
                new FE();
            else if (DirectionsHelper.isNorth(direction))
                new PitDeath();
            else if (DirectionsHelper.isWest(direction))
                new DE();
            else if (DirectionsHelper.isSouth(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                NewDirection();
            }
            else
            {
                new Error().displayErrorMessage();
                NewDirection();
            }
        }
    }
}
