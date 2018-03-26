using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{
    public class DE
    {
        public void squareEntered()
        {
            Console.WriteLine("The cave continues.");
            newDirection();
        }

        public void newDirection()
        {
            Console.WriteLine("Choose a direction.");
            string direction = Console.ReadLine();
            if (DirectionsHelper.isEast(direction))
                new EE().squareEntered();
            else if (DirectionsHelper.isNorth(direction))
                new DF().squareEntered();
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
