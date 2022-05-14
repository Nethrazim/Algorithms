using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// O(n2)
namespace Algorithms.Sorting
{
    public class BubbleSort : BaseSort
    {
        //|4,3,2,1|
        //|3,4,2,1|
        //|3,2,4,1|
        //|3,2,1,4| - First foreach (3 - iterations
        //|2,3,1,4|
        //|2,1,3,4| - Second foreach( 2 - iterations)
        //|1,2,3,4| - Third foreach( 1 - iteration)
        public void Run()
        {
            base.Run();

            int[] cloned_array = (int[])array.Clone();

            for (int i = 0; i < cloned_array.Length; i++)
            {
                for (int j = 0; j < cloned_array.Length - 1; j++)
                {
                    if (cloned_array[j] > cloned_array[j + 1])
                    {
                        int t = cloned_array[j];
                        cloned_array[j] = cloned_array[j+1];
                        cloned_array[j+1] = t;
                    }
                }
            }

            Console.Write("Bubble Sorted with Foreach() = ");
            foreach (int i in cloned_array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Bubble Sorted with While() = ");
            cloned_array = (int[])array.Clone();

            int idx = 0;
            int idm = 0;
            while (idx < cloned_array.Length)
            {
                idm = 0;
                while (idm < cloned_array.Length - 1)
                {
                    if (cloned_array[idm] > cloned_array[idm + 1])
                    {
                        int t = cloned_array[idm];
                        cloned_array[idm] = cloned_array[idm + 1];
                        cloned_array[(idm + 1)] = t;
                    }
                    idm++;
                }
                idx++;
            }

            foreach (int i in cloned_array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            cloned_array = (int[])array.Clone();

            //optimized version
            for (int i = 0; i < cloned_array.Length; i++)
            {
                for (int j = 0; j < cloned_array.Length - 1 - i; j++)
                {
                    if(cloned_array[j] > cloned_array[j +1])
                    {
                        int aux = cloned_array[j];
                        cloned_array[j] = cloned_array[j + 1];
                        cloned_array[j + 1] = aux;
                    }
                }
            }

            Console.Write("Bubble Sorted but optmized = ");
            foreach (int i in cloned_array) Console.Write(i + " ");
            
        }
    }
}
