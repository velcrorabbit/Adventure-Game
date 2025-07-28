namespace Adventure_Game
{
    static class DirectionsHelper
    {
        public static bool IsEast(string direction)
        {
            if (direction.ToLower().Equals("east") || direction.ToLower().Equals("e"))
            {
                return true;
            }
            return false;
        }

        public static bool IsWest(string direction)
        {
            if (direction.ToLower().Equals("west") || direction.ToLower().Equals("w"))
            {
                return true;
            }
            return false;

        }

        public static bool IsSouth(string direction)
        {
            if (direction.ToLower().Equals("south") || direction.ToLower().Equals("s"))
            {
                return true;
            }
            return false;

        }

        public static bool IsNorth(string direction)
        {
            if (direction.ToLower().Equals("north") || direction.ToLower().Equals("n"))
            {
                return true;
            }
            return false;

        }
    }
}
