using System;
using System.Diagnostics;

namespace Generic
{
    public class Timer
    {
        private TimeSpan startingTime;
        private TimeSpan duration;

        public Timer(){
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void Stop(){
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
        }

        public void Start(){
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public TimeSpan Result(){
            return duration;
        }

        public string GetDuration(){
            return duration.TotalMilliseconds.ToString();
        }
    }
}
