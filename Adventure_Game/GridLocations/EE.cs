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
                new FE().squareEntered();
            else if (direction == "north")
            {
                Console.WriteLine("EF");
                new Incomplete().displayIncompleteMessage();
            }
            else if (direction == "west")
            {
                Console.WriteLine("DE");
                new Incomplete().displayIncompleteMessage();
            }
            else if (direction == "south")
                Console.WriteLine("CaveWall");
            else
            {
                new Error().displayErrorMessage();
                newDirection();
            }
        }
    }
}
