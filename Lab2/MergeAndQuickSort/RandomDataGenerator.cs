using System;
using System.Collections.Generic;

namespace MergeAndQuickSort
{
    public class RandomDataGenerator
    {
        public RandomDataGenerator()
        {
            
        }
        public int[] FillWithRandomData(int dataLength)
        {
            var rnd = new Random();
            var localSize = 0;
            var rndList = new int[dataLength];
            while (localSize < dataLength)
            {
                rndList[localSize] = rnd.Next(0, dataLength);
                localSize++;
            }

            return rndList;
        }
    }
}