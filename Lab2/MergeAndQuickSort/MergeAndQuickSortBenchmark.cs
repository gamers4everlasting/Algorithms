using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace MergeAndQuickSort
{
    [MemoryDiagnoser]
    [Orderer((SummaryOrderPolicy.FastestToSlowest))]
    [RankColumn]
    public class MergeAndQuickSortBenchmark
    {
        private readonly RandomDataGenerator rnd = new RandomDataGenerator();
        private readonly MergeSort _mergeSort = new MergeSort();
        private readonly int[] _hundredData;
        private readonly int[] _fiveHundredData;
        private readonly int[] _thousandData;
        
        public MergeAndQuickSortBenchmark()
        {
            _hundredData = rnd.FillWithRandomData(100);
            _fiveHundredData = rnd.FillWithRandomData(500);
            _thousandData = rnd.FillWithRandomData(1000);
        }
        
        [Benchmark]
        public void QuickSortWithHundredData()
        {
            QuickSort.Execute(_hundredData);
        }
        
        [Benchmark]
        public void MergeSortWithHundredData()
        {
            _mergeSort.Execute(_hundredData);
        }
        [Benchmark]
        public void QuickSortWith5HundredData()
        {
            QuickSort.Execute(_fiveHundredData);
        }
        
        [Benchmark]
        public void MergeSortWith5HundredData()
        {
            _mergeSort.Execute(_fiveHundredData);
        }
        [Benchmark]
        public void QuickSortWithThousandData()
        {
            QuickSort.Execute(_thousandData);
        }
        
        [Benchmark]
        public void MergeSortWithThousandData()
        {
            _mergeSort.Execute(_thousandData);
        }
    }
}