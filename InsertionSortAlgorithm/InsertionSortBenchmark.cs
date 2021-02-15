using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace InsertionSort
{
    [MemoryDiagnoser]
    [Orderer((SummaryOrderPolicy.FastestToSlowest))]
    [RankColumn]
    public class InsertionSortBenchmark
    {
        private static readonly InsertionSort Sort = new InsertionSort();

        [Benchmark]
        public void SortWithTenT()
        {
            Sort.Sort(10000);
        }
        [Benchmark]
        public void SortWithHunT()
        {
            Sort.Sort(100000);
        }
        [Benchmark]
        public void SortWithOneM()
        {
            Sort.Sort(1000000);
        }
    }
}