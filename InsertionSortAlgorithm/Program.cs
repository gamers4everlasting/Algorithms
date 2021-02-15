
using BenchmarkDotNet.Running;

namespace InsertionSort
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            var s = BenchmarkRunner.Run<InsertionSortBenchmark>();
        }

    }
}