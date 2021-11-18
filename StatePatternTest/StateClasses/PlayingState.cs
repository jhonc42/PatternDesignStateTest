using System;
namespace StatePatternTest.StateClasses
{
    public class PlayingState : StatePlayer
    {
        public PlayingState(Action nextSong)
        {
            clickPlay(nextSong);
        }

        public override void clickLock()
        {
            Console.WriteLine("Pasando de Playing a estado Lock");
            _player.changeState(new LockedState());
        }

        public override void clickPlay(Action nextSong)
        {
            nextSong();
        }

        public override void clickStop(Action actionStop)
        {
            Console.WriteLine("Pasando de playing a estado Stopped");
            _player.changeState(new StoppedState(actionStop));
        }
    }
}
