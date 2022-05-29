using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class BaseSort
    {
        public readonly string algorithm_name;
        public BaseSort(string algo_name) {
            algorithm_name = algo_name;
        }

        public int[] array = new int[] { 5, 4, 3, 2, 1 };

        public virtual void Run()
        {
            Console.WriteLine("Original array = ");
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine();
        }

        public void DisplaySortedArray(int[] arr, string step = null)
        {
            Console.Write(algorithm_name + " ");
            if (step != null) Console.Write("Step = " + step);
            Console.Write(" : ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
