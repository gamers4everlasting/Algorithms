using System;
using System.Collections.Generic;

namespace MergeAndQuickSort
{
    public static class QuickSort
    {
        public static void Execute(int[] data)
        {
            
            Console.WriteLine($"Executing Quick sort with {data.Length} data size");
            Sort(data, 0, data.Length - 1);
            // foreach (var d in data)
            // {
            //     Console.Write(d + " ");
            // }
        }

        private static void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                
                Console.WriteLine($"Figuring out a partition");
                int pivot = Partition(array, low, high);
                if (pivot > 1) {
                    Console.WriteLine($"Recursively sort the left array");
                    Sort(array, low, pivot - 1);
                }
                if (pivot + 1 < high) {
                    Console.WriteLine($"Recursively sort the right array");
                    Sort(array, pivot + 1, high);
                }
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
        private static int Partition(int[] A, int left, int right)
        {
            if(left > right) return -1; 

            int end = left; 

            int pivot = A[right];    // choose last one to pivot, easy to code
            for(int i= left; i< right; i++)
            {
                if (A[i] < pivot)
                {
                    swap(A, i, end);
                    end++; 
                }
            }

            swap(A, end, right);

            return end; 
        }

        private static void swap(int[] A, int left, int right)
        {
            int tmp = A[left];
            A[left] = A[right];
            A[right] = tmp; 
        }
    }
}