using Demo;
using System.Security.Cryptography;


namespace _7days7nights_no_0
{
    public partial class MenuForm : Form
    {
        Sounds songs = new Sounds();
        Sound settingsForm = new Sound();
        Levels levels = new Levels();
        InventoryPerSkills MoreMenuButton = new InventoryPerSkills();
        DBmethods dBmethods = new DBmethods();
        
        public MenuForm()
        {
            InitializeComponent();
            dBmethods.Read_from_DB();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dBmethods.save();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            songs.MenuSongStop();
            settingsForm.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            songs.MenuSongStart();

        }


        private void button4_Click(object sender, EventArgs e)
        {

            levels.ShowDialog();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            MoreMenuButton.ShowDialog();
            
        }


    }
}
