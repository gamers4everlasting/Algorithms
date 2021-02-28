using BenchmarkDotNet.Running;
using MergeSortVsQuickSort;

namespace MergeAndQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var mergeSort = BenchmarkRunner.Run<MergeAndQuickSortBenchmark>();
        }
    }
}