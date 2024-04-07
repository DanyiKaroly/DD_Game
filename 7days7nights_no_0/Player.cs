using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace _7days7nights_no_0
{
    internal static class Player
    {
        public static string Name { get; set; }
        public static Skin Skin { get; set; }
        public static Weapon Weapon { get; set; }
        public static int Level { get; set; }
        public static int Xp { get; set; }
        public static int SkillPoints { get; set; }
        public static int Credit { get; set; }

        public static int x { get; set; }
        public static int y { get; set; }

        static Player()
        {
            Name = "Player";
            Level = 1;
            Xp = 0;
            SkillPoints = 0;
            Credit = 0;
        }


    }
}
