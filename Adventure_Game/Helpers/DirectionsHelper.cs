namespace Adventure_Game
{
    static class DirectionsHelper
    {
        public static bool isEast(string direction)
        {
            if (direction.ToLower().Equals("east") || direction.ToLower().Equals("e"))
            {
                return true;
            }
            return false;
        }

        public static bool isWest(string direction)
        {
            if (direction.ToLower().Equals("west") || direction.ToLower().Equals("w"))
            {
                return true;
            }
            return false;

        }
        public static bool isSouth(string direction)
        {
            if (direction.ToLower().Equals("south") || direction.ToLower().Equals("s"))
            {
                return true;
            }
            return false;

        }

    }
}
