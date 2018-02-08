using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeilauksenPistelaskuri;


namespace KeilauksenPistelaskuri
{
    public class Frame
    {

    }

    public class Pistelaskuri
    {
        private readonly Frame[] _frames = new Frame[10];

        private int _currentFrame;

        private Frame LastFrame { get { return _frames[_currentFrame - 1]; } }

        private Frame TwoFramesAgo { get { return _frames[_currentFrame - 2]; } }

        public int Score { get; private set; }

        public void BowlFrame(Frame frame)
        {
            AddMarkBonuses(frame);

            Score += frame.Total;
            _frames[_currentFrame++] = frame;
        }

        private void AddMarkBonuses(Frame frame)
        {
            if (WereLastTwoFramesStrikes())
                Score += frame.Total + frame.FirstThrow;
            else if (WasLastFrameAStrike())
                Score += frame.Total;
            else if (WasLastFrameASpare())
                Score += frame.FirstThrow;
        }

        private bool WereLastTwoFramesStrikes()
        {
            return WasLastFrameAStrike() && _currentFrame > 1 && TwoFramesAgo.IsStrike;
        }

        private bool WasLastFrameAStrike()
        {
            return _currentFrame > 0 && LastFrame.IsStrike;
        }

        private bool WasLastFrameASpare()
        {
            return _currentFrame > 0 && LastFrame.IsSpare;
        }
    }
}
