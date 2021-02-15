###### Algorithm analysis on Insertion sort.

    for (var j = 2; j < dataSize; j++)

    {

        var key = data[j];

        var i = j - 1;

        while (i > 0 && data[i] > key)

        {

            data[i + 1] = data[i];

            i--;

        }

        data[i + 1] = key; 
    }


**Logic:**\
Step 1 − If it is the first element, it is already sorted. return 1;\
Step 2 − Pick next element\
Step 3 − Compare with all elements in the sorted sub-list\
Step 4 − Shift all the elements in the sorted sub-list that is greater than the
value to be sorted\
Step 5 − Insert the value\
Step 6 − Repeat until list is sorted

running times for insertion sort:\
Worst case: Theta(n^2)\
Best case: Theta(n)

Benchmarking:

|       Method |          Mean |        Error |       StdDev | Rank | Gen 0 | Gen 1 | Gen 2 |  Allocated |
|------------- |--------------:|-------------:|-------------:|-----:|------:|------:|------:|-----------:|
| SortWithTenT |      58.33 ms |     1.150 ms |     1.230 ms |    1 |     - |     - |     - |    39.4 KB |
| SortWithHunT |   5,544.68 ms |    45.478 ms |    37.976 ms |    2 |     - |     - |     - |  390.95 KB |
| SortWithOneM | 552,103.83 ms | 1,458.987 ms | 1,293.354 ms |    3 |     - |     - |     - | 3908.16 KB |


Analysis of operations:

|       Op     |         Cost  |    Frequency |
|------------- |--------------:|-------------:|
| var declare  |         0.001 |            3 |
| assignment   |       0.00001 |        ~ 5*N |
| compare      |        0.0001 |          3*N |



