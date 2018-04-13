using Adventure_Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game.GridLocations
{

    class HH
    {
        private PlayerInfo LocalPlayerInfo;
        public HH(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            squareEntered();
        }
        public HH() { squareEntered(); }
        private void squareEntered()
        {
            throw new NotImplementedException();
        }
    }
}
