using _7days7nights_no_0;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class Sound : Form
    {
        Sounds song;
        bool var = false;
        bool varsfx = false;

        public Sound()
        {
            song = new Sounds();
            InitializeComponent();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            song.MusicVolumeSet(((TrackBar)sender).Value);

        }

        private void volumeTrackBar2_Scroll(object sender, EventArgs e)
        {
            song.VolumeSFXSet(((TrackBar)sender).Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Csúszka inicializálása
            TrackBar volumeTrackBar = InicializalCsuszkat(song.MusicVolumeGet(), volumeTrackBar_Scroll);
            TrackBar volumeTrackBar2 = InicializalCsuszkatsfx(song.SfxVolumeGet(), volumeTrackBar2_Scroll);

            // Csúszka hozzáadása a Form-hoz
            Controls.Add(volumeTrackBar);
            Controls.Add(volumeTrackBar2);

        }

        private TrackBar InicializalCsuszkat(int kezdoErtek, EventHandler esemenyKezelo)
        {

            TrackBar volumeTrackBar = new TrackBar();
            volumeTrackBar.Minimum = 0;
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.Value = kezdoErtek;
            volumeTrackBar.TickFrequency = 10;
            volumeTrackBar.Orientation = Orientation.Horizontal;
            volumeTrackBar.Scroll += esemenyKezelo;


            return volumeTrackBar;
        }

        private TrackBar InicializalCsuszkatsfx(int kezdoErtek, EventHandler esemenyKezelo)
        {
            TrackBar volumeTrackBar = new TrackBar();
            volumeTrackBar.Minimum = 0;
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.Value = kezdoErtek;
            volumeTrackBar.TickFrequency = 10;
            volumeTrackBar.Orientation = Orientation.Horizontal;
            volumeTrackBar.Scroll += esemenyKezelo;

            return volumeTrackBar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            song.GameEnd();
            song.sfxTestStop();

            song.MenuSongStart();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (varsfx == true)
            {
                song.sfxTestStop();
                varsfx = false;
            }
            if (var == false)
            {
                song.GameMusic();
                var = true;
            }
            else
            {
                song.GameEnd();
                var = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (var == true)
            {
                song.GameEnd();
                var = false;
            }
            if (varsfx == false)
            {
                song.sfxTest();
                varsfx = true;
            }
            else
            {
                song.sfxTestStop();
                varsfx = false;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(200, 240, 240, 240);

        }
    }
}
