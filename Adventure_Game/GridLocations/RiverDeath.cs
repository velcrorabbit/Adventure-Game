using Adventure_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{
    public class RiverDeath
    {
        public void squareEntered()
        {
            Console.WriteLine("Sadly you never learned to swim, " +
                "and as the water closes \n over your head you think " +
                "back to all the places you still haven't been.");
            new EndGame().restart();
        }
    }
}
