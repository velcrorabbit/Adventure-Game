using System;

namespace Adventure_Game
{
    class GF
    {
        public void squareEntered()
        {
            Console.WriteLine("The trees continue, you see a crudely painted wooden sign nailed to one, it reads: ");
            Console.WriteLine("LARGE ANGRY BEAR, DO NOT CONTINUE");
            Console.WriteLine("Where do you want to go?");
            string direction = Console.ReadLine().ToLower();

            if (direction == "east")
                new HF().squareEntered();
            else if (direction == "north")
            {
                Console.WriteLine("GG");
                new Incomplete().displayIncompleteMessage();
            }
            else if (direction == "west")
                new FF().squareEntered();
            else if (direction == "south")
                new GE().squareEntered();
            else
                new Error().displayErrorMessage();
        }
    }
}
