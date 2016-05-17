using System;

namespace ExerciseOneStopwatch
{
    public class Stopwatch
    {
        private DateTime _starStopwatch { get; set; }
        private DateTime _endStopwatch { get; set; }
        private bool _isRunning = false;

        public void Start()
        {
            if (_isRunning)
                throw new ArgumentException("The STOPWATCH is currently running, please end the first instance [P].");

            _isRunning = true;
            _starStopwatch = DateTime.Now;

           
            Console.WriteLine("\nINICIO.....: {0: H:mm:ss}", _starStopwatch); // just to see the current time to compare visually.

        }

        public TimeSpan Stop()
        {
            if (!_isRunning)
                throw new ArgumentException("Please start the STOPWACTH before [S].");

            _isRunning = false;
            _endStopwatch = DateTime.Now;

            Console.WriteLine("\nFIN........: {0: H:mm:ss}", _endStopwatch);
            return (_endStopwatch - _starStopwatch);
        }

    }
}
