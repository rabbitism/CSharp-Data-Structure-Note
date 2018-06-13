# Chapter 4: Basic Searching Algorithms
This Chapter looks at one aspect of the search problem: searching for a given value in a list(array).
Two fundamental ways of searching: 
* Sequential search: used when the items in the list are in random order.
* Binary search: used when the items are sorted in the list.
## SEQUENTIAL SEARCHING
```CSharp
bool SeqSearch(intp[] arr, int sValue){
    for(int index=0; index < arr.Length-1; index++){
        if(arr[index]==sValue)
            return true; 
    }
    return false;
}
```
