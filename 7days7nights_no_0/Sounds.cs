using WMPLib;

namespace _7days7nights_no_0
{
    public class Sounds
    {
        private static WindowsMediaPlayer gameMedia;
        private static WindowsMediaPlayer shootMedia;
        private static WindowsMediaPlayer shootMedia2;
        private static WindowsMediaPlayer enemyDieMedia;
        private static WindowsMediaPlayer playerDieMedia;
        private static WindowsMediaPlayer MenuMusic;
        private static WindowsMediaPlayer InGameSongs;



        public static int volume;
        public static int volumesfx;

        public Sounds()
        {
            gameMedia = new WindowsMediaPlayer();
            shootMedia = new WindowsMediaPlayer();
            shootMedia2 = new WindowsMediaPlayer();
            enemyDieMedia = new WindowsMediaPlayer();
            playerDieMedia = new WindowsMediaPlayer();
            MenuMusic = new WindowsMediaPlayer();
            InGameSongs = new WindowsMediaPlayer();

            gameMedia.settings.volume = volume;
            MenuMusic.settings.volume = volume;
            InGameSongs.settings.volume = volume;

            shootMedia.settings.volume = volumesfx;
            shootMedia2.settings.volume = volumesfx;

            enemyDieMedia.settings.volume = volumesfx;
            playerDieMedia.settings.volume = volumesfx;


            gameMedia.settings.autoStart = false;
            gameMedia.URL = "songs\\GameSongs.mp3";

            MenuMusic.settings.autoStart = false;
            MenuMusic.URL = "songs\\MenuMusic.mp3";

            InGameSongs.settings.autoStart = false;
            InGameSongs.URL = "songs\\InGameSongs.mp3";

            shootMedia.settings.autoStart = false;
            shootMedia.URL = "songs\\Gunshot_Sound_Effect.mp3";

            enemyDieMedia.settings.autoStart= false;
            enemyDieMedia.URL = "songs\\EnemyDie.mp3";

            playerDieMedia.settings.autoStart = false;
            playerDieMedia.URL = "songs\\nomnom.mp3";

            shootMedia2.settings.autoStart = false;
            shootMedia2.URL = "songs\\ShootSongs.mp3";

        }

        public void MenuSongStart()
        {
            MenuMusic.controls.play();
            MenuMusic.settings.setMode("loop", true);
        }



        public void MenuSongStop()
        {
            MenuMusic.controls.stop();
        }
        public void InGameSongsStart()
        {
            InGameSongs.controls.play();
            InGameSongs.settings.setMode("loop", true);
        }
        public void InGameSongsStop()
        {
            InGameSongs.controls.stop();
        }

        public void GameMusic()
        {
            gameMedia.controls.play();
            gameMedia.settings.setMode("loop", true);
        }

        public void GameEnd()
        {
            gameMedia.controls.stop();
        }

        public void ShootSound()
        {
            shootMedia.controls.play();
        }
        public void ShootSoundstop()
        {
            shootMedia.controls.stop();
        }
        public void sfxTest()
        {
            shootMedia2.controls.play();
            shootMedia2.settings.setMode("loop", true);
        }
        public void sfxTestStop()
        {
            shootMedia2.controls.stop();
            shootMedia2.settings.setMode("loop", false);
        }
        public void EnemyDieSound()
        {
            enemyDieMedia.controls.play();
        }

        public void PlayerDieSound()
        {
            playerDieMedia.controls.play();
        }


        public void MusicVolumeSet(int VolumeMusic)
        {
            volume = VolumeMusic;
            gameMedia.settings.volume = VolumeMusic;
            MenuMusic.settings.volume = VolumeMusic;
            InGameSongs.settings.volume = VolumeMusic;
        }
        public void VolumeSFXSet(int SETVolumesfx)
        {
            volumesfx = SETVolumesfx;
            shootMedia.settings.volume = SETVolumesfx;
            shootMedia2.settings.volume = SETVolumesfx;
            enemyDieMedia.settings.volume = SETVolumesfx;
            playerDieMedia.settings.volume = SETVolumesfx;
        }
        public int MusicVolumeGet()
        {
            return volume;
        }
        public int SfxVolumeGet()
        {
            return volumesfx;
        }
    }
}
