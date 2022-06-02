using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Lists.Double_Linked;
using Algorithms.Lists.Linked;
using Algorithms.Sorting;
namespace Algorithms
{
    internal class Program
    {
        static BubbleSort BubbleSort = new BubbleSort();
        static SelectionSort SelectionSort = new SelectionSort();   
        static InsertionSort InsertionSort = new InsertionSort();
        static MergeSort MergeSort = new MergeSort();
        static QuickSort QuickSort = new QuickSort();
        static HeapSort HeapSort = new HeapSort();
        static LinkedListSample LinkedList  =new LinkedListSample();
        static DoubleLinkedListSample DoubleLinkedList = new DoubleLinkedListSample();
        static void Main(string[] args)
        {
            //BubbleSort.Run();
            //SelectionSort.Run();
            //InsertionSort.Run();
            //MergeSort.Run();
            //QuickSort.Run();
            //HeapSort.Run();
            //LinkedList.Run();
            LinkedList.RunFindPosOfNode();
            //LinkedList.FindIntersectionOfLists();
            //DoubleLinkedList.Run();




            Console.ReadKey();
        }
    }
}
