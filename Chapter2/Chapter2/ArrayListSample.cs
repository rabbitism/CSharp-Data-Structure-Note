using System;
using System.Collections;

namespace Chapter2{

    public static class ArrayListSample{
        public static void Sample1(){
            ArrayList grades = new ArrayList();
            grades.Add(100);
            grades.Add(84);
            int position;
            position = grades.Add(77); //return an interger indicating the position in the Array List where the element was added.
            Console.WriteLine("The grade 77 was added at position: {0}", position);

            int total = 0;
            double average = 0.0;
            foreach( object grade in grades){
                total += (int)grade;
            }
            average = total/grades.Count;
            Console.WriteLine("The average grade is: {0}", average);

            //Insert
            grades.Insert(1,99);
            grades.Insert(3,80);

            //Check Capacity and Count
            Console.WriteLine("The current capcacity of grades is: {0}", grades.Capacity);
            Console.WriteLine("The number of grades in grades is: {0}", grades.Count);

            if(grades.Contains(54)){
                grades.Remove(54);
                Console.WriteLine("54 is removed");
            }
            else{
                Console.WriteLine("Object not in ArrayList.");
            }

        }
        
    }
}
