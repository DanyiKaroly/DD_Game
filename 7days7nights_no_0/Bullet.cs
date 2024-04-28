using static _7days7nights_no_0.EnumContainer;

namespace _7days7nights_no_0
{
    
    internal class Bullet
    {
        public DirectionType Direction { get; }
        public int Speed { get; }
        public PictureBox BulletImg { get; }
        public System.Windows.Forms.Timer BulletTimer { get; }

        public Bullet(DirectionType direction, int bulletLeft, int bulletTop)
        {
            Direction = direction;
            Speed = 20;
            BulletImg = new()
            {
                BackColor = Color.White,
                Size = new Size(5, 5),
                Tag = "bullet",
                Left = bulletLeft,
                Top = bulletTop,
            };
            BulletTimer = new()
            {
                Interval = Speed
            };
        }

        public void MakeBullet(Form form)
        {
            form.Controls.Add(BulletImg);
            BulletImg.BringToFront();

            //BulletTimer.Tick += new EventHandler(BulletTimerEvent);
            //BulletTimer.Start();
        }

        //private void BulletTimerEvent(object? sender, EventArgs e)
        //{
        //    if (Direction.Equals(DirectionType.LEFT))
        //    {
        //        BulletImg.Left -= Speed;
        //    }

        //    else if (Direction.Equals(DirectionType.RIGHT))
        //    {
        //        BulletImg.Left += Speed;
        //    }

        //    else if (Direction.Equals(DirectionType.UP))
        //    {
        //        BulletImg.Top -= Speed;
        //    }

        //    else if (Direction.Equals(DirectionType.DOWN))
        //    {
        //        BulletImg.Top += Speed;
        //    }

        //    else if (BulletImg.Left < 0 || BulletImg.Left > GameWithFixMap.FormWidth || BulletImg.Top < 0 || BulletImg.Top > GameWithFixMap.FormHeight)
        //    {
        //        BulletTimer.Stop();
        //        BulletTimer.Dispose();
        //        BulletImg.Dispose();
        //    }
        //}
    }
}
