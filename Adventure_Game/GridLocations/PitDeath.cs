using Adventure_Game.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{
    public class PitDeath
    {
        public void squareEntered()
        {
            Console.WriteLine("You trip an fall into a dark pit.");
            new EndGame().restart();
        }
    }
}
