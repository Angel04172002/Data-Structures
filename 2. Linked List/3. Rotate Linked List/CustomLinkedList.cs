using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExercises
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }

        public void AddNode(Node node)
        {
            if(Head == null)
            {
                Head = node;
            }
            else
            {
                Node temp = Head;

                while(temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }
        }

        public void Rotate(int k)
        {
            var node = Head;

            while (node.Next != null)
            {
                node = node.Next;
            }

            for (int i = 0; i < k; i++)
            {
                var currentHead = Head;
                node.Next = Head;
                Head = Head.Next;
                currentHead.Next = null;
                node = currentHead;
            }
        }

        public void PrintList()
        {
            Node temp = Head;

            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
        }
    }
}
