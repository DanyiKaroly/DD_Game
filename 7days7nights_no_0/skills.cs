using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7days7nights_no_0
{
    public partial class skills : Form
    {

        public skills()
        {
            InitializeComponent();
            Player.set_XP(1500);
            Player.set_XP(500);
            Current_Speed.Text = Convert.ToString(Player.Movement_Speed);
            Current_Firerate.Text = Convert.ToString(Player.Fire_Rate);
            Current_HP.Text = Convert.ToString(Player.HP);
            Current_Damage.Text = Convert.ToString(Player.Damage);
            Current_Reload_time.Text = Convert.ToString(Player.Reload_Time);
            Level.Text = $"Level: {Convert.ToString(Player.Level)}";
            XP.Text = $"XP: {Convert.ToString(Player.Xp)}";
            Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            

        }

        private void skills_Load(object sender, EventArgs e)
        {

        }

        private void Back_To_Main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plus_speed_Click(object sender, EventArgs e)
        {
            if (Player.SkillPoints != 0)
            { 

                Player.Movement_Speed++;

                Current_Speed.Text = Convert.ToString(Player.Movement_Speed);
                Player.SkillPoints--;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
        }

        private void minus_speed_Click(object sender, EventArgs e)
        {
            if (Player.Movement_Speed != 1)
            { 
                Player.Movement_Speed--;
                Current_Speed.Text = Convert.ToString(Player.Movement_Speed);
                Player.SkillPoints++;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
        }

        private void plus_firerate_Click(object sender, EventArgs e)
        {
            if (Player.SkillPoints != 0)
            {
                Player.Fire_Rate++;
                Current_Firerate.Text = Convert.ToString(Player.Fire_Rate);
                Player.SkillPoints--;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
        }

        private void minus_firerate_Click(object sender, EventArgs e)
        {
            if (Player.Fire_Rate != 1)
            {
                Player.Fire_Rate--;
                Current_Firerate.Text = Convert.ToString(Player.Fire_Rate);
                Player.SkillPoints++;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
        }

        private void plus_hp_Click(object sender, EventArgs e)
        {
            if (Player.SkillPoints != 0)
            {

                Player.HP++;
                Current_HP.Text = Convert.ToString(Player.HP);
                Player.SkillPoints--;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
        }

        private void minus_hp_Click(object sender, EventArgs e)
        {
            if (Player.HP != 3)
            {
                Player.HP--;
                Current_HP.Text = Convert.ToString(Player.HP);
                Player.SkillPoints++;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
        }

        private void plus_damage_Click(object sender, EventArgs e)
        {
            if (Player.SkillPoints != 0) { 
                Player.Damage++;
                
                Current_Damage.Text = Convert.ToString(Player.Damage);
                Player.SkillPoints--;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
            
        }

        private void minus_damage_Click(object sender, EventArgs e)
        {
            if (Player.Damage != 1)
            {
                Player.Damage--;
                Current_Damage.Text = Convert.ToString(Player.Damage);
                Player.SkillPoints++;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
        }

        private void plus_reload_time_Click(object sender, EventArgs e)
        {
            if(Player.SkillPoints != 0)
            {
                Player.Reload_Time++;
                Current_Reload_time.Text = Convert.ToString(Player.Reload_Time);
                Player.SkillPoints--;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
           
        }

        private void minus_reload_time_Click(object sender, EventArgs e)
        {
            if (Player.Reload_Time != 1)
            {
                Player.Reload_Time--;
                Current_Reload_time.Text = Convert.ToString(Player.Reload_Time);
                Player.SkillPoints++;
                Skill_Point.Text = $"Skill_Points: {Convert.ToString(Player.SkillPoints)}";
            }
        }
    }
}
