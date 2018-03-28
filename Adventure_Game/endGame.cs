using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    internal class EndGame
    {
        public void restart()
        {
            Console.WriteLine("Would you like to keep playing? y/n");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.Clear();
                new HF().squareEntered();
            }
            else if (input == "n")
            {
                Console.WriteLine("That's enough adventuring for one day.");
                Console.WriteLine("Goodbye.");
                Console.ReadLine();
            }
        }
    }
}
