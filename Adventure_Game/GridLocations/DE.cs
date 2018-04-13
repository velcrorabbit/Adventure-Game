using Adventure_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{
    class DE
    {
        private PlayerInfo LocalPlayerInfo;
        public DE(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public DE() { squareEntered(); }
        private void squareEntered()
        {
            Console.WriteLine("The cave continues.");
            newDirection();
        }

        private void newDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
                new EE();
            else if (DirectionsHelper.isNorth(direction))
                new DF();
            else if (DirectionsHelper.isWest(direction))
            {
                Console.WriteLine("You bump into the cave wall");
                newDirection();
            }
            else if (DirectionsHelper.isSouth(direction))
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
