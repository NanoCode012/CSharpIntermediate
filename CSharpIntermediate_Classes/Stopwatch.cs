using System;

namespace CSharpIntermediate_Classes
{
    class Stopwatch
    {
        bool _hasSetStart;
        bool _canShowDuration;
        DateTime _startTime;
        DateTime _stopTime;

        /*
        public DateTime Start {
            private get
            {
                return _startTime;
            }
            set
            {
                if (!_hasSetStart)
                {
                    _startTime = value;
                    _hasSetStart = true;
                }
                else throw new InvalidOperationException("Cannot start again until stopped once first.");
            }
        }

        public DateTime Stop
        {
            private get
            {
                return _stopTime;
            }
            set
            {
                if (_hasSetStart)
                {
                    _stopTime = value;
                    _hasSetStart = false;
                    _canShowDuration = true;
                }
                else throw new InvalidOperationException("Cannot stop again until show Duration first and started once first.");
            }
        }

        public TimeSpan Duration
        {
            get
            {
                if (_canShowDuration) {
                    _canShowDuration = false;
                    return (Stop - Start);
                }
                else throw new InvalidOperationException("Cannot show duration until started and stopped once first.");
            }
        }
        */

        public void Start()
        {
            if (!_hasSetStart)
            {
                _hasSetStart = true;
                _startTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch already started ..");
            }
        }

        public void Stop()
        {
            if (_hasSetStart)
            {
                _hasSetStart = false;
                _canShowDuration = true;
                _stopTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch already stopped ..");
            }
        }

        public TimeSpan Duration()
        {
            if (_canShowDuration)
            {
                _canShowDuration = false;
                return _stopTime - _startTime;
            }
            else
            {
                throw new InvalidOperationException("Need to be started and stopped first ..");
            }
        }



    }
}
