using System;
using System.Diagnostics;

namespace Generic
{
    public class Timer
    {
        TimeSpan startingTime;
        TimeSpan duration;

        public Timer(){
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void Stop(){
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
        }

        public void startTime(){
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
