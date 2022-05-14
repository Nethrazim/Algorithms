using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class BaseSort
    {
        public int[] array = new int[] { 5, 4, 3, 2, 1 };

        public virtual void Run()
        {
            Console.WriteLine("Original array = ");
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
