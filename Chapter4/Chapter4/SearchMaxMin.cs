using System;

namespace Chapter4{
    public static class SearchMaxMin{
        public static int FindMax(int[] arr){
            int max = arr[0];
            for(int i=0; i<arr.Length; i++){ //Mistake on book
                if(arr[i] > max) //Mistake on book, should be i instead of index.
                    max= arr[i];
            }
            return max;
        }

        public static int FindMin(int[] arr){
            int min = arr[0];
            for(int i=0; i< arr.Length; i++){
                if(arr[i]<min)
                    min = arr[i];
            }
            return min;
        }
    }
}