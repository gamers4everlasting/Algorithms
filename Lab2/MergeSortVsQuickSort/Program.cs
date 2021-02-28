using System;
using System.Collections.Generic;
using BenchmarkDotNet.Running;

namespace MergeSortVsQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var mergeSort = BenchmarkRunner.Run<MergeAndQuickSortBenchmark>();
        }
    }
}