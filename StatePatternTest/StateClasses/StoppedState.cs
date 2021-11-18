using System;

namespace StatePatternTest.StateClasses
{
    public class StoppedState : StatePlayer
    {
        public StoppedState(Action actionStop)
        {
            clickStop(actionStop);
        }

        public override void clickLock()
        {
            Console.WriteLine("Pasando de stoppetd a estado Lock");
            _player.changeState(new LockedState());
        }

        public override void clickPlay(Action nextSong)
        {
            Console.WriteLine("Pasando de stopped a estado Playing");
            _player.changeState(new PlayingState(nextSong));
        }

        public override void clickStop(Action actionStop)
        {
            actionStop();
        }
    }
}