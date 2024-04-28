﻿namespace _7days7nights_no_0
{
    internal class Zombie
    {
        public Image ZombieImage { get; private set; }
        public int EnemyX { get; set; }
        public int EnemyY { get; set; }
        public int EnemyWidth { get; }
        public int EnemyHeight { get; }
        private int SlowDownEnemyFrameRate { get; set; }
        private int SpriteIndex { get; set; }
        private int Steps { get; set; }
        public Zombie()
        {
            RandNumGenerator.GetZomCoordinate(out int x, out int y);
            ZombieImage = SpriteContainer.zombieWalkRight[0];
            EnemyX = x;
            EnemyY = y;
            EnemyWidth = 100;
            EnemyHeight = 100;
            SlowDownEnemyFrameRate = 0;
            SpriteIndex = 0;
            Steps = 0;
        }

        public void AnimateEnemy(Image[] source)
        {
            int end = source.Length - 1;

            SlowDownEnemyFrameRate++;
            if (SlowDownEnemyFrameRate == 4)
            {
                SpriteIndex++;
                SlowDownEnemyFrameRate = 0;
            }

            if (SpriteIndex > end)
            {
                SpriteIndex = 0;
            }

            ZombieImage = source[SpriteIndex];
        }

        public void AnimateEnemyDying()
        {
            int slowerFrameRate = 0;
            int spriteIndex = 0;

            slowerFrameRate++;
            if (slowerFrameRate == 4)
            {
                spriteIndex++;
                slowerFrameRate = 0;
            }

            //TODO: inport sprite for dying, logic for changing pictures (loop or add it to a timer?), dispose after last sprite
        }

    }
}
