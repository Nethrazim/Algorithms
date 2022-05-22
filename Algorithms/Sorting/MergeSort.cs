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
        public void SortArrayWithIndexes(int[] array, int left, int right)
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

            SortArrayWithIndexes(array, left, middle);
            SortArrayWithIndexes(array, middle + 1, right);
            SortMerge(array, left, middle, right);
        }

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

        public int[] Merge(int[] array)
        {
            int middle = array.Length / 2;
            if (middle <= 0) return array;

            int[] left = array.Take(middle).ToArray();
            int[] right = array.Skip(middle).ToArray();
            
            return Sort(Merge(left), Merge(right));
        }

        public int[] Sort(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            
            int i = 0;
            int j = 0;
            int idx = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[idx] = left[i];
                    i++;
                }
                else
                {
                    result[idx] = right[j];
                    j++;
                }
                idx++;
            }

            for (int k = i; k < left.Length; k++)
            {
                result[idx++] = left[k];
            }

            for (int k = j; k < right.Length; k++)
            {
                result[idx++] = right[k];
            }

            return result;
        }

        public void Run()
        {
            base.array = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            base.Run();

            int[] clonned_array = (int[])array.Clone();

            base.DisplaySortedArray(Merge(clonned_array));
        }
    }
}
