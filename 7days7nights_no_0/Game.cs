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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_paint(object sender, PaintEventArgs e)
        {
            Graphics Play = e.Graphics;

            Play.DrawImage(Image.FromFile(ImageContainer.SkinImage[Convert.ToInt32(Player.Skin.Id)]), Player.x, Player.y, 64, 64);

        }
    }
}
