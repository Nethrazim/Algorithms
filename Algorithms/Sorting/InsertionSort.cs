using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    // O(n2)
    public class InsertionSort : BaseSort
    {
        public InsertionSort() : base("Insertion Sort") { }
        //Treats the array in two halves
        //Takes the second half and insert it on the right sport in the first half

        //|5,4,3,2,1

        /*4 5 3 2 1
         *4 3 5 2 1
         *3 4 5 2 1
         *3 4 2 5 1
         *3 2 4 5 1 
         *2 3 4 5 1 
         *2 3 4 1 5 
         *2 3 1 4 5 
         *2 1 3 4 5
         *1 2 3 4 5
         */
        public override void Run()
        {
            //You can override array in the base class
           // array = new int[] { 2, 3, -3, -5, 1, 3 };

            base.Run();

            int[] cloned_array = (int[])array.Clone();
            bool ins;

            for (int i = 1; i < cloned_array.Length; i++)
            {
                int item = cloned_array[i];
                ins = false;
                for (int j = i - 1; j >= 0 && !ins;)
                {
                    if (item < cloned_array[j])
                    {
                        cloned_array[j + 1] = cloned_array[j];
                        j--;
                        cloned_array[j + 1] = item;
                    }
                    else
                    {
                        ins = true;
                    }
                }
            }

            this.DisplaySortedArray(cloned_array);
        }
    }
}
