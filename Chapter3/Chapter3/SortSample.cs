using System;
using System.Collections.Generic;

namespace Chapter3{
    public class SortSample{
        public void BubbleSortShowcase(){
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for(int i = 0; i< 10; i++){
                nums.Insert((int)(rnd.NextDouble()*100));
            }

            Console.WriteLine("Before sorting: ");
            nums.DisplayElements();
            Console.WriteLine("During sorting: ");
            nums.BubbleSort();
            Console.WriteLine("After sorting: ");
            nums.DisplayElements();
        }

        public void SelectionSortShowcase(){
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for(int i = 0; i< 10; i++){
                nums.Insert((int)(rnd.NextDouble()*100));
            }

            Console.WriteLine("Before sorting: ");
            nums.DisplayElements();
            Console.WriteLine("During sorting: ");
            nums.SelectionSort();
            Console.WriteLine("After sorting: ");
            nums.DisplayElements();
        }

        public void InsertionSortShowcase(){
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for(int i = 0; i< 10; i++){
                nums.Insert((int)(rnd.NextDouble()*100));
            }

            Console.WriteLine("Before sorting: ");
            nums.DisplayElements();
            Console.WriteLine("During sorting: ");
            nums.InsertionSort();
            Console.WriteLine("After sorting: ");
            nums.DisplayElements();
        }
        
    }
}