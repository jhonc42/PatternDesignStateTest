using System;
namespace StatePatternTest.StateClasses
{
    public abstract class StatePlayer
    {
        protected AudioPlayer _player;

        public StatePlayer()
        {
        }

        public void SetPlayer(AudioPlayer player)
        {
            _player = player;
        }

        public abstract void clickLock();

        public abstract void clickPlay( Action nextSong);
        public abstract void clickStop(Action actionStop);
    }
}
