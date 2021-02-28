using BenchmarkDotNet.Running;

namespace MergeAndQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var mergeSort = BenchmarkRunner.Run<MergeAndQuickSortBenchmark>();
            // var z = new MergeAndQuickSortBenchmark();
            // Console.WriteLine("Merge sort");
            // z.MergeSortWithHundredData();
            // Console.WriteLine();
            // Console.WriteLine("Quick sort");
            // z.QuickSortWithHundredData();
        }
    }
}