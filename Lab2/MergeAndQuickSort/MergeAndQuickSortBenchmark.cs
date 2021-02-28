using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using MergeSortVsQuickSort;

namespace MergeAndQuickSort
{
    [MemoryDiagnoser]
    [Orderer((SummaryOrderPolicy.FastestToSlowest))]
    [RankColumn]
    public class MergeAndQuickSortBenchmark
    {
        private readonly QuickSort _quickSort = new QuickSort();
        private readonly MergeSort _mergeSort = new MergeSort();
        private readonly List<int> _hundredData;
        private readonly List<int> _fiveHundredData;
        private List<int> _thousandData;
        
        public MergeAndQuickSortBenchmark(RandomDataGenerator randomDataGenerator)
        {
            _hundredData = randomDataGenerator.FillWithRandomData(100);
            _fiveHundredData = randomDataGenerator.FillWithRandomData(500);
            _thousandData = randomDataGenerator.FillWithRandomData(1000);
        }
        
        [Benchmark]
        public void QuickSortWithHundredData()
        {
            _quickSort.Execute(_hundredData);
        }
        
        [Benchmark]
        public void MergeSortWithHundredData()
        {
            _mergeSort.Execute(_hundredData);
        }
        [Benchmark]
        public void QuickSortWith5HundredData()
        {
            _quickSort.Execute(_fiveHundredData);
        }
        
        [Benchmark]
        public void MergeSortWith5HundredData()
        {
            _mergeSort.Execute(_fiveHundredData);
        }
    }
}