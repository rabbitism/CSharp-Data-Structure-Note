using System;
using System.Collections.Generic;
using Generic;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an array, initialize, and get type.
            int[] numbers;
            numbers = new int[]{0,1,2,3,4};
            Type arrayType = numbers.GetType();
            if(arrayType.IsArray) Console.WriteLine("The array type is: {0}", arrayType);
            else Console.WriteLine("Not an array");

            //Declare a two dimensional array and initialize.
            int[,] grades = new int[,]{ {1,82,74,89,100},
                                        {2,93,96,85,86},
                                        {3,83,72,95,89},
                                        {4,91,98,79,88}};
            int last_grade = grades.GetUpperBound(1);
            double average = 0.0;
            int total;
            int last_student = grades.GetUpperBound(0);
            for(int row = 0; row<=last_student; row++){
                total = 0;
                for(int col = 0; col <= last_grade; col++){
                    total+= grades[row,col];
                    average = total/last_grade;
                    Console.WriteLine("Average: "+average);
                }
            }

            ConsolePrinter.Print(sumNums(1,2,3,4,5,6,7,8,9,10));

            int[] Jan = new int[31];
            int[] Feb = new int[29];
            int[][] sales = new int[][]{Jan, Feb}; //There is a type on the sample code
            int month, day, total2;
            double average2 = 0.0;
            sales[0][0] = 41; 
            sales[0][1] = 30; 
            sales[0][0] = 41; 
            sales[0][1] = 30; 
            sales[0][2] = 23; 
            sales[0][3] = 34; 
            sales[0][4] = 28; 
            sales[0][5] = 35; 
            sales[0][6] = 45; 
            sales[1][0] = 35; 
            sales[1][1] = 37; 
            sales[1][2] = 32; 
            sales[1][3] = 26; 
            sales[1][4] = 45; 
            sales[1][5] = 38; 
            sales[1][6] = 42;
            for(month = 0; month <=1; month++){
                total2 = 0;
                for(day = 0; day<=6; day++){
                    total2 += sales[month][day];
                }
                average2 = total2/7;
                Console.WriteLine("Average sales for month: "+ month+ ": " + average2);
            }
            ConsolePrinter.Print(sales);

            ArrayListSample.Sample1();
        }

        static int sumNums(params int[] nums){
            int sum = 0;
            for(int i = 0; i<= nums.GetUpperBound(0); i++){
                sum += nums[i];
                
            }
            return sum;
        }
    }
}
