using System;
using Generic;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Timer timer = new Timer();
            timer.Start();
            SortSample.BubbleSortShowcase();
            timer.Stop();
            string a = timer.GetDuration();
            timer.Start();
            SortSample.SelectionSortShowcase();
            timer.Stop();
            string b = timer.GetDuration();
            timer.Start();
            SortSample.InsertionSortSample();
            timer.Stop();
            string c = timer.GetDuration();
            Console.WriteLine("Bubble Sort: "+a);
            Console.WriteLine("Selection Sort: "+b);
            Console.WriteLine("Insertion Sort: "+c);

        }
    }
}
