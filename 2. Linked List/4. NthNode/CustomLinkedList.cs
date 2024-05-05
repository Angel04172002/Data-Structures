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

        public void PrintNthNode(int n)
        {
            Node currentNode = Head;

            int count = 0;

            while(currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }

            currentNode = Head;

            for (int i = 0; i < count - n; i++)
            {
                currentNode = currentNode.Next;
            }

            Console.WriteLine(currentNode.Value);
        }
    }
}
