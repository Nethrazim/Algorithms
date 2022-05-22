﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algorithms.Sorting;
namespace Algorithms
{
    internal class Program
    {
        static BubbleSort BubbleSort = new BubbleSort();
        static SelectionSort SelectionSort = new SelectionSort();   
        static InsertionSort InsertionSort = new InsertionSort();
        static MergeSort MergeSort = new MergeSort();
        static void Main(string[] args)
        {
            //BubbleSort.Run();
            //SelectionSort.Run();
            //InsertionSort.Run();
            MergeSort.Run();



            Console.ReadKey();
        }
    }
}
