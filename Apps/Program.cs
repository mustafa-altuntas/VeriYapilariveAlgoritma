using DataStructures.LinkedList.SinglyLinkedList;
using System;

namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var linkedlist = new SinglyLinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddFirst(2);
            linkedlist.AddFirst(3);
            // 3 2 1 O(1)

            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            linkedlist.AddLast(6);
            // 3 2 1 4 5 6  O(n)

            Console.ReadKey();




        }
    }
}
