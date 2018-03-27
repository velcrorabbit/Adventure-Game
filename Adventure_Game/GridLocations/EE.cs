using Adventure_Game.GridLocations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class EE
    {
        public void squareEntered()
        {
            Console.WriteLine("The cave continues.");
            newDirection();
        }

        private void newDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
                new FE().SquareEntered();
            else if (DirectionsHelper.isNorth(direction))
                new PitDeath().squareEntered();
            else if (DirectionsHelper.isWest(direction))
                new DE().squareEntered();
            else if (DirectionsHelper.isSouth(direction))
                Console.WriteLine("You bump into the cave wall.");
            else
            {
                new Error().displayErrorMessage();
                newDirection();
            }
        }
    }
}
