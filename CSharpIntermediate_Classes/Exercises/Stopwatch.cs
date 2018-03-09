using System;

namespace CSharpIntermediate_Classes
{
    class Stopwatch
    {
        bool _hasSetStart;
        bool _canShowDuration;
        DateTime _startTime;
        DateTime _stopTime;

        public void Start()
        {
            if (_hasSetStart) throw new InvalidOperationException("Stopwatch already started ..");

            _hasSetStart = true;
            _canShowDuration = false;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!_hasSetStart) throw new InvalidOperationException("Stopwatch already stopped or haven't started yet ..");

            _hasSetStart = false;
            _canShowDuration = true;
            _stopTime = DateTime.Now;
        }

        public TimeSpan Duration()
        {
            if (!_canShowDuration) throw new InvalidOperationException("Need to be started and stopped first ..");

            return (_stopTime - _startTime);
        }



    }
}
