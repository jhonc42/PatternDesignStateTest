using System;
namespace StatePatternTest.StateClasses
{
    public class AudioPlayer
    {
        public int TotalSongs { get; private set; } = 10;
        public int CurrentSong { get; private set; } = 0;

        private StatePlayer _player = null;

        public AudioPlayer(StatePlayer player)
        {
            changeState(player);
        }

        public void changeState(StatePlayer newState)
        {
            _player = newState;
            _player.SetPlayer(this);
        }

        public void startPlaying()
        {
            _player.clickPlay(()=> this.CurrentSong += 1);
            Console.WriteLine($"playing song number {this.CurrentSong}");
        }
        public void stopPlaying()
        {
            _player.clickStop(() => this.CurrentSong = 0);
            Console.WriteLine($"current song comes back to {this.CurrentSong}");

        }
        public void lockPlayer()
        {
            _player.clickLock();
        }


        public void playNextSong()
        {
            startPlaying();
        }



    }
}
