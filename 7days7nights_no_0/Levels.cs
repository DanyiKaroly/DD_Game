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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void Levels_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void Level1_Click(object sender, EventArgs e)
        {
            Game game = new()
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized
            };
            game.Show();
        }
    }
}
