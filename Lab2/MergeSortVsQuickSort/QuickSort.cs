using System.Collections.Concurrent;
using System.Collections.Generic;

namespace MergeSortVsQuickSort
{
    public class QuickSort
    {
        public void Execute(List<int> data)
        {
            Sort(data, 0, data.Count - 1);
        }

        private void Sort(IList<int> data, int left, int right)
        {
            if (left < right)
            {
                var pivot = Partition(data, left, right);
                
                if (pivot > 1) 
                    Sort(data, left, pivot - 1);

                if (pivot + 1 < right)
                    Sort(data, pivot + 1, right);
            }
        }

        /// <summary>
        ///  This function takes first element as pivot, places 
        ///  the pivot element at its correct position in sorted 
        ///  array, and places all smaller (smaller than pivot) 
        ///  to left of pivot and all greater elements to right of pivot 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private int Partition(IList<int> data, int left, int right)
        {
            var pivot = data[left];
            while (true)
            {
                while (data[left] < pivot)
                    left++;

                while (data[right] > pivot) 
                    right--;

                if (left < right)
                {
                    var temp = data[right];
                    data[right] = data[left];
                    data[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}