using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class QuickSort : BaseSort
    {
        public QuickSort() : base("Quick Sort") { }
        //1 4 3 2 5 
        public int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int lowIndex = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }


            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);
                Sort(array, low, partitionIndex - 1);
                Sort(array, partitionIndex + 1, high);
            }
        }

        public void Run()
        {
            base.Run();

            int[] clonned_array = (int[])base.array;

            Sort(clonned_array, 0, clonned_array.Length - 1);

            this.DisplaySortedArray(clonned_array);
        }    
    }
}
