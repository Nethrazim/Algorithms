using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.Double_Linked
{
    public class DoubleLinkedList<T>
    {
        public Node<T> Current;
        public Node<T> Head { get; set; }

        public void Add(T[] values)
        {
            foreach (T value in values)
            {
                Add(new Node<T>() { Value = value });
            }
        }
        public void Add(Node<T> node)
        {
            if (Head == null)
            {
                Head = node;
                Current = Head;
            }
            else
            {
                Node<T> last = Last();
                last.Next = node;
                node.Previous = last;
                Current = node;
            }
        }

        public Node<T> Last()
        {
            if (Head == null)
                return null;

            if (Head.Next == null)
            {
                return Head;    
            }

            Node<T> node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }

            return node;
                
        }

        public void Parse()
        {
            if (Head == null)
                return;
            Node<T> node = Head;
            while (node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Next;
            }

            Console.WriteLine();
        }

        public void ParseInverse()
        {
            Node<T> node = Last();

            do
            {
                Console.Write(node.Value + " ");
                node = node.Previous;
            } while (node != null);
            Console.WriteLine();
        }
    }


    public class DoubleLinkedListSample
    {
        public void Run()
        {
            DoubleLinkedList<int> linkedList = new DoubleLinkedList<int>();
            linkedList.Add(new int[] { 1, 2, 3 });
            linkedList.Parse();
            linkedList.ParseInverse();
        }
    }
}
