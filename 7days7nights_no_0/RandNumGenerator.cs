using _7days7nights_no_0;

namespace ZombieGameMovement
{
    public static class RandNumGenerator
    {
        private static Random random = new();

        public static void GetZomCoordinate(out int x, out int y)
        {
            int tmp = random.Next(0,4);

            switch (tmp)
            {
                case 0:
                    x = 0;
                    y = random.Next(0,Game.FormWidth);
                    break;
                case 1:
                    x = Game.FormHeight;
                    y = random.Next(0, Game.FormWidth);
                    break;
                case 2:
                    x = random.Next(0, Game.FormHeight);
                    y = 0;
                    break;
                case 3:
                    x = random.Next(0, Game.FormHeight);
                    y = Game.FormWidth;
                    break;
                default:
                    x = 0;
                    y = 0;
                    break;
            }

        }
    }
}
