using System;
using System.Collections.Generic;
using Generic;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Timer timer = new Timer();
            timer.Start();
            
            List<int> variable = new List<int>();
            for(int i = 0; i< 10000; i++){
                for(int j = 0; j<i; j++){
                    variable.Add(i*j);
                }
            }


            timer.Stop();

            ConsolePrinter.Print(timer.GetDuration());

        }
    }
}
