using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    //O(nlogn)
    // Heapify is O(Logn)
    // create and build heap is O(n)
    public class HeapSort : BaseSort
    {
        public HeapSort() : base("Heap Sort") { }

        void heapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                //3 -> 0
                heapify(arr, n, i);
            }
            this.DisplaySortedArray(arr);
            for (int i = n - 1; i > 0; i--)
            {
                int swap = arr[0];
                arr[0] = arr[i];
                arr[i] = swap;
                heapify(arr, i, 0);
                this.DisplaySortedArray(arr, step: $"Max Heapify {i - (i - 1)}");
            }
        }
        //       9
        //    8     7
        //  6   5 4   3
        //2   1


        // 0 1 2 3 4 5 6 7 8 
        // 9 8 7 6 5 4 3 2 1
        void heapify(int[] arr, int n, int i)
        {
            int largest = i;//3
            int left = 2 * i + 1;//7
            int right = 2 * i + 2;//8
            
            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }


        public void Run()
        {
            this.array = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            base.Run();
            int[] cloned_array = (int[])base.array;
            heapSort(cloned_array, cloned_array.Length);
            this.DisplaySortedArray(cloned_array);
        }
    }
}
