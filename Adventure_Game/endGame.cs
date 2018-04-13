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
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Would you like to play again? y/n");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.Clear();
                new HF();
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
