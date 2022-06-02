using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.Linked
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void Add(T[] values)
        {
            foreach (T value in values)
            {
                Add(value);
            }
        }

        public void Add(T value)
        {
            Node<T> node = Last();
            if (node == null)
            {
                Head = new Node<T>() { Value = value };
            }
            else
            {
                node.Next = new Node<T>() { Value = value };
            }
        }

        public Node<T> Last()
        {
            Node<T> current = Head;

            if (current == null)
            {
                return current;
            }

            while (current.Next != null)
            {
                if (current.Next != null)
                    current = current.Next;
            }

            return current;
        }


        public void Parse()
        {
            ParseLinkedList(Head);
        }
        private void ParseLinkedList(Node<T> node)
        {
            Console.Write(node.Value + " ");
            if (node.Next != null)
                ParseLinkedList(node.Next);
            else
                Console.Write("\nDone.");
        }

    }

    public class LinkedListSample
    {
        public void Run()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            foreach (int v in new int[] { 1, 2, 3 })
            {
                linkedList.Add(v);
            }

            linkedList.Parse();

            Console.WriteLine("Last = " + linkedList.Last().Value);
            Console.WriteLine("Head = " + linkedList.Head?.Value);
        }

        public void FindIntersectionOfLists()
        {
            LinkedList<int> linkedList1 = new LinkedList<int>();
            linkedList1.Add(new int[] { 1, 2, 5 });

            LinkedList<int> linkedList2 = new LinkedList<int>();
            linkedList2.Add(new int[] { 3, 4, 5 });

            Console.WriteLine(FindIntersectionPoint(linkedList1.Head, linkedList2.Head)?.Value);
        }

        private Node<int> FindIntersectionPoint(Node<int> list1Node, Node<int> list2Node)
        {
            Console.Write("Node[1]=" + list1Node.Value + " Node[2]=" + list2Node.Value);
            Console.WriteLine();

            if (list1Node.Value == list2Node.Value)
                return list1Node;

            Node<int> intersectionPoint = null;

            if (list1Node.Next != null)
            {
                intersectionPoint = FindIntersectionPoint(list1Node.Next, list2Node);
                if (intersectionPoint != null)
                    return intersectionPoint;
            }

            if (list2Node.Next != null)
            {
                intersectionPoint = FindIntersectionPoint(list1Node, list2Node.Next);
                if (intersectionPoint != null)
                    return intersectionPoint;
            }
                
            return intersectionPoint;
        }

    }
}
