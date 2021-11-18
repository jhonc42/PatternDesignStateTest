using System;
using StatePatternTest.StateClasses;

namespace StatePatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerContext = new AudioPlayer(new LockedState());
            playerContext.startPlaying();
            playerContext.playNextSong();
            playerContext.stopPlaying();
            playerContext.lockPlayer();
            playerContext.startPlaying();
            playerContext.playNextSong();
            playerContext.playNextSong();
            playerContext.stopPlaying();
        }
    }
}
