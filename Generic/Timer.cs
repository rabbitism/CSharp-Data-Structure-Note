using System;
using System.Diagnostics;

namespace Generic
{
    public class Timer
    {
        Stopwatch stopwatch = new Stopwatch();

        public Timer(){
            
        }

        public void Stop(){
            stopwatch.Stop();
        }

        public void Start(){
            GC.Collect();
            GC.WaitForPendingFinalizers();
            stopwatch.Start();
        }

        public string GetDuration(){
            return stopwatch.ElapsedMilliseconds.ToString();
        }
    }
}
