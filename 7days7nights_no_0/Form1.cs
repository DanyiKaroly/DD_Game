using Demo;
using System.Security.Cryptography;


namespace _7days7nights_no_0
{
    public partial class MenuForm : Form
    {
        Sounds songs = new Sounds();
        Sound formMenu = new Sound();
        InventoryPerSkills MoreMenuButton = new InventoryPerSkills();
        Levels levels = new Levels();
        DBmethods dBmethods = new DBmethods();
        
        public MenuForm()
        {
            InitializeComponent();
            dBmethods.Read_from_DB();
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
            levels.Show();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            MoreMenuButton.Show();
            
        }
    }
}
