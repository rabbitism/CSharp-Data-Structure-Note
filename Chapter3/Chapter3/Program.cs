using System;
using Generic;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            Timing sortTime = new Timing(); 
            Random rnd = new Random(100); 
            int numItems = 6000; 
            CArray theArray = new CArray(numItems); 
            for(int i = 0; i <numItems; i++)
                theArray.Insert((int)(rnd.NextDouble() * 100)); 
            sortTime.Start(); 
            theArray.SelectionSort(); 
            sortTime.Stop(); 
            Console.WriteLine("Time for Selection sort: " + sortTime.Result().TotalMilliseconds); 
            theArray.Clear(); 
            for(int i = 0; i <numItems; i++) 
                theArray.Insert((int)(rnd.NextDouble() * 100)); 
            sortTime.Start(); 
            theArray.BubbleSort(); 
            sortTime.Stop(); 
            Console.WriteLine("Time for Bubble sort: " + sortTime.Result().TotalMilliseconds); 
            theArray.Clear(); 
            for(int i = 0; i <numItems; i++) 
                theArray.Insert((int)(rnd.NextDouble() * 100)); 
            sortTime.Start(); 
            theArray.InsertionSort(); 
            sortTime.Stop(); 
            Console.WriteLine("Time for Insertion sort: " + sortTime.Result().TotalMilliseconds);

        }
    }
}
