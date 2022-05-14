using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    // O(n2)
    public class SelectionSort : BaseSort
    {
        public override void Run()
        {
            base.Run();

            int[] cloned_array = (int[])array;

            for (int i = 0; i < cloned_array.Length - 1 ; i++)
            {
                int? min = null;
                int auxj = 0;
                for (int j = i + 1; j < cloned_array.Length; j++)
                {
                    if (cloned_array[i] > cloned_array[j])
                    {
                        min = cloned_array[j];
                        auxj = j;
                    }
                }

                if (min != null)
                {
                    int aux = cloned_array[i];
                    cloned_array[i] = min.Value;
                    cloned_array[auxj] = aux;
                }
                else
                {
                    break;
                }
                
            }

            Console.Write("Select Sort algorithm =");
            foreach (int i in cloned_array) Console.Write(i + " ");
        }
    }
}
