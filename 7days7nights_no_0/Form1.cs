using Demo;

namespace _7days7nights_no_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Sound soundsSettigs = new Sound() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            soundsSettigs.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(soundsSettigs);
            soundsSettigs.Show(); */
            Sound form = new Sound();
            form.Show();

        }
    }
}
