using System;
using System.Collections.Generic;

namespace InsertionSort
{
    public class InsertionSort
    {


        public List<int> Sort(int dataSize)
        {
            var data = FillWithRandomData(dataSize);

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

            return data;
        }

        private static List<int> FillWithRandomData(int size)
        {
            var rnd = new Random();
            var localSize = size;
            var rndList = new List<int>(size);
            while (localSize > 0)
            {
                rndList.Add(rnd.Next(0, size));
                localSize--;
            }

            return rndList;
        }
    }

}
