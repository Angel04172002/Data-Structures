using System.Collections.Generic;

namespace LinkedListExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();

            list.AddNode(new Node(85));
            list.AddNode(new Node(15));
            list.AddNode(new Node(4));
            list.AddNode(new Node(20));


            list.PrintList();

            list.ReverseList();

            Console.WriteLine();

            Console.WriteLine("reversed\n");
            list.PrintList();
        }
    }
}
