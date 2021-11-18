using System;
namespace StatePatternTest.StateClasses
{
    public class LockedState : StatePlayer
    {
        public LockedState()
        {
        }

        public override void clickLock()
        {
        }

        public override void clickPlay(Action nextSong)
        {
            Console.WriteLine("Pasando de Locked a estado Playing");
            _player.changeState(new PlayingState(nextSong));
        }

        public override void clickStop(Action actionStop)
        {
            Console.WriteLine("Pasando de Locked a estado Stopped");
            _player.changeState(new StoppedState(actionStop));
        }
    }
}
