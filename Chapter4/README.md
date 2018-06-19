# Chapter 4: Basic Searching Algorithms
This Chapter looks at one aspect of the search problem: searching for a given value in a list(array).
Two fundamental ways of searching: 
* Sequential search: used when the items in the list are in random order.
* Binary search: used when the items are sorted in the list.
## SEQUENTIAL SEARCHING
```CSharp
bool SeqSearch(intp[] arr, int sValue){
    for(int index=0; index < arr.Length-1; index++){ //I think this is error in notebook, it should be <arr.Length
        if(arr[index]==sValue)
            return true; 
    }
    return false;
}
```
or return index of target
```CSharp
int SeqSearch(int[] arr, int sValue){
    for(int index=0; index<arr.Length-1; index++){ //Same error as above
        if(arr[index]==sValue)
            return index;
    }
    return -1;
}
```

### Searching for Minimum and Maximum Values
1. Assign the first element of the array to a variable as the minimum value.
2. Begin looping through the array, comparing each successive array element with the minimum value variable.
3. If the currently accessed array element is less than the minimum value, assign this element to the minimum value variable.
4. Continue until the last array element is accessed.
5. The minimum value is stored in the variable. 
