using System;
using System.Collections.Generic;

namespace MergeSortVsQuickSort
{
    public class RandomDataGenerator
    {
        public List<int> FillWithRandomData(int dataLength)
        {
            var rnd = new Random();
            var localSize = dataLength;
            var rndList = new List<int>(dataLength);
            while (localSize > 0)
            {
                rndList.Add(rnd.Next(0, dataLength));
                localSize--;
            }

            return rndList;
        }
    }
}