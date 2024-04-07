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
        public static int Xp;

        public static int SkillPoints { get; set; }
        public static int Credit { get; set; }

        public static int Damage { get; set; }

        public static int HP {  get; set; }

        public static int Reload_Time {  get; set; }

        public static int Movement_Speed { get; set; }

        public static int Fire_Rate {  get; set; }


        public static int x { get; set; }
        public static int y { get; set; }

        

        static Player()
        {
            Name = "Player";
            Level = 1;
            Xp = 0;
            SkillPoints = 0;
            Credit = 0;
            HP = 3;
            Damage = 1;
            Movement_Speed = 1;
            Fire_Rate = 1;
            Reload_Time = 1;
            SkillPoints=5;
        }

        public static void XP_TO_SkillPoint(int be_xp)
        {
            be_xp+=Xp;
            while (be_xp>=1000)
            {
                be_xp=be_xp -1000;
                Level++;
                SkillPoints++;
                
            }
            Xp = be_xp;
        }

        public static void set_XP(int value)
        {
            XP_TO_SkillPoint(value);
        }
        

    }
}
