using Demo;

namespace _7days7nights_no_0
{
    public partial class MenuForm : Form
    {
        Sounds songs = new Sounds();
        Sound formMenu = new Sound();
        public MenuForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            songs.MenuSongStop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            songs.MenuSongStart();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

    }
}
