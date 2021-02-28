using System.Collections.Generic;

namespace MergeAndQuickSort
{
    public class MergeSort
    {
        public void Execute(List<int> data)
        {  
            Sort(data, 0, data.Count - 1);
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        private void Sort(List<int> data, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                var m = l + (r - l) / 2;

                // Sort first and
                // second halves
                Sort(data, l, m);
                Sort(data, m + 1, r);

                // Merge the sorted halves
                Merge(data, l, m, r);
            }
        }

        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
        private void Merge(List<int> data, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;
 
            // Create temp arrays
            var L = new int[n1];
            var R = new int[n2];
            int i, j;
 
            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = data[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = data[m + 1 + j];
 
            // Merge the temp arrays
 
            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;
 
            // Initial index of merged
            // subarry array
            int k = l;
            while (i < n1 && j < n2) {
                if (L[i] <= R[j]) {
                    data[k] = L[i];
                    i++;
                }
                else {
                    data[k] = R[j];
                    j++;
                }
                k++;
            }
 
            // Copy remaining elements
            // of L[] if any
            while (i < n1) {
                data[k] = L[i];
                i++;
                k++;
            }
 
            // Copy remaining elements
            // of R[] if any
            while (j < n2) {
                data[k] = R[j];
                j++;
                k++;
            }
        }
    }
}