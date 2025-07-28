using Adventure_Game.Helpers;
using System;


namespace Adventure_Game.GridLocations
{

    class HH
    {
        private readonly PlayerInfo LocalPlayerInfo;

        public HH(PlayerInfo playerInfo)
        {
            LocalPlayerInfo = playerInfo;
            SquareEntered();
        }

        public HH() { SquareEntered(); }

        private void SquareEntered()
        {
            throw new NotImplementedException();
        }
    }
}
