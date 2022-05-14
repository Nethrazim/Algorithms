using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algorithms.Sorting;
namespace Algorithms
{
    internal class Program
    {
        static BubbleSort bubbleSort = new BubbleSort();
        static void Main(string[] args)
        {
            bubbleSort.Run();

            Console.ReadKey();
        }
    }
}
