#Anlysis of QUICK and MERGE sort

## **Analysis of Quick Sort**

**Time**: T(n) = T(k) + T(n-k-1) + θ(n)\
**Worst Case**: θ(n^2)\
**Best Case**: θ(NLogN)\
**Average Case**: θ(NLogN)\
**Algorithm**: Divide and conquer

_The key process in quickSort is partition().\
Target of partitions is, given an array and an element x of array as pivot,\
put x at its correct position in sorted array and put all smaller elements (smaller than x) before x, and put all greater elements (greater than x) after x.\
All this should be done in linear time._

 _This function takes last element as pivot, places
the pivot element at its correct position in sorted
array, and places all smaller (smaller than pivot)
to left of pivot and all greater elements to right
of pivot_ 


```
partition (arr[], low, high)
{
    // pivot (Element to be placed at right position)
    pivot = arr[high];

    i = (low - 1)  // Index of smaller element and indicates the 
                   // right position of pivot found so far

    for (j = low; j <= high- 1; j++)
    {
        // If current element is smaller than the pivot
        if (arr[j] < pivot)
        {
            i++;    // increment index of smaller element
            swap arr[i] and arr[j]
        }
    }
    swap arr[i + 1] and arr[high])
    return (i + 1)
}
```

_QuickSort can be implemented in different ways by changing the choice of pivot,\
so that the worst case rarely occurs for a given type of data.\
However, merge sort is generally considered better when data is huge and stored in external storage._ 


## Analysis of Merge Sort
**Time**: T(n) = 2T(n/2) + θ(n)\
**Worst Case**: θ(nLogn)\
**Best Case**: θ(nLogn)\
**Average Case**: θ(nLogn)\
**Algorithm**: Divide and conquer\
**Auxiliary Space**: O(n)

**Drawbacks of Merge Sort:**\
*Slower comparative to the other sort algorithms for smaller tasks.\
*Merge sort algorithm requires additional memory space of 0(n) for the temporary array.\
*It goes through the whole process even if the  array is sorted.

**merge sort always divides the array into two halves and takes linear time to merge two halves**\

**It divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves. The merge() function is used for merging two halves. The merge(arr, l, m, r) is a key process that assumes that arr[l..m] and arr[m+1..r] are sorted and merges the two sorted sub-arrays into one.**

```
MergeSort(arr[], l,  r)
If r > l
     1. Find the middle point to divide the array into two halves:  
             middle m = l+ (r-l)/2
     2. Call mergeSort for first half:   
             Call mergeSort(arr, l, m)
     3. Call mergeSort for second half:
             Call mergeSort(arr, m+1, r)
     4. Merge the two halves sorted in step 2 and 3:
             Call merge(arr, l, m, r)
             
```

## Merge vs Quick sort

1) Difference in worst case θ(nLogn) vs θ(n^2)
2) Merge sort requires extra space O(n)
3) Merge sort is best for linked list sorting.

|                    Method |       Mean |      Error |     StdDev |     Median | Rank |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |-----------:|-----------:|-----------:|-----------:|-----:|---------:|------:|------:|----------:|
|  QuickSortWithHundredData |   6.104 μs |  0.2703 μs |  0.7625 μs |   5.860 μs |    1 |        - |     - |     - |         - |
|  MergeSortWithHundredData |  10.395 μs |  0.5380 μs |  1.5864 μs |  10.010 μs |    2 |  13.7939 |     - |     - |   21648 B |
| MergeSortWith5HundredData |  80.298 μs |  3.3278 μs |  9.8122 μs |  79.077 μs |    3 |  76.7822 |     - |     - |  120432 B |
| QuickSortWith5HundredData | 136.544 μs |  4.2718 μs | 12.3933 μs | 134.496 μs |    4 |        - |     - |     - |         - |
| MergeSortWithThousandData | 166.486 μs |  4.5801 μs | 13.3604 μs | 165.830 μs |    5 | 161.1328 |     - |     - |  252960 B |
| QuickSortWithThousandData | 490.958 μs | 12.8048 μs | 37.3523 μs | 483.955 μs |    6 |        - |     - |     - |         - |


Conclusion:\
Merge sort requires additional space where as quick sort doesn't.
The input data there is the better Quick sort performed
The more input data the better Merge sort performes although it requires more memory space.