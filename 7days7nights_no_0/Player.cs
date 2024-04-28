using static _7days7nights_no_0.EnumContainer;

namespace _7days7nights_no_0
{
    internal class Player
    {
        public Image PlayerImg { get; private set; }
        public static int PlayerHealth { get; set; }
        public static int PlayerSpeed { get; set; }
        public int PlayerX { get; set; }
        public int PlayerY { get; set; }
        public int PlayerWidth { get; }
        public int PlayerHeight { get; }
        private int Steps { get; set; }
        private int SlowDownFrameRate { get; set; }
        public static int Xp { get; set; }
        public static int Level { get; set; }
        public static int SkillPoints { get; set; }
        public static int Firerate { get; set; }
        public static int Reload_Time { get; set; }

        public static int Damage { get; set; }

        public bool GoLeft { get; set; }
        public bool GoRight { get; set; }
        public bool GoUp { get; set; }
        public bool GoDown { get; set; }
        public bool Attack { get; set; }
        public static int Map { get; internal set; }

        public Player(int playerHealth, int playerSpeed, int playerX, int playerY)
        {
            PlayerImg = SpriteContainer.walkRight[0];
            PlayerHealth = playerHealth;
            PlayerSpeed = playerSpeed;
            PlayerX = playerX;
            PlayerY = playerY;
            PlayerWidth = 100;
            PlayerHeight = 100;
            SlowDownFrameRate = 0;
            GoLeft = false;
            GoRight = false;
            GoUp = false;
            GoDown = false;
            Attack = false;
        }

        public void SendDirection(DirectionType direction)
        {
            if (direction.Equals(DirectionType.LEFT))
            {
                AnimatePlayer(SpriteContainer.walkLeft);
            }
            else
            {
                AnimatePlayer(SpriteContainer.walkRight);
            }
        }
        public void AnimatePlayer(Image[] source)
        {
            int end = source.Length - 1;

            SlowDownFrameRate++;
            if (SlowDownFrameRate == 4)
            {
                Steps++;
                SlowDownFrameRate = 0;
            }

            if (Steps > end)
            {
                Steps = 0;
            }

            PlayerImg = source[Steps];
        }

        public static void Set_XP(int score)
        {
            int gainedXp = Xp + score * 100;
            while (gainedXp >= 1000)
            {
                gainedXp = gainedXp - 1000;
                Level++;
                SkillPoints++;

            }
            Xp = gainedXp;
        }

        //TODO: same method for animating the death of the player like in the zombie class
    }
}
