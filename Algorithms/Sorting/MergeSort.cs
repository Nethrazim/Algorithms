using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSort : BaseSort
    {
        
        public MergeSort() : base("Merge Sort") { }

        public int[] SortMerge(int[] array, int left, int middle, int right)
        {

            int[] result = new int[right - left + 1];

            int rightIdx = middle + 1;
            int leftIdx = left;

            int auxCounter = 0;
            while (leftIdx <= middle && rightIdx <= right)
            {
                if (array[leftIdx] < array[rightIdx])
                {
                    result[auxCounter] = array[leftIdx];
                    leftIdx++;
                }
                else
                {
                    result[auxCounter] = array[rightIdx];
                    rightIdx++;
                }

                auxCounter++;
            }

            for (int i = leftIdx; i <= middle; i++)
            {
                result[auxCounter++] = array[i];
            }

            for (int i = rightIdx; i <= right; i++)
            {
                result[auxCounter] = array[i];
            }

            int j = 0;
            for (int i = left; i <= right; i++)
            {
                array[i] = result[j];
                j++;
            }
            return array;
        }

        public void SortArray(int[] array, int left, int right)
        {
            if (right - left == 0)
            {
                Console.WriteLine(array[left]);
                return;
            }
                

            for (int i = left; i <= right; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int middle = left + (right - left) / 2;

            SortArray(array, left,  middle);
            SortArray(array, middle + 1, right);
            SortMerge(array, left, middle, right);
        }

        public void Run()
        {
            base.array = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            base.Run();

            int[] clonned_array = (int[])array.Clone();

            SortArray(clonned_array, 0, clonned_array.Length - 1);
            base.DisplaySortedArray(clonned_array);
        }
    }
}
