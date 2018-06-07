# Chapter 2: Arrays and ArrayLists

`Array` `ArrayList`

## ARRAY BASICS 
### Declaring and Initializing Arrays

syntax: 
```CSharp
type[] array-name;
```
Example:
```CSharp
string[] names;
```
Declare together with initialization
```CSharp
string[] names = new string[10];
int[] numbers = new int[]{1,2,3,4,5};
```

### Setting and Accessing Array Elements
Elements are stored in an array either by direct access or by calling the Array class method `SetValue`.
```Csharp
Names[2] = "Raymond";
names.SetValue[2, "Raymond"];
```
Array elements are accessed either by direct access or by calling the Array class `GetValue` method.
```CSharp
myName = names[2];
monthSales = sales.GetValue[19];
```

### Methods and Properties for Retrieving Array Metadata
* `Length`: Returns the total number of elements in all dimensions of an array.
* `GetLength`: Returns the number of elements in specified dimension of an array.
* `Rank`: Returns the number of dimensions of an array.
* `GetType`: Returns the `Type` of the current array instance.

### Multidimensional Arrays
In C#, an array can have up to 32 dimensions, thou arrays with more than three dimensions are **very rare and very confusing**. Two-dimensional arrays are often used to model matrices. 
```csharp
int[,] grades = new int[4,5]
int[,] grades = new int[,]{ {1,82,74,89,100},
                            {2,93,96,85,86},
                            {3,83,72,95,89},
                            {4,91,98,79,88}};
grade = Grades[2,2];//Access
Grades[2,2] = 99;//Store
grade = Grades.GetValue[0,2]; //GetValue
```
You can't use `SetValue` method with a multidimensional array because the method only accepts two arguments: a value and a single index.

### Parameter Arrays
A parameter array is specified in the parameter list of a method definition by using the keword `ParamArray`. When defining a method using a parameter array, the parameter array arguments have to be supplied **last** in the parameter list. 
```csharp
static int sumNums(params int[] nums){
    int sum = 0;
    for(int i=0; i<=nums.GetUpperBound(0); i++)
        sum += nums[i];
    return sum;
}

total = sumNums(1, 2, 3);
total = sumNums(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
```

### Jagged Array
A jagged array is an array of arrays where each row of an array is made up of an array. Each dimension of a jagged array is a one-dimensional array.
Declaration: 
```csharp
int[][] jagged = new int[12][];
```
Assign values to individual element:
```csharp
jagged[0][0] = 23; //assign the first element of the first array
jagged[7][5] = 45; //assign the sixth element of the eighth array
```

### ArrayList Class
Used when the number of elements in an array can grow larger, smaller. Can be more efficient than using ReDim Preserver with a standard array.
An `ArrayList` stores objects using the `Object` type.

### Members of the `ArrayList` Class
* `Add()`: Adds an element to the ArrayList. 
* `AddRange()`: Adds the elements of a collection to the end of the ArrayList. 
* `Capacity`: Stores the number of elements the ArrayList can hold. 
* `Clear()`: Removes all elements from the ArrayList. 
* `Contains()`: Determines if a speciﬁed item is in the ArrayList. 
* `CopyTo()`: Copies the ArrayList or a segment of it to an array. 
* `Count`: Returns the number of elements currently in the ArrayList. 
* `GetEnumerator()`: Returns an enumerator to iterate over the ArrayList. 
* `GetRange()`: Returns a subset of the ArrayList as an ArrayList. 
* `IndexOf()`: Returns the index of the ﬁrst occurrence of the speciﬁed item. 
* `Insert()`: Insert an element into the ArrayList at a speciﬁed index. 
* `InsertRange()`: Inserts the elements of a collection into the ArrayList starting at the speciﬁed index.
* `Item()`: Gets or sets an element at the speciﬁed index. 
* `Remove()`: Removes the ﬁrst occurrence of the speciﬁed item. 
* `RemoveAt()`: Removes an element at the speciﬁed index. 
* `Reverse()`: Reverses the order of the elements in the ArrayList. 
* `Sort()`: Alphabetically sorts the elements in the ArrayList. 
* `ToArray()`: Copies the elements of the ArrayList to an array. 
* `TrimToSize()`: Sets the capacity of the ArrayList to the number of elements in the ArrayList.
